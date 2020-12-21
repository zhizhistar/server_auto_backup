using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ServerAutoBackup
{
    public partial class Form1 : Form
    {
        private bool flag = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void 基础配置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BasicForm basicForm = new BasicForm();
            basicForm.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b')){
                e.Handled = true;
            }
        }



        //  备份数据库文件
        private void Backup()
        {
            //变量表
            string send_email_server = "";
            string send_email_address = "";
            string send_email_password = "";
            string send_email_title = "";
            string send_email_body = "";
            string send_email_to_address = "";
            string send_email_zip_password = "";
            string db_address = "";
            string db_prot = "";
            string db_user = "";
            string db_password = "";
            string db_name = "";

            //读取配置文件，获取相关需要的内容
            Log_Box.Items.Add("开始读取配置文件...");
            XmlDocument xml = new XmlDocument();
            xml.Load(Application.StartupPath + "//config//config.xml");
            //声明一个节点存储根节点
            XmlNode rootNode = xml.DocumentElement;
            foreach (XmlNode node in rootNode)
            {
                Log_Box.Items.Add("开始循环赋值变量");
                switch (node.Name)
                {
                    case "send_email_server":
                        send_email_server = node.InnerText;
                        break;
                    case "send_email_address":
                        send_email_address = node.InnerText;
                        break;
                    case "send_email_password":
                        send_email_password = node.InnerText;
                        break;
                    case "send_email_title":
                        send_email_title = node.InnerText;
                        break;
                    case "send_email_body":
                        send_email_body = node.InnerText;
                        break;
                    case "send_email_to_address":
                        send_email_to_address = node.InnerText;
                        break;
                    case "send_email_file_path":
                        send_email_zip_password = node.InnerText;
                        break;
                    case "db_address":
                        db_address = node.InnerText;
                        break;
                    case "db_prot":
                        db_prot = node.InnerText;
                        break;
                    case "db_user":
                        db_user = node.InnerText;
                        break;
                    case "db_password":
                        db_password = node.InnerText;
                        break;
                    case "db_name":
                        db_name = node.InnerText;
                        break;
                    default:


                        break;

                }
            }

            //链接数据库
            Log_Box.Items.Add("开始连接数据库");
            string connect = "server=" + db_address + ";uid=" + db_user + ";pwd=" + db_password + ";database=" + db_name;
            SqlConnection conn = null;
            //备份语句
            Log_Box.Items.Add("开始准备备份SQL语句");
            string backup_sql = "Backup DataBase " + db_name + " To disk='" + Application.StartupPath +"\\database\\"+db_name+".sql'";
            conn = new SqlConnection(connect);
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.Connection = conn;
            command.CommandText = backup_sql;
            try
            {
                Log_Box.Items.Add("开始执行备份SQL语句");
                conn.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception err)
            {
                MessageBox.Show("链接数据库错误：" + err.Message);
            }
            finally
            {
                Log_Box.Items.Add("备份SQL语句执行完毕");
                Log_Box.Items.Add("关闭数据库连接");
                conn.Close();
                conn.Dispose();
                //压缩并加密数据库文件
                Log_Box.Items.Add("开始压缩数据库文件");
                string filePath = Application.StartupPath + "\\database\\"+db_name+".sql";
                string outPath = Application.StartupPath + "\\database\\"+db_name+".rar";
                Process process = new Process();
                process.StartInfo.FileName = "Winrar.exe";
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.Arguments = " a -p"+send_email_zip_password+" " + outPath + " " + filePath;
                process.Start();
                process.WaitForExit();
                if (process.HasExited)
                {
                    int exitCode = process.ExitCode;
                    if (exitCode == 0)
                    {
                        Log_Box.Items.Add("压缩成功，开始准备发送到远程邮箱的数据结构");
                        //发送邮件到邮箱
                        MailMessage mailMessage = new MailMessage();
                        mailMessage.Subject = send_email_title;
                        mailMessage.Body = send_email_body;
                        mailMessage.Priority = MailPriority.Normal;
                        mailMessage.To.Add(send_email_to_address);
                        mailMessage.From = new MailAddress(send_email_address);
                        SmtpClient smtpClient = new SmtpClient();
                        smtpClient.Host = send_email_server;
                        smtpClient.Credentials = new NetworkCredential(send_email_address, send_email_password);
                        //附件
                        Log_Box.Items.Add("开始准备邮件附件");
                        Attachment attachment = null;
                        attachment = new Attachment(Application.StartupPath+"\\database\\"+db_name+".rar", MediaTypeNames.Application.Zip);
                        mailMessage.Attachments.Add(attachment);
                        Log_Box.Items.Add("开始发送邮件");

                        smtpClient.Send(mailMessage);
                        Log_Box.Items.Add("备份成功，开始删除本地文件");
                        attachment.Dispose();
                        smtpClient.Dispose();
                        File.Delete(Application.StartupPath+"\\database\\"+db_name+".rar");
                        if (!File.Exists(Application.StartupPath + "\\database\\"+db_name+".rar")) { 
                          Log_Box.Items.Add("过程进行完毕，等待下一次执行");
                          Log_Box.TopIndex = Log_Box.Items.Count - 1;
                        }


                    }
                    else
                    {
                        MessageBox.Show("压缩失败");
                    }
                }
                else {
                    MessageBox.Show("error");
                }
            }
        }

        private void Start_Backup_Button_Click(object sender, EventArgs e)
        {
            if (this.flag == false)
            {
                Start_Backup_Button.Text = "停止轮询";
                Log_Box.Items.Add("开始执行定时任务");
                this.Backup();
                int BackupTime = Convert.ToInt32(Backup_Time.Text);
                Auto_Backup_Timer.Interval = BackupTime * 1000;
                Auto_Backup_Timer.Start();
                this.flag = true;
            }
            else { 
                Start_Backup_Button.Text = "开始轮询";
                this.flag = false;
                Auto_Backup_Timer.Stop();
                Log_Box.Items.Add("停止轮询");
                Log_Box.TopIndex = Log_Box.Items.Count - 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            //运行目录生成默认配置文件
            if (!File.Exists(Application.StartupPath + "//config//config.xml")) {
                XmlDocument xml = new XmlDocument();
                XmlElement basic = xml.CreateElement("basic");
                xml.AppendChild(basic);
                //写入发送邮件服务器
                XmlElement send_email_server = xml.CreateElement("send_email_server");
                send_email_server.InnerText = "";
                basic.AppendChild(send_email_server);
                //写入发送邮件地址
                XmlElement send_email_address = xml.CreateElement("send_email_address");
                send_email_address.InnerText = "";
                basic.AppendChild(send_email_address);
                //写入发送邮件密码
                XmlElement send_email_password = xml.CreateElement("send_email_password");
                send_email_password.InnerText = "";
                basic.AppendChild(send_email_password);
                //写入发送邮件标题
                XmlElement send_email_title = xml.CreateElement("send_email_title");
                send_email_title.InnerText = "";
                basic.AppendChild(send_email_title);
                //写入发送邮件内容
                XmlElement send_email_body = xml.CreateElement("send_email_body");
                send_email_body.InnerText = "";
                basic.AppendChild(send_email_body);
                //写入接收邮件地址
                XmlElement send_email_to_address = xml.CreateElement("send_email_to_address");
                send_email_to_address.InnerText = "";
                basic.AppendChild(send_email_to_address);
                //写入需要备份的文件路径
                XmlElement send_email_zip_password = xml.CreateElement("send_email_file_path");
                send_email_zip_password.InnerText = "";
                basic.AppendChild(send_email_zip_password);

                //保存数据库信息
                //写数据库配置,数据库地址
                XmlElement db_address = xml.CreateElement("db_address");
                db_address.InnerText = "";
                basic.AppendChild(db_address);
                //写数据库端口
                XmlElement db_port = xml.CreateElement("db_prot");
                db_port.InnerText = "";
                basic.AppendChild(db_port);
                //写数据库用户名
                XmlElement db_user = xml.CreateElement("db_user");
                db_user.InnerText = "";
                basic.AppendChild(db_user);
                //写数据库密码
                XmlElement db_password = xml.CreateElement("db_password");
                db_password.InnerText = "";
                basic.AppendChild(db_password);
                //写数据库名称
                XmlElement db_name = xml.CreateElement("db_name");
                db_name.InnerText = "";
                basic.AppendChild(db_name);
                //判断配置目录是否存在
                if (!Directory.Exists(Application.StartupPath + "//config")) {
                    //不在进行创建
                    Directory.CreateDirectory(Application.StartupPath + "//config");
                }
                //判断数据库目录是否存在
                if (!Directory.Exists(Application.StartupPath + "//database"))
                {
                    //不在进行创建
                    Directory.CreateDirectory(Application.StartupPath + "//database");
                }

                //写入本地
                try
                {
                    xml.Save(Application.StartupPath + "//config//config.xml");
                    Log_Box.Items.Add("默认配置文件初始化成功");
                }
                catch (Exception err) {
                    MessageBox.Show("配置默认配置文件失败: " + err.Message,"失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void Auto_Backup_Timer_Tick(object sender, EventArgs e)
        {
            this.Backup();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否确定退出程序", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
            else
            {
                e.Cancel = true;
            }
        }

    }
}

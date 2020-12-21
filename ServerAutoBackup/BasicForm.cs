using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ServerAutoBackup
{
    public partial class BasicForm : Form
    {
        public BasicForm()
        {
            InitializeComponent();
        }

        private void Send_Email_Select_Files_Path_Button_Click(object sender, EventArgs e)
        {
            DialogResult dr = Send_Email_Open_File_Dialog.ShowDialog();
            string fileName = Send_Email_Open_File_Dialog.FileName;
            if (dr == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(fileName)) {
                Send_Email_Zip_Password.Text = fileName;
            }
        }

        private void Save_Basic_Config_Click(object sender, EventArgs e)
        {
            //发送邮件服务器
            string send_email_server_value = Send_Email_Smtp_Server.Text;
            //发送邮件地址
            string send_email_address_value = Send_Email_Address.Text;
            //发送邮件密码
            string send_email_password_value = Send_Email_Password.Text;
            //发送邮件标题
            string send_email_title_value = Send_Email_Title.Text;
            //发送邮件内容
            string send_email_body_value = Send_Email_Body.Text;
            //接收数据邮件地址
            string send_email_to_address_value = Send_Email_To_Address.Text;
            //需要备份的文件路径
            string send_email_zip_password_value = Send_Email_Zip_Password.Text;


            XmlDocument xml = new XmlDocument();
            XmlElement basic = xml.CreateElement("basic");
            xml.AppendChild(basic);
            //写入发送邮件服务器
            XmlElement send_email_server = xml.CreateElement("send_email_server");
            send_email_server.InnerText = send_email_server_value;
            basic.AppendChild(send_email_server);
            //写入发送邮件地址
            XmlElement send_email_address = xml.CreateElement("send_email_address");
            send_email_address.InnerText = send_email_address_value;
            basic.AppendChild(send_email_address);
            //写入发送邮件密码
            XmlElement send_email_password = xml.CreateElement("send_email_password");
            send_email_password.InnerText = send_email_password_value;
            basic.AppendChild(send_email_password);
            //写入发送邮件标题
            XmlElement send_email_title = xml.CreateElement("send_email_title");
            send_email_title.InnerText = send_email_title_value;
            basic.AppendChild(send_email_title);
            //写入发送邮件内容
            XmlElement send_email_body = xml.CreateElement("send_email_body");
            send_email_body.InnerText = send_email_body_value;
            basic.AppendChild(send_email_body);
            //写入接收邮件地址
            XmlElement send_email_to_address = xml.CreateElement("send_email_to_address");
            send_email_to_address.InnerText = send_email_to_address_value;
            basic.AppendChild(send_email_to_address);
            //写入需要备份的文件路径
            XmlElement send_email_zip_password = xml.CreateElement("send_email_file_path");
            send_email_zip_password.InnerText = send_email_zip_password_value;
            basic.AppendChild(send_email_zip_password);

            //保存数据库信息
            //写数据库配置,数据库地址
            XmlElement db_address = xml.CreateElement("db_address");
            db_address.InnerText = DB_Address.Text;
            basic.AppendChild(db_address);
            //写数据库端口
            XmlElement db_port = xml.CreateElement("db_prot");
            db_port.InnerText = DB_Port.Text;
            basic.AppendChild(db_port);
            //写数据库用户名
            XmlElement db_user = xml.CreateElement("db_user");
            db_user.InnerText = DB_User.Text;
            basic.AppendChild(db_user);
            //写数据库密码
            XmlElement db_password = xml.CreateElement("db_password");
            db_password.InnerText = DB_Password.Text;
            basic.AppendChild(db_password);
            //写数据库名称
            XmlElement db_name = xml.CreateElement("db_name");
            db_name.InnerText = DB_Name.Text;
            basic.AppendChild(db_name);
            
            //写入配置文件到本地
            try
            {
                xml.Save(Application.StartupPath + "//config//config.xml");
                DialogResult dr = MessageBox.Show("保存成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err) {
                DialogResult dr = MessageBox.Show(err.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        
        private void BasicForm_Load(object sender, EventArgs e)
        {
            //读取默认配置
            XmlDocument xml = new XmlDocument();
            xml.Load(Application.StartupPath + "//config//config.xml");
            //声明一个节点存储根节点
            XmlNode rootNode = xml.DocumentElement;
            //循环读取
            foreach (XmlNode node in rootNode) {
                switch(node.Name){ 
                    case "send_email_server":
                        Send_Email_Smtp_Server.Text = node.InnerText;
                        break;
                    case "send_email_address":
                        Send_Email_Address.Text = node.InnerText;
                        break;
                    case "send_email_password":
                        Send_Email_Password.Text = node.InnerText;
                        break;
                    case "send_email_title":
                        Send_Email_Title.Text = node.InnerText;
                        break;
                    case "send_email_body":
                        Send_Email_Body.Text = node.InnerText;
                        break;
                    case "send_email_to_address":
                        Send_Email_To_Address.Text = node.InnerText;
                        break;
                    case "send_email_file_path":
                        Send_Email_Zip_Password.Text = node.InnerText;
                        break;
                    case "db_address":
                        DB_Address.Text = node.InnerText;
                        break;
                    case "db_prot":
                        DB_Port.Text = node.InnerText;
                        break;
                    case "db_user":
                        DB_User.Text = node.InnerText;
                        break;
                    case "db_password":
                        DB_Password.Text = node.InnerText;
                        break;
                    case "db_name":
                        DB_Name.Text = node.InnerText;
                        break;
                    default:


                        break;

                }
            }
        }

        private void DB_Test_Connetion_Click(object sender, EventArgs e)
        {
            string connect = "server=" + DB_Address.Text + ";uid=" + DB_User.Text + ";pwd=" + DB_Password.Text + ";database=" + DB_Name.Text;
            SqlConnection conn = null;
            try
            {
                conn = new SqlConnection(connect);
                conn.Open();
                MessageBox.Show("连接成功");
            }
            catch (Exception err) {
                MessageBox.Show("连接失败:" + err.Message);
            }
            finally
            {
                if (conn != null) {
                    conn.Close();
                }
            }
        }
    }
}

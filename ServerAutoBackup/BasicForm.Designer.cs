
namespace ServerAutoBackup
{
    partial class BasicForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BasicForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Send_Email_Smtp_Server = new System.Windows.Forms.TextBox();
            this.Send_Email_Address = new System.Windows.Forms.TextBox();
            this.Send_Email_Password = new System.Windows.Forms.TextBox();
            this.Send_Email_Title = new System.Windows.Forms.TextBox();
            this.Send_Email_Body = new System.Windows.Forms.TextBox();
            this.Send_Email_Zip_Password = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Send_Email_To_Address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Send_Email_Select_Files_Path_Button = new System.Windows.Forms.Button();
            this.Send_Email_Open_File_Dialog = new System.Windows.Forms.OpenFileDialog();
            this.Save_Basic_Config = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.DB_Test_Connetion = new System.Windows.Forms.Button();
            this.DB_Name = new System.Windows.Forms.TextBox();
            this.DB_Password = new System.Windows.Forms.TextBox();
            this.DB_User = new System.Windows.Forms.TextBox();
            this.DB_Port = new System.Windows.Forms.TextBox();
            this.DB_Address = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "发送邮件服务器";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "发送邮件地址";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "发送邮件密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "发送邮件标题";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "发送邮件内容";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "压缩密码";
            // 
            // Send_Email_Smtp_Server
            // 
            this.Send_Email_Smtp_Server.Location = new System.Drawing.Point(121, 33);
            this.Send_Email_Smtp_Server.Name = "Send_Email_Smtp_Server";
            this.Send_Email_Smtp_Server.Size = new System.Drawing.Size(184, 21);
            this.Send_Email_Smtp_Server.TabIndex = 6;
            this.Send_Email_Smtp_Server.Text = "smtp.exmail.qq.com";
            // 
            // Send_Email_Address
            // 
            this.Send_Email_Address.Location = new System.Drawing.Point(121, 62);
            this.Send_Email_Address.Name = "Send_Email_Address";
            this.Send_Email_Address.Size = new System.Drawing.Size(184, 21);
            this.Send_Email_Address.TabIndex = 7;
            this.Send_Email_Address.Text = "star@cqzhizhi.com";
            // 
            // Send_Email_Password
            // 
            this.Send_Email_Password.Location = new System.Drawing.Point(121, 95);
            this.Send_Email_Password.Name = "Send_Email_Password";
            this.Send_Email_Password.PasswordChar = '*';
            this.Send_Email_Password.Size = new System.Drawing.Size(184, 21);
            this.Send_Email_Password.TabIndex = 8;
            this.Send_Email_Password.Text = "Hq1314520";
            // 
            // Send_Email_Title
            // 
            this.Send_Email_Title.Location = new System.Drawing.Point(121, 121);
            this.Send_Email_Title.Name = "Send_Email_Title";
            this.Send_Email_Title.Size = new System.Drawing.Size(184, 21);
            this.Send_Email_Title.TabIndex = 9;
            this.Send_Email_Title.Text = "新的备份数据";
            // 
            // Send_Email_Body
            // 
            this.Send_Email_Body.Location = new System.Drawing.Point(121, 175);
            this.Send_Email_Body.Name = "Send_Email_Body";
            this.Send_Email_Body.Size = new System.Drawing.Size(184, 21);
            this.Send_Email_Body.TabIndex = 10;
            this.Send_Email_Body.Text = "最新的一次备份数据";
            // 
            // Send_Email_Zip_Password
            // 
            this.Send_Email_Zip_Password.Location = new System.Drawing.Point(121, 206);
            this.Send_Email_Zip_Password.Name = "Send_Email_Zip_Password";
            this.Send_Email_Zip_Password.Size = new System.Drawing.Size(137, 21);
            this.Send_Email_Zip_Password.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Send_Email_To_Address);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Send_Email_Select_Files_Path_Button);
            this.groupBox1.Controls.Add(this.Send_Email_Smtp_Server);
            this.groupBox1.Controls.Add(this.Send_Email_Zip_Password);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Send_Email_Body);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Send_Email_Title);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Send_Email_Password);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Send_Email_Address);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(1, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 279);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "邮件基础设置";
            // 
            // Send_Email_To_Address
            // 
            this.Send_Email_To_Address.Location = new System.Drawing.Point(121, 148);
            this.Send_Email_To_Address.Name = "Send_Email_To_Address";
            this.Send_Email_To_Address.Size = new System.Drawing.Size(184, 21);
            this.Send_Email_To_Address.TabIndex = 14;
            this.Send_Email_To_Address.Text = "1037067594@qq.com";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "接收数据邮箱";
            // 
            // Send_Email_Select_Files_Path_Button
            // 
            this.Send_Email_Select_Files_Path_Button.Location = new System.Drawing.Point(264, 206);
            this.Send_Email_Select_Files_Path_Button.Name = "Send_Email_Select_Files_Path_Button";
            this.Send_Email_Select_Files_Path_Button.Size = new System.Drawing.Size(41, 23);
            this.Send_Email_Select_Files_Path_Button.TabIndex = 12;
            this.Send_Email_Select_Files_Path_Button.Text = "浏览";
            this.Send_Email_Select_Files_Path_Button.UseVisualStyleBackColor = true;
            this.Send_Email_Select_Files_Path_Button.Click += new System.EventHandler(this.Send_Email_Select_Files_Path_Button_Click);
            // 
            // Send_Email_Open_File_Dialog
            // 
            this.Send_Email_Open_File_Dialog.FileName = "openFileDialog1";
            // 
            // Save_Basic_Config
            // 
            this.Save_Basic_Config.Location = new System.Drawing.Point(607, 473);
            this.Save_Basic_Config.Name = "Save_Basic_Config";
            this.Save_Basic_Config.Size = new System.Drawing.Size(121, 23);
            this.Save_Basic_Config.TabIndex = 21;
            this.Save_Basic_Config.Text = "保存配置";
            this.Save_Basic_Config.UseVisualStyleBackColor = true;
            this.Save_Basic_Config.Click += new System.EventHandler(this.Save_Basic_Config_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DB_Test_Connetion);
            this.groupBox2.Controls.Add(this.DB_Name);
            this.groupBox2.Controls.Add(this.DB_Password);
            this.groupBox2.Controls.Add(this.DB_User);
            this.groupBox2.Controls.Add(this.DB_Port);
            this.groupBox2.Controls.Add(this.DB_Address);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(361, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 279);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据库配置";
            // 
            // DB_Test_Connetion
            // 
            this.DB_Test_Connetion.Location = new System.Drawing.Point(247, 178);
            this.DB_Test_Connetion.Name = "DB_Test_Connetion";
            this.DB_Test_Connetion.Size = new System.Drawing.Size(75, 23);
            this.DB_Test_Connetion.TabIndex = 28;
            this.DB_Test_Connetion.Text = "测试连接";
            this.DB_Test_Connetion.UseVisualStyleBackColor = true;
            this.DB_Test_Connetion.Click += new System.EventHandler(this.DB_Test_Connetion_Click);
            // 
            // DB_Name
            // 
            this.DB_Name.Location = new System.Drawing.Point(94, 139);
            this.DB_Name.Name = "DB_Name";
            this.DB_Name.Size = new System.Drawing.Size(228, 21);
            this.DB_Name.TabIndex = 27;
            this.DB_Name.Text = "demo";
            // 
            // DB_Password
            // 
            this.DB_Password.Location = new System.Drawing.Point(94, 112);
            this.DB_Password.Name = "DB_Password";
            this.DB_Password.PasswordChar = '*';
            this.DB_Password.Size = new System.Drawing.Size(228, 21);
            this.DB_Password.TabIndex = 26;
            this.DB_Password.Text = "123456";
            // 
            // DB_User
            // 
            this.DB_User.Location = new System.Drawing.Point(94, 86);
            this.DB_User.Name = "DB_User";
            this.DB_User.Size = new System.Drawing.Size(228, 21);
            this.DB_User.TabIndex = 25;
            this.DB_User.Text = "sa";
            // 
            // DB_Port
            // 
            this.DB_Port.Location = new System.Drawing.Point(94, 56);
            this.DB_Port.Name = "DB_Port";
            this.DB_Port.Size = new System.Drawing.Size(228, 21);
            this.DB_Port.TabIndex = 24;
            // 
            // DB_Address
            // 
            this.DB_Address.Location = new System.Drawing.Point(94, 27);
            this.DB_Address.Name = "DB_Address";
            this.DB_Address.Size = new System.Drawing.Size(228, 21);
            this.DB_Address.TabIndex = 23;
            this.DB_Address.Text = "127.0.0.1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 4;
            this.label12.Text = "数据库名称";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 3;
            this.label11.Text = "数据库密码";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 12);
            this.label10.TabIndex = 2;
            this.label10.Text = "数据库用户";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "数据库端口";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "数据库地址";
            // 
            // BasicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Save_Basic_Config);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BasicForm";
            this.Text = "基础配置";
            this.Load += new System.EventHandler(this.BasicForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Send_Email_Smtp_Server;
        private System.Windows.Forms.TextBox Send_Email_Address;
        private System.Windows.Forms.TextBox Send_Email_Password;
        private System.Windows.Forms.TextBox Send_Email_Title;
        private System.Windows.Forms.TextBox Send_Email_Body;
        private System.Windows.Forms.TextBox Send_Email_Zip_Password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Send_Email_Select_Files_Path_Button;
        private System.Windows.Forms.OpenFileDialog Send_Email_Open_File_Dialog;
        private System.Windows.Forms.Button Save_Basic_Config;
        private System.Windows.Forms.TextBox Send_Email_To_Address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox DB_Name;
        private System.Windows.Forms.TextBox DB_Password;
        private System.Windows.Forms.TextBox DB_User;
        private System.Windows.Forms.TextBox DB_Port;
        private System.Windows.Forms.TextBox DB_Address;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button DB_Test_Connetion;
    }
}
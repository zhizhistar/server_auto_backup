
namespace ServerAutoBackup
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.首选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.基础配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Backup_Time = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Start_Backup_Button = new System.Windows.Forms.Button();
            this.Log_Box = new System.Windows.Forms.ListBox();
            this.Auto_Backup_Timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.首选项ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(331, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 首选项ToolStripMenuItem
            // 
            this.首选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.基础配置ToolStripMenuItem});
            this.首选项ToolStripMenuItem.Name = "首选项ToolStripMenuItem";
            this.首选项ToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.首选项ToolStripMenuItem.Text = "首选项";
            // 
            // 基础配置ToolStripMenuItem
            // 
            this.基础配置ToolStripMenuItem.Name = "基础配置ToolStripMenuItem";
            this.基础配置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.基础配置ToolStripMenuItem.Text = "基础配置";
            this.基础配置ToolStripMenuItem.Click += new System.EventHandler(this.基础配置ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "备份轮询间隔";
            // 
            // Backup_Time
            // 
            this.Backup_Time.Location = new System.Drawing.Point(109, 66);
            this.Backup_Time.Name = "Backup_Time";
            this.Backup_Time.Size = new System.Drawing.Size(138, 21);
            this.Backup_Time.TabIndex = 2;
            this.Backup_Time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "秒/次";
            // 
            // Start_Backup_Button
            // 
            this.Start_Backup_Button.Location = new System.Drawing.Point(172, 119);
            this.Start_Backup_Button.Name = "Start_Backup_Button";
            this.Start_Backup_Button.Size = new System.Drawing.Size(75, 23);
            this.Start_Backup_Button.TabIndex = 0;
            this.Start_Backup_Button.Text = "开始轮询";
            this.Start_Backup_Button.Click += new System.EventHandler(this.Start_Backup_Button_Click);
            // 
            // Log_Box
            // 
            this.Log_Box.Enabled = false;
            this.Log_Box.FormattingEnabled = true;
            this.Log_Box.ItemHeight = 12;
            this.Log_Box.Location = new System.Drawing.Point(12, 194);
            this.Log_Box.Name = "Log_Box";
            this.Log_Box.ScrollAlwaysVisible = true;
            this.Log_Box.Size = new System.Drawing.Size(307, 304);
            this.Log_Box.TabIndex = 4;
            // 
            // Auto_Backup_Timer
            // 
            this.Auto_Backup_Timer.Tick += new System.EventHandler(this.Auto_Backup_Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 508);
            this.Controls.Add(this.Log_Box);
            this.Controls.Add(this.Start_Backup_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Backup_Time);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "数据库自动备份小助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 首选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 基础配置ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Backup_Time;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Start_Backup_Button;
        private System.Windows.Forms.ListBox Log_Box;
        private System.Windows.Forms.Timer Auto_Backup_Timer;
    }
}


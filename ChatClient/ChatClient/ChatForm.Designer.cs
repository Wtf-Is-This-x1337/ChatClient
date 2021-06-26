namespace ChatClient
{
    partial class ChatForm
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.Line = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.TextUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextIp = new System.Windows.Forms.TextBox();
            this.Settings = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NetworkInterface = new System.Windows.Forms.ListBox();
            this.DefaultPort = new System.Windows.Forms.Label();
            this.ip = new System.Windows.Forms.Label();
            this.Stuff = new System.Windows.Forms.Label();
            this.IpText = new System.Windows.Forms.Label();
            this.SettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(861, 459);
            this.listBox1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 486);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(735, 20);
            this.textBox1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(762, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.Controls.Add(this.Line);
            this.SettingsPanel.Controls.Add(this.Connect);
            this.SettingsPanel.Controls.Add(this.TextUser);
            this.SettingsPanel.Controls.Add(this.label4);
            this.SettingsPanel.Controls.Add(this.TextPort);
            this.SettingsPanel.Controls.Add(this.label1);
            this.SettingsPanel.Controls.Add(this.TextIp);
            this.SettingsPanel.Controls.Add(this.Settings);
            this.SettingsPanel.Controls.Add(this.label3);
            this.SettingsPanel.Controls.Add(this.label2);
            this.SettingsPanel.Controls.Add(this.NetworkInterface);
            this.SettingsPanel.Controls.Add(this.DefaultPort);
            this.SettingsPanel.Controls.Add(this.ip);
            this.SettingsPanel.Controls.Add(this.Stuff);
            this.SettingsPanel.Controls.Add(this.IpText);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(885, 532);
            this.SettingsPanel.TabIndex = 4;
            // 
            // Line
            // 
            this.Line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Line.Location = new System.Drawing.Point(152, 11);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(2, 175);
            this.Line.TabIndex = 29;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(183, 142);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(141, 30);
            this.Connect.TabIndex = 28;
            this.Connect.Text = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // TextUser
            // 
            this.TextUser.Location = new System.Drawing.Point(246, 102);
            this.TextUser.Name = "TextUser";
            this.TextUser.Size = new System.Drawing.Size(89, 20);
            this.TextUser.TabIndex = 27;
            this.TextUser.Text = "test";
            this.TextUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(170, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Username:";
            // 
            // TextPort
            // 
            this.TextPort.Location = new System.Drawing.Point(246, 76);
            this.TextPort.Name = "TextPort";
            this.TextPort.Size = new System.Drawing.Size(89, 20);
            this.TextPort.TabIndex = 25;
            this.TextPort.Text = "54000";
            this.TextPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label1.Location = new System.Drawing.Point(170, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Server Port:";
            // 
            // TextIp
            // 
            this.TextIp.Location = new System.Drawing.Point(235, 50);
            this.TextIp.Name = "TextIp";
            this.TextIp.Size = new System.Drawing.Size(100, 20);
            this.TextIp.TabIndex = 23;
            this.TextIp.Text = "127.0.0.1";
            this.TextIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Settings
            // 
            this.Settings.AutoSize = true;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.Location = new System.Drawing.Point(220, 12);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(59, 15);
            this.Settings.TabIndex = 22;
            this.Settings.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(170, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Server IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Network Interfaces:";
            // 
            // NetworkInterface
            // 
            this.NetworkInterface.FormattingEnabled = true;
            this.NetworkInterface.Location = new System.Drawing.Point(14, 102);
            this.NetworkInterface.Name = "NetworkInterface";
            this.NetworkInterface.ScrollAlwaysVisible = true;
            this.NetworkInterface.Size = new System.Drawing.Size(120, 82);
            this.NetworkInterface.TabIndex = 19;
            // 
            // DefaultPort
            // 
            this.DefaultPort.AutoSize = true;
            this.DefaultPort.Location = new System.Drawing.Point(13, 62);
            this.DefaultPort.Name = "DefaultPort";
            this.DefaultPort.Size = new System.Drawing.Size(99, 13);
            this.DefaultPort.TabIndex = 18;
            this.DefaultPort.Text = "Default Port: 54000";
            // 
            // ip
            // 
            this.ip.AutoSize = true;
            this.ip.Location = new System.Drawing.Point(66, 39);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(15, 13);
            this.ip.TabIndex = 17;
            this.ip.Text = "ip";
            // 
            // Stuff
            // 
            this.Stuff.AutoSize = true;
            this.Stuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stuff.Location = new System.Drawing.Point(29, 12);
            this.Stuff.Name = "Stuff";
            this.Stuff.Size = new System.Drawing.Size(91, 15);
            this.Stuff.TabIndex = 16;
            this.Stuff.Text = "Useless Stuff";
            // 
            // IpText
            // 
            this.IpText.AutoSize = true;
            this.IpText.Location = new System.Drawing.Point(13, 38);
            this.IpText.Name = "IpText";
            this.IpText.Size = new System.Drawing.Size(57, 13);
            this.IpText.TabIndex = 15;
            this.IpText.Text = "Your IPv4:";
            // 
            // ChatForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 532);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "ChatForm";
            this.ShowIcon = false;
            this.Text = "Chat Client";
            this.Load += new System.EventHandler(this.ChatForm_Load);
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.TextBox TextUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextIp;
        private System.Windows.Forms.Label Settings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox NetworkInterface;
        private System.Windows.Forms.Label DefaultPort;
        private System.Windows.Forms.Label ip;
        private System.Windows.Forms.Label Stuff;
        private System.Windows.Forms.Label IpText;
        private System.Windows.Forms.Label Line;
    }
}


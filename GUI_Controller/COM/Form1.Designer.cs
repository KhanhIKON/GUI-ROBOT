namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_baudrate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.cbx_ComPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Serial_Port = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_Send = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_close = new System.Windows.Forms.Button();
            this.rtb_text = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.cbx_Motor_Choi = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(136, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(617, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "GUI ROBOT CONTROLLER";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_baudrate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.btn_Disconnect);
            this.groupBox1.Controls.Add(this.btn_Connect);
            this.groupBox1.Controls.Add(this.cbx_ComPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox1.Location = new System.Drawing.Point(13, 205);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(355, 237);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Setup";
            // 
            // cmb_baudrate
            // 
            this.cmb_baudrate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cmb_baudrate.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmb_baudrate.FormattingEnabled = true;
            this.cmb_baudrate.Location = new System.Drawing.Point(142, 115);
            this.cmb_baudrate.Name = "cmb_baudrate";
            this.cmb_baudrate.Size = new System.Drawing.Size(191, 33);
            this.cmb_baudrate.TabIndex = 8;
            this.cmb_baudrate.Text = "9600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "BaudRate:";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Status.Location = new System.Drawing.Point(147, 31);
            this.lbl_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(74, 25);
            this.lbl_Status.TabIndex = 6;
            this.lbl_Status.Text = "Status";
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Disconnect.Location = new System.Drawing.Point(182, 175);
            this.btn_Disconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(151, 42);
            this.btn_Disconnect.TabIndex = 5;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = false;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Connect.FlatAppearance.BorderSize = 0;
            this.btn_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Connect.ForeColor = System.Drawing.Color.Aqua;
            this.btn_Connect.Location = new System.Drawing.Point(14, 175);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(141, 42);
            this.btn_Connect.TabIndex = 4;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // cbx_ComPort
            // 
            this.cbx_ComPort.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cbx_ComPort.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cbx_ComPort.FormattingEnabled = true;
            this.cbx_ComPort.Location = new System.Drawing.Point(142, 68);
            this.cbx_ComPort.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_ComPort.Name = "cbx_ComPort";
            this.cbx_ComPort.Size = new System.Drawing.Size(191, 33);
            this.cbx_ComPort.TabIndex = 3;
            this.cbx_ComPort.Text = "Select Com Port";
            this.cbx_ComPort.TextChanged += new System.EventHandler(this.cbx_ComPort_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "COM Port:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtb_text);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox2.Location = new System.Drawing.Point(461, 262);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(408, 278);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Receive";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbx_Motor_Choi);
            this.groupBox3.Controls.Add(this.btn_Send);
            this.groupBox3.Controls.Add(this.txt_Send);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Cyan;
            this.groupBox3.Location = new System.Drawing.Point(461, 94);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(408, 160);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Send Data";
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Send.ForeColor = System.Drawing.Color.Cyan;
            this.btn_Send.Location = new System.Drawing.Point(227, 99);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(123, 43);
            this.btn_Send.TabIndex = 1;
            this.btn_Send.Text = "SEND";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_Send
            // 
            this.txt_Send.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_Send.Location = new System.Drawing.Point(8, 48);
            this.txt_Send.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Send.Name = "txt_Send";
            this.txt_Send.Size = new System.Drawing.Size(392, 30);
            this.txt_Send.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Yellow;
            this.btn_close.Location = new System.Drawing.Point(110, 473);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(167, 51);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "EXIT";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // rtb_text
            // 
            this.rtb_text.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.rtb_text.Enabled = false;
            this.rtb_text.Location = new System.Drawing.Point(8, 30);
            this.rtb_text.Name = "rtb_text";
            this.rtb_text.Size = new System.Drawing.Size(392, 241);
            this.rtb_text.TabIndex = 6;
            this.rtb_text.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(324, 473);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(119, 36);
            this.listBox1.TabIndex = 7;
            this.listBox1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "COM Status";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.SystemColors.Desktop;
            this.logo.Image = global::COM.Properties.Resources.logo_vista;
            this.logo.Location = new System.Drawing.Point(13, 94);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(375, 84);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 8;
            this.logo.TabStop = false;
            // 
            // cbx_Motor_Choi
            // 
            this.cbx_Motor_Choi.AutoSize = true;
            this.cbx_Motor_Choi.Location = new System.Drawing.Point(29, 99);
            this.cbx_Motor_Choi.Name = "cbx_Motor_Choi";
            this.cbx_Motor_Choi.Size = new System.Drawing.Size(130, 29);
            this.cbx_Motor_Choi.TabIndex = 2;
            this.cbx_Motor_Choi.Text = "Motor Chổi";
            this.cbx_Motor_Choi.UseVisualStyleBackColor = true;
            this.cbx_Motor_Choi.CheckedChanged += new System.EventHandler(this.cbx_Motor_Choi_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VISTA-INDUSTRY";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.ComboBox cbx_ComPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.IO.Ports.SerialPort Serial_Port;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_Send;
        private System.Windows.Forms.ComboBox cmb_baudrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.RichTextBox rtb_text;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.CheckBox cbx_Motor_Choi;
    }
}


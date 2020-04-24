namespace BaiDoXe
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_cam2 = new System.Windows.Forms.ComboBox();
            this.cb_cam1 = new System.Windows.Forms.ComboBox();
            this.bt_opencam2 = new System.Windows.Forms.Button();
            this.pb_Display2 = new System.Windows.Forms.PictureBox();
            this.pb_Display1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_numCard = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.bt_opencam1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_status_device = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.cb_COM = new System.Windows.Forms.ComboBox();
            this.tb_baurate = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_Camera2 = new System.Windows.Forms.PictureBox();
            this.pb_Camera1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bt_export = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CARD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIME_IN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIME_OUT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Display2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Display1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Camera2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Camera1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1055, 730);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1047, 704);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Home";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(709, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 691);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cb_cam2);
            this.groupBox4.Controls.Add(this.cb_cam1);
            this.groupBox4.Controls.Add(this.bt_opencam2);
            this.groupBox4.Controls.Add(this.pb_Display2);
            this.groupBox4.Controls.Add(this.pb_Display1);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.lb_numCard);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lb_time);
            this.groupBox4.Controls.Add(this.bt_opencam1);
            this.groupBox4.Location = new System.Drawing.Point(7, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 509);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(243, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Load2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(243, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Load1";
            // 
            // cb_cam2
            // 
            this.cb_cam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_cam2.FormattingEnabled = true;
            this.cb_cam2.Location = new System.Drawing.Point(171, 417);
            this.cb_cam2.Name = "cb_cam2";
            this.cb_cam2.Size = new System.Drawing.Size(121, 21);
            this.cb_cam2.TabIndex = 12;
            // 
            // cb_cam1
            // 
            this.cb_cam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_cam1.FormattingEnabled = true;
            this.cb_cam1.Location = new System.Drawing.Point(12, 417);
            this.cb_cam1.Name = "cb_cam1";
            this.cb_cam1.Size = new System.Drawing.Size(121, 21);
            this.cb_cam1.TabIndex = 11;
            // 
            // bt_opencam2
            // 
            this.bt_opencam2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_opencam2.Location = new System.Drawing.Point(171, 463);
            this.bt_opencam2.Name = "bt_opencam2";
            this.bt_opencam2.Size = new System.Drawing.Size(121, 31);
            this.bt_opencam2.TabIndex = 10;
            this.bt_opencam2.Text = "Open Camera2";
            this.bt_opencam2.UseVisualStyleBackColor = true;
            this.bt_opencam2.Click += new System.EventHandler(this.bt_opencam2_Click);
            // 
            // pb_Display2
            // 
            this.pb_Display2.Location = new System.Drawing.Point(13, 207);
            this.pb_Display2.Name = "pb_Display2";
            this.pb_Display2.Size = new System.Drawing.Size(280, 141);
            this.pb_Display2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Display2.TabIndex = 9;
            this.pb_Display2.TabStop = false;
            // 
            // pb_Display1
            // 
            this.pb_Display1.Location = new System.Drawing.Point(12, 31);
            this.pb_Display1.Name = "pb_Display1";
            this.pb_Display1.Size = new System.Drawing.Size(280, 140);
            this.pb_Display1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Display1.TabIndex = 8;
            this.pb_Display1.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Time:";
            // 
            // lb_numCard
            // 
            this.lb_numCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_numCard.AutoSize = true;
            this.lb_numCard.Location = new System.Drawing.Point(146, 391);
            this.lb_numCard.Name = "lb_numCard";
            this.lb_numCard.Size = new System.Drawing.Size(13, 13);
            this.lb_numCard.TabIndex = 5;
            this.lb_numCard.Text = "0";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số thẻ: ";
            // 
            // lb_time
            // 
            this.lb_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(96, 364);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(13, 13);
            this.lb_time.TabIndex = 2;
            this.lb_time.Text = "0";
            // 
            // bt_opencam1
            // 
            this.bt_opencam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_opencam1.Location = new System.Drawing.Point(12, 463);
            this.bt_opencam1.Name = "bt_opencam1";
            this.bt_opencam1.Size = new System.Drawing.Size(121, 31);
            this.bt_opencam1.TabIndex = 1;
            this.bt_opencam1.Text = "Open Camera1";
            this.bt_opencam1.UseVisualStyleBackColor = true;
            this.bt_opencam1.Click += new System.EventHandler(this.bt_opencam1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lb_status_device);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.bt_Connect);
            this.groupBox3.Controls.Add(this.cb_COM);
            this.groupBox3.Controls.Add(this.tb_baurate);
            this.groupBox3.Location = new System.Drawing.Point(7, 535);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(308, 149);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Connect Device";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Status :";
            // 
            // lb_status_device
            // 
            this.lb_status_device.AutoSize = true;
            this.lb_status_device.Location = new System.Drawing.Point(106, 30);
            this.lb_status_device.Name = "lb_status_device";
            this.lb_status_device.Size = new System.Drawing.Size(61, 13);
            this.lb_status_device.TabIndex = 5;
            this.lb_status_device.Text = "Disconnect";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Baud";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "COM";
            // 
            // bt_Connect
            // 
            this.bt_Connect.Location = new System.Drawing.Point(195, 70);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(107, 62);
            this.bt_Connect.TabIndex = 2;
            this.bt_Connect.Text = "Connection";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // cb_COM
            // 
            this.cb_COM.FormattingEnabled = true;
            this.cb_COM.Location = new System.Drawing.Point(57, 70);
            this.cb_COM.Name = "cb_COM";
            this.cb_COM.Size = new System.Drawing.Size(121, 21);
            this.cb_COM.TabIndex = 1;
            // 
            // tb_baurate
            // 
            this.tb_baurate.Location = new System.Drawing.Point(57, 112);
            this.tb_baurate.Name = "tb_baurate";
            this.tb_baurate.Size = new System.Drawing.Size(121, 20);
            this.tb_baurate.TabIndex = 0;
            this.tb_baurate.Text = "9600";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pb_Camera2);
            this.groupBox1.Controls.Add(this.pb_Camera1);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 691);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Camera";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(611, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Camera2";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(625, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Camera1";
            // 
            // pb_Camera2
            // 
            this.pb_Camera2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Camera2.Location = new System.Drawing.Point(6, 371);
            this.pb_Camera2.Name = "pb_Camera2";
            this.pb_Camera2.Size = new System.Drawing.Size(676, 313);
            this.pb_Camera2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Camera2.TabIndex = 1;
            this.pb_Camera2.TabStop = false;
            // 
            // pb_Camera1
            // 
            this.pb_Camera1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Camera1.Location = new System.Drawing.Point(6, 35);
            this.pb_Camera1.Name = "pb_Camera1";
            this.pb_Camera1.Size = new System.Drawing.Size(668, 317);
            this.pb_Camera1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Camera1.TabIndex = 0;
            this.pb_Camera1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bt_export);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1047, 704);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bt_export
            // 
            this.bt_export.Location = new System.Drawing.Point(27, 27);
            this.bt_export.Name = "bt_export";
            this.bt_export.Size = new System.Drawing.Size(75, 23);
            this.bt_export.TabIndex = 1;
            this.bt_export.Text = "Xuất FILE";
            this.bt_export.UseVisualStyleBackColor = true;
            this.bt_export.Click += new System.EventHandler(this.bt_export_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CARD,
            this.TIME_IN,
            this.TIME_OUT});
            this.dataGridView1.Location = new System.Drawing.Point(502, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 692);
            this.dataGridView1.TabIndex = 0;
            // 
            // CARD
            // 
            this.CARD.HeaderText = "Card";
            this.CARD.Name = "CARD";
            this.CARD.Width = 200;
            // 
            // TIME_IN
            // 
            this.TIME_IN.HeaderText = "Time In";
            this.TIME_IN.Name = "TIME_IN";
            this.TIME_IN.Width = 150;
            // 
            // TIME_OUT
            // 
            this.TIME_OUT.HeaderText = "Time OUT";
            this.TIME_OUT.Name = "TIME_OUT";
            this.TIME_OUT.Width = 150;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 742);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Bãi Đỗ Xe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Display2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Display1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Camera2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Camera1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb_Camera1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_numCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Button bt_opencam1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.ComboBox cb_COM;
        private System.Windows.Forms.TextBox tb_baurate;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pb_Display1;
        private System.Windows.Forms.Button bt_export;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CARD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIME_IN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIME_OUT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_status_device;
        private System.Windows.Forms.PictureBox pb_Display2;
        private System.Windows.Forms.PictureBox pb_Camera2;
        private System.Windows.Forms.ComboBox cb_cam2;
        private System.Windows.Forms.ComboBox cb_cam1;
        private System.Windows.Forms.Button bt_opencam2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}


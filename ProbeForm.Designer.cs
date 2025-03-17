namespace SoilProbeConfig
    {
    partial class ProbeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProbeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.openLabel = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rs485Port = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TestLabel = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.UpdateLabel = new System.Windows.Forms.LinkLabel();
            this.label8 = new System.Windows.Forms.Label();
            this.ConfirmLabel = new System.Windows.Forms.LinkLabel();
            this.newAddrUpDown = new System.Windows.Forms.NumericUpDown();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.addrLabel = new System.Windows.Forms.Label();
            this.baudLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.newAddrLabel = new System.Windows.Forms.Label();
            this.newBaudLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newAddrUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(17, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soil Probe Configuration";
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaud.Location = new System.Drawing.Point(70, 90);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(77, 25);
            this.comboBoxBaud.TabIndex = 30;
            this.comboBoxBaud.Text = "115200";
            this.comboBoxBaud.SelectedIndexChanged += new System.EventHandler(this.ComboBoxBaud_SelectedIndexChanged);
            // 
            // openLabel
            // 
            this.openLabel.AutoSize = true;
            this.openLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openLabel.ForeColor = System.Drawing.Color.Green;
            this.openLabel.Location = new System.Drawing.Point(15, 144);
            this.openLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.openLabel.Name = "openLabel";
            this.openLabel.Size = new System.Drawing.Size(81, 20);
            this.openLabel.TabIndex = 29;
            this.openLabel.Text = "CLOSED";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6"});
            this.comboBoxPort.Location = new System.Drawing.Point(71, 59);
            this.comboBoxPort.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(76, 25);
            this.comboBoxPort.TabIndex = 25;
            this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPort_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 27;
            this.label6.Text = "Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 87);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 26;
            this.label5.Text = "Baud:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "RS485 Port";
            // 
            // rs485Port
            // 
            this.rs485Port.PortName = "COM2";
            this.rs485Port.ReadTimeout = 100;
            this.rs485Port.WriteTimeout = 3000;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 36);
            this.label3.TabIndex = 31;
            this.label3.Text = "2. Attach the probe with the Green wire \r\n connected to the V+ and turn the Power" +
    " ON.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(288, 61);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "1. Power OFF";
            // 
            // TestLabel
            // 
            this.TestLabel.AutoSize = true;
            this.TestLabel.Location = new System.Drawing.Point(309, 154);
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(155, 17);
            this.TestLabel.TabIndex = 33;
            this.TestLabel.TabStop = true;
            this.TestLabel.Text = "Then click here to test.";
            this.TestLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.TestLabel_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxPort);
            this.panel1.Controls.Add(this.comboBoxBaud);
            this.panel1.Controls.Add(this.openLabel);
            this.panel1.Location = new System.Drawing.Point(20, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 197);
            this.panel1.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(288, 208);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(380, 18);
            this.label7.TabIndex = 36;
            this.label7.Text = "3. Select a new address and baud rate will be 115200.";
            // 
            // UpdateLabel
            // 
            this.UpdateLabel.AutoSize = true;
            this.UpdateLabel.Location = new System.Drawing.Point(309, 241);
            this.UpdateLabel.Name = "UpdateLabel";
            this.UpdateLabel.Size = new System.Drawing.Size(175, 17);
            this.UpdateLabel.TabIndex = 37;
            this.UpdateLabel.TabStop = true;
            this.UpdateLabel.Text = "Then click here to update.";
            this.UpdateLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.UpdateLabel_LinkClicked);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(288, 293);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(383, 18);
            this.label8.TabIndex = 38;
            this.label8.Text = "4. Power OFF, remove the Green wire and Power ON.";
            // 
            // ConfirmLabel
            // 
            this.ConfirmLabel.AutoSize = true;
            this.ConfirmLabel.Location = new System.Drawing.Point(309, 323);
            this.ConfirmLabel.Name = "ConfirmLabel";
            this.ConfirmLabel.Size = new System.Drawing.Size(180, 17);
            this.ConfirmLabel.TabIndex = 39;
            this.ConfirmLabel.TabStop = true;
            this.ConfirmLabel.Text = "Then click here to confirm.";
            this.ConfirmLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ConfirmLabel_LinkClicked);
            // 
            // newAddrUpDown
            // 
            this.newAddrUpDown.Location = new System.Drawing.Point(675, 206);
            this.newAddrUpDown.Name = "newAddrUpDown";
            this.newAddrUpDown.Size = new System.Drawing.Size(63, 25);
            this.newAddrUpDown.TabIndex = 40;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 17;
            this.listBox.Location = new System.Drawing.Point(752, 60);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(285, 480);
            this.listBox.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(309, 171);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 14);
            this.label9.TabIndex = 42;
            this.label9.Text = "(Expected result: Temperature and soil moisture %)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(309, 258);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 14);
            this.label10.TabIndex = 43;
            this.label10.Text = "(Expected result: Response = new addess.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(309, 340);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(253, 14);
            this.label11.TabIndex = 44;
            this.label11.Text = "(Expected result: Temperature and soil moisture %)";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(12, 282);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(232, 14);
            this.label38.TabIndex = 45;
            this.label38.Text = "0x0000 - SW, 0x0200 - Address, 0x0201 Baud";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SoilProbeConfig.Properties.Resources.probe;
            this.pictureBox1.Location = new System.Drawing.Point(15, 368);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(288, 406);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 18);
            this.label12.TabIndex = 47;
            this.label12.Text = "Address:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(288, 440);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 18);
            this.label13.TabIndex = 48;
            this.label13.Text = "Baud rate:";
            // 
            // addrLabel
            // 
            this.addrLabel.AutoSize = true;
            this.addrLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrLabel.Location = new System.Drawing.Point(402, 406);
            this.addrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addrLabel.Name = "addrLabel";
            this.addrLabel.Size = new System.Drawing.Size(16, 18);
            this.addrLabel.TabIndex = 49;
            this.addrLabel.Text = "0";
            // 
            // baudLabel
            // 
            this.baudLabel.AutoSize = true;
            this.baudLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudLabel.Location = new System.Drawing.Point(402, 440);
            this.baudLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.baudLabel.Name = "baudLabel";
            this.baudLabel.Size = new System.Drawing.Size(16, 18);
            this.baudLabel.TabIndex = 50;
            this.baudLabel.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(381, 377);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 18);
            this.label14.TabIndex = 51;
            this.label14.Text = "From";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(492, 377);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 18);
            this.label15.TabIndex = 52;
            this.label15.Text = "To";
            // 
            // newAddrLabel
            // 
            this.newAddrLabel.AutoSize = true;
            this.newAddrLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAddrLabel.Location = new System.Drawing.Point(492, 406);
            this.newAddrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newAddrLabel.Name = "newAddrLabel";
            this.newAddrLabel.Size = new System.Drawing.Size(16, 18);
            this.newAddrLabel.TabIndex = 53;
            this.newAddrLabel.Text = "0";
            // 
            // newBaudLabel
            // 
            this.newBaudLabel.AutoSize = true;
            this.newBaudLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBaudLabel.Location = new System.Drawing.Point(492, 440);
            this.newBaudLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.newBaudLabel.Name = "newBaudLabel";
            this.newBaudLabel.Size = new System.Drawing.Size(16, 18);
            this.newBaudLabel.TabIndex = 54;
            this.newBaudLabel.Text = "0";
            // 
            // ProbeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 579);
            this.Controls.Add(this.newBaudLabel);
            this.Controls.Add(this.newAddrLabel);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.baudLabel);
            this.Controls.Add(this.addrLabel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.newAddrUpDown);
            this.Controls.Add(this.ConfirmLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.UpdateLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TestLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProbeForm";
            this.Text = "Soil Probe Configuration";
            this.Load += new System.EventHandler(this.ProbeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newAddrUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.Label openLabel;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.IO.Ports.SerialPort rs485Port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel TestLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel UpdateLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel ConfirmLabel;
        private System.Windows.Forms.NumericUpDown newAddrUpDown;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label addrLabel;
        private System.Windows.Forms.Label baudLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label newAddrLabel;
        private System.Windows.Forms.Label newBaudLabel;
        }
    }


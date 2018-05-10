namespace SerialPortTerminal
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxSerial = new System.Windows.Forms.GroupBox();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxSerialPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSender = new System.Windows.Forms.TextBox();
            this.textBoxReceiver = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelSerialPortName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSerialPortStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxCloseWhenBlur = new System.Windows.Forms.CheckBox();
            this.radioButtonClose = new System.Windows.Forms.RadioButton();
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.checkBoxAutoEnter = new System.Windows.Forms.CheckBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxclear = new System.Windows.Forms.Button();
            this.groupBoxSerial.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // groupBoxSerial
            // 
            this.groupBoxSerial.Controls.Add(this.comboBoxStopBits);
            this.groupBoxSerial.Controls.Add(this.comboBoxParity);
            this.groupBoxSerial.Controls.Add(this.label5);
            this.groupBoxSerial.Controls.Add(this.label4);
            this.groupBoxSerial.Controls.Add(this.comboBoxDataBits);
            this.groupBoxSerial.Controls.Add(this.label3);
            this.groupBoxSerial.Controls.Add(this.comboBoxBaudRate);
            this.groupBoxSerial.Controls.Add(this.label2);
            this.groupBoxSerial.Controls.Add(this.comboBoxSerialPort);
            this.groupBoxSerial.Controls.Add(this.label1);
            this.groupBoxSerial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxSerial.Location = new System.Drawing.Point(13, 16);
            this.groupBoxSerial.Name = "groupBoxSerial";
            this.groupBoxSerial.Size = new System.Drawing.Size(290, 184);
            this.groupBoxSerial.TabIndex = 0;
            this.groupBoxSerial.TabStop = false;
            this.groupBoxSerial.Text = "Settings";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "None",
            "1",
            "1.5",
            "2"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(64, 151);
            this.comboBoxStopBits.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(207, 24);
            this.comboBoxStopBits.TabIndex = 7;
            this.comboBoxStopBits.SelectedIndexChanged += new System.EventHandler(this.comboBoxStopBits_SelectedIndexChanged);
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark",
            "Space"});
            this.comboBoxParity.Location = new System.Drawing.Point(64, 120);
            this.comboBoxParity.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(207, 24);
            this.comboBoxParity.TabIndex = 7;
            this.comboBoxParity.SelectedIndexChanged += new System.EventHandler(this.comboBoxParity_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stopbits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Parity";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(64, 88);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(207, 24);
            this.comboBoxDataBits.TabIndex = 3;
            this.comboBoxDataBits.Text = "8";
            this.comboBoxDataBits.SelectedIndexChanged += new System.EventHandler(this.comboBoxDataBits_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Databits";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(64, 56);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(207, 24);
            this.comboBoxBaudRate.TabIndex = 3;
            this.comboBoxBaudRate.Text = "9600";
            this.comboBoxBaudRate.SelectedIndexChanged += new System.EventHandler(this.comboBoxBaudRate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Speed";
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSerialPort.FormattingEnabled = true;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(64, 24);
            this.comboBoxSerialPort.MaxDropDownItems = 50;
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.Size = new System.Drawing.Size(207, 24);
            this.comboBoxSerialPort.TabIndex = 1;
            this.comboBoxSerialPort.SelectedIndexChanged += new System.EventHandler(this.comboBoxSerialPort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // textBoxSender
            // 
            this.textBoxSender.Location = new System.Drawing.Point(16, 316);
            this.textBoxSender.Multiline = true;
            this.textBoxSender.Name = "textBoxSender";
            this.textBoxSender.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSender.Size = new System.Drawing.Size(266, 53);
            this.textBoxSender.TabIndex = 2;
            // 
            // textBoxReceiver
            // 
            this.textBoxReceiver.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxReceiver.CausesValidation = false;
            this.textBoxReceiver.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBoxReceiver.Location = new System.Drawing.Point(311, 16);
            this.textBoxReceiver.Multiline = true;
            this.textBoxReceiver.Name = "textBoxReceiver";
            this.textBoxReceiver.ReadOnly = true;
            this.textBoxReceiver.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxReceiver.Size = new System.Drawing.Size(385, 346);
            this.textBoxReceiver.TabIndex = 1;
            this.textBoxReceiver.TextChanged += new System.EventHandler(this.textBoxReceiver_TextChanged);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelSerialPortName,
            this.toolStripStatusLabelSerialPortStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 412);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(709, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabelSerialPortName
            // 
            this.toolStripStatusLabelSerialPortName.ForeColor = System.Drawing.Color.Blue;
            this.toolStripStatusLabelSerialPortName.Name = "toolStripStatusLabelSerialPortName";
            this.toolStripStatusLabelSerialPortName.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabelSerialPortName.Text = "No COM selected";
            // 
            // toolStripStatusLabelSerialPortStatus
            // 
            this.toolStripStatusLabelSerialPortStatus.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelSerialPortStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolStripStatusLabelSerialPortStatus.Name = "toolStripStatusLabelSerialPortStatus";
            this.toolStripStatusLabelSerialPortStatus.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabelSerialPortStatus.Text = "CLOSED";
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(16, 376);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(56, 23);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxCloseWhenBlur);
            this.groupBox1.Controls.Add(this.radioButtonClose);
            this.groupBox1.Controls.Add(this.radioButtonOpen);
            this.groupBox1.Location = new System.Drawing.Point(16, 218);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(182, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // checkBoxCloseWhenBlur
            // 
            this.checkBoxCloseWhenBlur.AutoSize = true;
            this.checkBoxCloseWhenBlur.Location = new System.Drawing.Point(8, 60);
            this.checkBoxCloseWhenBlur.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCloseWhenBlur.Name = "checkBoxCloseWhenBlur";
            this.checkBoxCloseWhenBlur.Size = new System.Drawing.Size(177, 20);
            this.checkBoxCloseWhenBlur.TabIndex = 1;
            this.checkBoxCloseWhenBlur.Text = "当窗口失去焦点时关闭";
            this.checkBoxCloseWhenBlur.UseVisualStyleBackColor = true;
            this.checkBoxCloseWhenBlur.CheckedChanged += new System.EventHandler(this.checkBoxCloseWhenBlur_CheckedChanged);
            // 
            // radioButtonClose
            // 
            this.radioButtonClose.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonClose.AutoSize = true;
            this.radioButtonClose.Checked = true;
            this.radioButtonClose.Location = new System.Drawing.Point(64, 23);
            this.radioButtonClose.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonClose.Name = "radioButtonClose";
            this.radioButtonClose.Size = new System.Drawing.Size(34, 26);
            this.radioButtonClose.TabIndex = 0;
            this.radioButtonClose.TabStop = true;
            this.radioButtonClose.Text = "Off";
            this.radioButtonClose.UseVisualStyleBackColor = true;
            this.radioButtonClose.CheckedChanged += new System.EventHandler(this.radioButtonClose_CheckedChanged);
            // 
            // radioButtonOpen
            // 
            this.radioButtonOpen.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonOpen.AutoSize = true;
            this.radioButtonOpen.Location = new System.Drawing.Point(8, 23);
            this.radioButtonOpen.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(35, 26);
            this.radioButtonOpen.TabIndex = 0;
            this.radioButtonOpen.Text = "On";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            this.radioButtonOpen.CheckedChanged += new System.EventHandler(this.radioButtonOpen_CheckedChanged);
            // 
            // checkBoxAutoEnter
            // 
            this.checkBoxAutoEnter.AutoSize = true;
            this.checkBoxAutoEnter.Location = new System.Drawing.Point(224, 376);
            this.checkBoxAutoEnter.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAutoEnter.Name = "checkBoxAutoEnter";
            this.checkBoxAutoEnter.Size = new System.Drawing.Size(57, 20);
            this.checkBoxAutoEnter.TabIndex = 6;
            this.checkBoxAutoEnter.Text = "Clear";
            this.checkBoxAutoEnter.UseVisualStyleBackColor = true;
            this.checkBoxAutoEnter.CheckedChanged += new System.EventHandler(this.checkBoxAutoEnter_CheckedChanged);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(216, 203);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(67, 23);
            this.buttonClear.TabIndex = 7;
            this.buttonClear.Text = "Refresh";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxclear
            // 
            this.textBoxclear.Location = new System.Drawing.Point(624, 376);
            this.textBoxclear.Name = "textBoxclear";
            this.textBoxclear.Size = new System.Drawing.Size(75, 22);
            this.textBoxclear.TabIndex = 8;
            this.textBoxclear.Text = "Clear";
            this.textBoxclear.UseVisualStyleBackColor = true;
            this.textBoxclear.Click += new System.EventHandler(this.textBoxclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 434);
            this.Controls.Add(this.textBoxclear);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.checkBoxAutoEnter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.textBoxSender);
            this.Controls.Add(this.textBoxReceiver);
            this.Controls.Add(this.groupBoxSerial);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Port Terminal";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSerial.ResumeLayout(false);
            this.groupBoxSerial.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.GroupBox groupBoxSerial;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxSerialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSender;
        private System.Windows.Forms.TextBox textBoxReceiver;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSerialPortStatus;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonClose;
        private System.Windows.Forms.RadioButton radioButtonOpen;
        private System.Windows.Forms.CheckBox checkBoxCloseWhenBlur;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSerialPortName;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxAutoEnter;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button textBoxclear;
    }
}


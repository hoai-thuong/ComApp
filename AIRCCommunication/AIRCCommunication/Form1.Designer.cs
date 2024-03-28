namespace AIRCCommunication
{
    partial class AIRCCommunication
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
            this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxDataRead = new System.Windows.Forms.TextBox();
            this.textBoxDataSend = new System.Windows.Forms.TextBox();
            this.textBox_TimeNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NextTime = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ClearDisplay = new System.Windows.Forms.Button();
            this.Disconnect = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.SendData = new System.Windows.Forms.Button();
            this.textBox_Link = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxParityBit = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBit = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBit = new System.Windows.Forms.ComboBox();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.comboBox_Port = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ClearDisplayClient = new System.Windows.Forms.Button();
            this.textBox_ClientDataRead = new System.Windows.Forms.TextBox();
            this.textBox_ClientDataSend = new System.Windows.Forms.TextBox();
            this.textBox_ClientLength = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_ClientNumber = new System.Windows.Forms.TextBox();
            this.button_ClientNewFile = new System.Windows.Forms.Button();
            this.button_ClientClose = new System.Windows.Forms.Button();
            this.button_ClientSend = new System.Windows.Forms.Button();
            this.button_ClientConnect = new System.Windows.Forms.Button();
            this.textBox_ClientLink = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_ClientPort = new System.Windows.Forms.TextBox();
            this.textBox_ClientTime = new System.Windows.Forms.TextBox();
            this.textBox_ClientIP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ClearDisplayServer = new System.Windows.Forms.Button();
            this.textBox_ServerLink = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_ServerDay = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox3_ServerLength = new System.Windows.Forms.TextBox();
            this.textBox_ServerNumber = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button_ServerNewFile = new System.Windows.Forms.Button();
            this.button_ServerSend = new System.Windows.Forms.Button();
            this.button_ServerClose = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_ServerSendData = new System.Windows.Forms.TextBox();
            this.textBox_ServerReceiveData = new System.Windows.Forms.TextBox();
            this.textBox_ServerPort = new System.Windows.Forms.TextBox();
            this.button_ServerListener = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SerialPort1
            // 
            this.SerialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 428);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxDataRead);
            this.tabPage1.Controls.Add(this.textBoxDataSend);
            this.tabPage1.Controls.Add(this.textBox_TimeNumber);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBoxDate);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(761, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBoxDataRead
            // 
            this.textBoxDataRead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDataRead.Location = new System.Drawing.Point(359, 184);
            this.textBoxDataRead.Multiline = true;
            this.textBoxDataRead.Name = "textBoxDataRead";
            this.textBoxDataRead.Size = new System.Drawing.Size(397, 217);
            this.textBoxDataRead.TabIndex = 19;
            // 
            // textBoxDataSend
            // 
            this.textBoxDataSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDataSend.Location = new System.Drawing.Point(359, 51);
            this.textBoxDataSend.Multiline = true;
            this.textBoxDataSend.Name = "textBoxDataSend";
            this.textBoxDataSend.Size = new System.Drawing.Size(397, 106);
            this.textBoxDataSend.TabIndex = 18;
            // 
            // textBox_TimeNumber
            // 
            this.textBox_TimeNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_TimeNumber.Location = new System.Drawing.Point(632, 18);
            this.textBox_TimeNumber.Name = "textBox_TimeNumber";
            this.textBox_TimeNumber.Size = new System.Drawing.Size(122, 20);
            this.textBox_TimeNumber.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(565, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Time Number";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDate.Location = new System.Drawing.Point(437, 16);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(122, 20);
            this.textBoxDate.TabIndex = 15;
            this.textBoxDate.Text = "28_03_24";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(342, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date(dd_mm_yy):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NextTime);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.SendData);
            this.groupBox1.Controls.Add(this.textBox_Link);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxParityBit);
            this.groupBox1.Controls.Add(this.comboBoxStopBit);
            this.groupBox1.Controls.Add(this.comboBoxDataBit);
            this.groupBox1.Controls.Add(this.comboBoxBaudRate);
            this.groupBox1.Controls.Add(this.comboBox_Port);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 386);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Com Port Control";
            // 
            // NextTime
            // 
            this.NextTime.Location = new System.Drawing.Point(225, 308);
            this.NextTime.Name = "NextTime";
            this.NextTime.Size = new System.Drawing.Size(78, 42);
            this.NextTime.TabIndex = 16;
            this.NextTime.Text = "Next Time";
            this.NextTime.UseVisualStyleBackColor = true;
            this.NextTime.Click += new System.EventHandler(this.NextTime_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.ClearDisplay);
            this.groupBox2.Controls.Add(this.Disconnect);
            this.groupBox2.Controls.Add(this.Open);
            this.groupBox2.Location = new System.Drawing.Point(21, 240);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 110);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(43, 49);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(112, 13);
            this.progressBar1.TabIndex = 3;
            // 
            // ClearDisplay
            // 
            this.ClearDisplay.Location = new System.Drawing.Point(43, 68);
            this.ClearDisplay.Name = "ClearDisplay";
            this.ClearDisplay.Size = new System.Drawing.Size(112, 28);
            this.ClearDisplay.TabIndex = 2;
            this.ClearDisplay.Text = "Clear Display";
            this.ClearDisplay.UseVisualStyleBackColor = true;
            this.ClearDisplay.Click += new System.EventHandler(this.ClearDisplay_Click);
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(96, 20);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Disconnect.TabIndex = 1;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // Open
            // 
            this.Open.Location = new System.Drawing.Point(15, 20);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(75, 23);
            this.Open.TabIndex = 0;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = true;
            this.Open.Click += new System.EventHandler(this.Open_Click_1);
            // 
            // SendData
            // 
            this.SendData.Location = new System.Drawing.Point(225, 250);
            this.SendData.Name = "SendData";
            this.SendData.Size = new System.Drawing.Size(78, 42);
            this.SendData.TabIndex = 15;
            this.SendData.Text = "Send Data";
            this.SendData.UseVisualStyleBackColor = true;
            this.SendData.Click += new System.EventHandler(this.SendData_Click_1);
            // 
            // textBox_Link
            // 
            this.textBox_Link.Location = new System.Drawing.Point(117, 200);
            this.textBox_Link.Name = "textBox_Link";
            this.textBox_Link.Size = new System.Drawing.Size(115, 20);
            this.textBox_Link.TabIndex = 1;
            this.textBox_Link.Text = "C:\\testdata\\";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Link Folder";
            // 
            // comboBoxParityBit
            // 
            this.comboBoxParityBit.FormattingEnabled = true;
            this.comboBoxParityBit.Items.AddRange(new object[] {
            "None",
            "Even",
            "Odd",
            "Mark"});
            this.comboBoxParityBit.Location = new System.Drawing.Point(177, 139);
            this.comboBoxParityBit.Name = "comboBoxParityBit";
            this.comboBoxParityBit.Size = new System.Drawing.Size(110, 21);
            this.comboBoxParityBit.TabIndex = 9;
            this.comboBoxParityBit.Text = "None";
            // 
            // comboBoxStopBit
            // 
            this.comboBoxStopBit.FormattingEnabled = true;
            this.comboBoxStopBit.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBoxStopBit.Location = new System.Drawing.Point(45, 139);
            this.comboBoxStopBit.Name = "comboBoxStopBit";
            this.comboBoxStopBit.Size = new System.Drawing.Size(99, 21);
            this.comboBoxStopBit.TabIndex = 8;
            this.comboBoxStopBit.Text = "One";
            // 
            // comboBoxDataBit
            // 
            this.comboBoxDataBit.FormattingEnabled = true;
            this.comboBoxDataBit.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.comboBoxDataBit.Location = new System.Drawing.Point(177, 92);
            this.comboBoxDataBit.Name = "comboBoxDataBit";
            this.comboBoxDataBit.Size = new System.Drawing.Size(110, 21);
            this.comboBoxDataBit.TabIndex = 7;
            this.comboBoxDataBit.Text = "8";
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Items.AddRange(new object[] {
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200"});
            this.comboBoxBaudRate.Location = new System.Drawing.Point(45, 92);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(99, 21);
            this.comboBoxBaudRate.TabIndex = 6;
            this.comboBoxBaudRate.Text = "9600";
            // 
            // comboBox_Port
            // 
            this.comboBox_Port.FormattingEnabled = true;
            this.comboBox_Port.Location = new System.Drawing.Point(111, 44);
            this.comboBox_Port.Name = "comboBox_Port";
            this.comboBox_Port.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Port.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Parity Bit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Stop Bit";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Bit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baud Rate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM PORT";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ClearDisplayClient);
            this.tabPage2.Controls.Add(this.textBox_ClientDataRead);
            this.tabPage2.Controls.Add(this.textBox_ClientDataSend);
            this.tabPage2.Controls.Add(this.textBox_ClientLength);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.textBox_ClientNumber);
            this.tabPage2.Controls.Add(this.button_ClientNewFile);
            this.tabPage2.Controls.Add(this.button_ClientClose);
            this.tabPage2.Controls.Add(this.button_ClientSend);
            this.tabPage2.Controls.Add(this.button_ClientConnect);
            this.tabPage2.Controls.Add(this.textBox_ClientLink);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.textBox_ClientPort);
            this.tabPage2.Controls.Add(this.textBox_ClientTime);
            this.tabPage2.Controls.Add(this.textBox_ClientIP);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(761, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "TCPClient";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ClearDisplayClient
            // 
            this.ClearDisplayClient.Location = new System.Drawing.Point(283, 245);
            this.ClearDisplayClient.Name = "ClearDisplayClient";
            this.ClearDisplayClient.Size = new System.Drawing.Size(78, 66);
            this.ClearDisplayClient.TabIndex = 46;
            this.ClearDisplayClient.Text = "Clear Display";
            this.ClearDisplayClient.UseVisualStyleBackColor = true;
            this.ClearDisplayClient.Click += new System.EventHandler(this.ClearDisplayClient_Click);
            // 
            // textBox_ClientDataRead
            // 
            this.textBox_ClientDataRead.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ClientDataRead.Location = new System.Drawing.Point(404, 106);
            this.textBox_ClientDataRead.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ClientDataRead.Multiline = true;
            this.textBox_ClientDataRead.Name = "textBox_ClientDataRead";
            this.textBox_ClientDataRead.Size = new System.Drawing.Size(296, 256);
            this.textBox_ClientDataRead.TabIndex = 45;
            // 
            // textBox_ClientDataSend
            // 
            this.textBox_ClientDataSend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ClientDataSend.Location = new System.Drawing.Point(404, 23);
            this.textBox_ClientDataSend.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ClientDataSend.Multiline = true;
            this.textBox_ClientDataSend.Name = "textBox_ClientDataSend";
            this.textBox_ClientDataSend.Size = new System.Drawing.Size(296, 73);
            this.textBox_ClientDataSend.TabIndex = 44;
            // 
            // textBox_ClientLength
            // 
            this.textBox_ClientLength.Location = new System.Drawing.Point(187, 236);
            this.textBox_ClientLength.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ClientLength.Name = "textBox_ClientLength";
            this.textBox_ClientLength.Size = new System.Drawing.Size(62, 20);
            this.textBox_ClientLength.TabIndex = 43;
            this.textBox_ClientLength.Text = "0";
            this.textBox_ClientLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(184, 209);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Length data";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(115, 209);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "Number";
            // 
            // textBox_ClientNumber
            // 
            this.textBox_ClientNumber.Location = new System.Drawing.Point(106, 236);
            this.textBox_ClientNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ClientNumber.Name = "textBox_ClientNumber";
            this.textBox_ClientNumber.Size = new System.Drawing.Size(53, 20);
            this.textBox_ClientNumber.TabIndex = 40;
            this.textBox_ClientNumber.Text = "0";
            this.textBox_ClientNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_ClientNewFile
            // 
            this.button_ClientNewFile.Location = new System.Drawing.Point(283, 123);
            this.button_ClientNewFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_ClientNewFile.Name = "button_ClientNewFile";
            this.button_ClientNewFile.Size = new System.Drawing.Size(78, 41);
            this.button_ClientNewFile.TabIndex = 39;
            this.button_ClientNewFile.Text = "New File";
            this.button_ClientNewFile.UseVisualStyleBackColor = true;
            this.button_ClientNewFile.Click += new System.EventHandler(this.button_ClientNewFile_Click);
            // 
            // button_ClientClose
            // 
            this.button_ClientClose.Location = new System.Drawing.Point(129, 335);
            this.button_ClientClose.Margin = new System.Windows.Forms.Padding(2);
            this.button_ClientClose.Name = "button_ClientClose";
            this.button_ClientClose.Size = new System.Drawing.Size(104, 32);
            this.button_ClientClose.TabIndex = 38;
            this.button_ClientClose.Text = "Close";
            this.button_ClientClose.UseVisualStyleBackColor = true;
            this.button_ClientClose.Click += new System.EventHandler(this.button_ClientClose_Click);
            // 
            // button_ClientSend
            // 
            this.button_ClientSend.Location = new System.Drawing.Point(283, 26);
            this.button_ClientSend.Margin = new System.Windows.Forms.Padding(2);
            this.button_ClientSend.Name = "button_ClientSend";
            this.button_ClientSend.Size = new System.Drawing.Size(78, 40);
            this.button_ClientSend.TabIndex = 37;
            this.button_ClientSend.Text = "Send";
            this.button_ClientSend.UseVisualStyleBackColor = true;
            this.button_ClientSend.Click += new System.EventHandler(this.button_ClientSend_Click);
            // 
            // button_ClientConnect
            // 
            this.button_ClientConnect.Location = new System.Drawing.Point(129, 279);
            this.button_ClientConnect.Margin = new System.Windows.Forms.Padding(2);
            this.button_ClientConnect.Name = "button_ClientConnect";
            this.button_ClientConnect.Size = new System.Drawing.Size(104, 32);
            this.button_ClientConnect.TabIndex = 36;
            this.button_ClientConnect.Text = "Connect";
            this.button_ClientConnect.UseVisualStyleBackColor = true;
            this.button_ClientConnect.Click += new System.EventHandler(this.button_ClientConnect_Click);
            // 
            // textBox_ClientLink
            // 
            this.textBox_ClientLink.ForeColor = System.Drawing.SystemColors.MenuText;
            this.textBox_ClientLink.Location = new System.Drawing.Point(138, 144);
            this.textBox_ClientLink.Name = "textBox_ClientLink";
            this.textBox_ClientLink.Size = new System.Drawing.Size(100, 20);
            this.textBox_ClientLink.TabIndex = 35;
            this.textBox_ClientLink.Text = "C:\\testdata\\";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(61, 147);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Link Folder ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(150, 109);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "(dd_mm_yy)";
            // 
            // textBox_ClientPort
            // 
            this.textBox_ClientPort.Location = new System.Drawing.Point(138, 53);
            this.textBox_ClientPort.Name = "textBox_ClientPort";
            this.textBox_ClientPort.Size = new System.Drawing.Size(100, 20);
            this.textBox_ClientPort.TabIndex = 32;
            this.textBox_ClientPort.Text = "23";
            this.textBox_ClientPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_ClientTime
            // 
            this.textBox_ClientTime.Location = new System.Drawing.Point(138, 86);
            this.textBox_ClientTime.Name = "textBox_ClientTime";
            this.textBox_ClientTime.Size = new System.Drawing.Size(100, 20);
            this.textBox_ClientTime.TabIndex = 31;
            this.textBox_ClientTime.Text = "26_3_2024";
            this.textBox_ClientTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_ClientIP
            // 
            this.textBox_ClientIP.Location = new System.Drawing.Point(138, 23);
            this.textBox_ClientIP.Name = "textBox_ClientIP";
            this.textBox_ClientIP.Size = new System.Drawing.Size(100, 20);
            this.textBox_ClientIP.TabIndex = 30;
            this.textBox_ClientIP.Text = "127.0.0.1";
            this.textBox_ClientIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(84, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Day ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(84, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Port ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(84, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "IP ";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ClearDisplayServer);
            this.tabPage3.Controls.Add(this.textBox_ServerLink);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.textBox_ServerDay);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.textBox3_ServerLength);
            this.tabPage3.Controls.Add(this.textBox_ServerNumber);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.button_ServerNewFile);
            this.tabPage3.Controls.Add(this.button_ServerSend);
            this.tabPage3.Controls.Add(this.button_ServerClose);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.textBox_ServerSendData);
            this.tabPage3.Controls.Add(this.textBox_ServerReceiveData);
            this.tabPage3.Controls.Add(this.textBox_ServerPort);
            this.tabPage3.Controls.Add(this.button_ServerListener);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(761, 402);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "TCPServer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ClearDisplayServer
            // 
            this.ClearDisplayServer.Location = new System.Drawing.Point(274, 253);
            this.ClearDisplayServer.Name = "ClearDisplayServer";
            this.ClearDisplayServer.Size = new System.Drawing.Size(78, 66);
            this.ClearDisplayServer.TabIndex = 51;
            this.ClearDisplayServer.Text = "Clear Display";
            this.ClearDisplayServer.UseVisualStyleBackColor = true;
            this.ClearDisplayServer.Click += new System.EventHandler(this.ClearDisplayServer_Click);
            // 
            // textBox_ServerLink
            // 
            this.textBox_ServerLink.Location = new System.Drawing.Point(122, 114);
            this.textBox_ServerLink.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ServerLink.Name = "textBox_ServerLink";
            this.textBox_ServerLink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_ServerLink.Size = new System.Drawing.Size(116, 20);
            this.textBox_ServerLink.TabIndex = 50;
            this.textBox_ServerLink.Text = "C:\\testdata\\";
            this.textBox_ServerLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(44, 116);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 15);
            this.label16.TabIndex = 49;
            this.label16.Text = "Link Folder";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(149, 82);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 48;
            this.label17.Text = "(dd_mm_yy)";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(67, 63);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(28, 15);
            this.label18.TabIndex = 47;
            this.label18.Text = "Day";
            // 
            // textBox_ServerDay
            // 
            this.textBox_ServerDay.Location = new System.Drawing.Point(122, 59);
            this.textBox_ServerDay.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ServerDay.Name = "textBox_ServerDay";
            this.textBox_ServerDay.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_ServerDay.Size = new System.Drawing.Size(116, 20);
            this.textBox_ServerDay.TabIndex = 46;
            this.textBox_ServerDay.Text = "26_03_2024";
            this.textBox_ServerDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(168, 161);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 15);
            this.label19.TabIndex = 45;
            this.label19.Text = "Length data";
            // 
            // textBox3_ServerLength
            // 
            this.textBox3_ServerLength.Location = new System.Drawing.Point(169, 188);
            this.textBox3_ServerLength.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3_ServerLength.Name = "textBox3_ServerLength";
            this.textBox3_ServerLength.Size = new System.Drawing.Size(59, 20);
            this.textBox3_ServerLength.TabIndex = 44;
            this.textBox3_ServerLength.Text = "0";
            this.textBox3_ServerLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_ServerNumber
            // 
            this.textBox_ServerNumber.Location = new System.Drawing.Point(67, 188);
            this.textBox_ServerNumber.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ServerNumber.Name = "textBox_ServerNumber";
            this.textBox_ServerNumber.Size = new System.Drawing.Size(61, 20);
            this.textBox_ServerNumber.TabIndex = 43;
            this.textBox_ServerNumber.Text = "0";
            this.textBox_ServerNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(67, 161);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 15);
            this.label20.TabIndex = 42;
            this.label20.Text = "Number";
            // 
            // button_ServerNewFile
            // 
            this.button_ServerNewFile.Location = new System.Drawing.Point(274, 128);
            this.button_ServerNewFile.Margin = new System.Windows.Forms.Padding(2);
            this.button_ServerNewFile.Name = "button_ServerNewFile";
            this.button_ServerNewFile.Size = new System.Drawing.Size(72, 64);
            this.button_ServerNewFile.TabIndex = 41;
            this.button_ServerNewFile.Text = "New File";
            this.button_ServerNewFile.UseVisualStyleBackColor = true;
            this.button_ServerNewFile.Click += new System.EventHandler(this.button_ServerNewFile_Click);
            // 
            // button_ServerSend
            // 
            this.button_ServerSend.Location = new System.Drawing.Point(274, 17);
            this.button_ServerSend.Margin = new System.Windows.Forms.Padding(2);
            this.button_ServerSend.Name = "button_ServerSend";
            this.button_ServerSend.Size = new System.Drawing.Size(72, 63);
            this.button_ServerSend.TabIndex = 40;
            this.button_ServerSend.Text = "Send";
            this.button_ServerSend.UseVisualStyleBackColor = true;
            this.button_ServerSend.Click += new System.EventHandler(this.button_ServerSend_Click);
            // 
            // button_ServerClose
            // 
            this.button_ServerClose.Location = new System.Drawing.Point(106, 302);
            this.button_ServerClose.Margin = new System.Windows.Forms.Padding(2);
            this.button_ServerClose.Name = "button_ServerClose";
            this.button_ServerClose.Size = new System.Drawing.Size(103, 28);
            this.button_ServerClose.TabIndex = 39;
            this.button_ServerClose.Text = "Close";
            this.button_ServerClose.UseVisualStyleBackColor = true;
            this.button_ServerClose.Click += new System.EventHandler(this.button_ServerClose_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(67, 21);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(32, 15);
            this.label21.TabIndex = 38;
            this.label21.Text = " Port";
            // 
            // textBox_ServerSendData
            // 
            this.textBox_ServerSendData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ServerSendData.Location = new System.Drawing.Point(366, 12);
            this.textBox_ServerSendData.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ServerSendData.Multiline = true;
            this.textBox_ServerSendData.Name = "textBox_ServerSendData";
            this.textBox_ServerSendData.Size = new System.Drawing.Size(351, 98);
            this.textBox_ServerSendData.TabIndex = 37;
            // 
            // textBox_ServerReceiveData
            // 
            this.textBox_ServerReceiveData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ServerReceiveData.Location = new System.Drawing.Point(366, 128);
            this.textBox_ServerReceiveData.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ServerReceiveData.Multiline = true;
            this.textBox_ServerReceiveData.Name = "textBox_ServerReceiveData";
            this.textBox_ServerReceiveData.Size = new System.Drawing.Size(351, 232);
            this.textBox_ServerReceiveData.TabIndex = 36;
            // 
            // textBox_ServerPort
            // 
            this.textBox_ServerPort.Location = new System.Drawing.Point(122, 17);
            this.textBox_ServerPort.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_ServerPort.Name = "textBox_ServerPort";
            this.textBox_ServerPort.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_ServerPort.Size = new System.Drawing.Size(116, 20);
            this.textBox_ServerPort.TabIndex = 35;
            this.textBox_ServerPort.Text = "23";
            this.textBox_ServerPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_ServerListener
            // 
            this.button_ServerListener.Location = new System.Drawing.Point(106, 242);
            this.button_ServerListener.Margin = new System.Windows.Forms.Padding(2);
            this.button_ServerListener.Name = "button_ServerListener";
            this.button_ServerListener.Size = new System.Drawing.Size(103, 28);
            this.button_ServerListener.TabIndex = 34;
            this.button_ServerListener.Text = "Listener";
            this.button_ServerListener.UseVisualStyleBackColor = true;
            this.button_ServerListener.Click += new System.EventHandler(this.button_ServerListener_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(39, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(340, 388);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // AIRCCommunication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 428);
            this.Controls.Add(this.tabControl1);
            this.Name = "AIRCCommunication";
            this.Text = "AIRC";
            this.Load += new System.EventHandler(this.AIRCCommunication_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort SerialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBoxDataRead;
        private System.Windows.Forms.TextBox textBoxDataSend;
        private System.Windows.Forms.TextBox textBox_TimeNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NextTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button ClearDisplay;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button SendData;
        private System.Windows.Forms.TextBox textBox_Link;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxParityBit;
        private System.Windows.Forms.ComboBox comboBoxStopBit;
        private System.Windows.Forms.ComboBox comboBoxDataBit;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.ComboBox comboBox_Port;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ClientDataRead;
        private System.Windows.Forms.TextBox textBox_ClientDataSend;
        private System.Windows.Forms.TextBox textBox_ClientLength;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_ClientNumber;
        private System.Windows.Forms.Button button_ClientNewFile;
        private System.Windows.Forms.Button button_ClientClose;
        private System.Windows.Forms.Button button_ClientSend;
        private System.Windows.Forms.Button button_ClientConnect;
        private System.Windows.Forms.TextBox textBox_ClientLink;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_ClientPort;
        private System.Windows.Forms.TextBox textBox_ClientTime;
        private System.Windows.Forms.TextBox textBox_ClientIP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ClearDisplayClient;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox_ServerLink;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_ServerDay;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox3_ServerLength;
        private System.Windows.Forms.TextBox textBox_ServerNumber;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button_ServerNewFile;
        private System.Windows.Forms.Button button_ServerSend;
        private System.Windows.Forms.Button button_ServerClose;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_ServerSendData;
        private System.Windows.Forms.TextBox textBox_ServerReceiveData;
        private System.Windows.Forms.TextBox textBox_ServerPort;
        private System.Windows.Forms.Button button_ServerListener;
        private System.Windows.Forms.Button ClearDisplayServer;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}



namespace SerialCom_Console
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hexInput = new System.Windows.Forms.MaskedTextBox();
            this.hexInputClear = new System.Windows.Forms.Button();
            this.hexSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.handshakeRts = new System.Windows.Forms.RadioButton();
            this.handshakeXon = new System.Windows.Forms.RadioButton();
            this.handshakeNone = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.stopbit2 = new System.Windows.Forms.RadioButton();
            this.stopbit15 = new System.Windows.Forms.RadioButton();
            this.stopbit1 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.parityOdd = new System.Windows.Forms.RadioButton();
            this.parityEven = new System.Windows.Forms.RadioButton();
            this.parityNone = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.databit7 = new System.Windows.Forms.RadioButton();
            this.databit8 = new System.Windows.Forms.RadioButton();
            this.serialDisconnect = new System.Windows.Forms.Button();
            this.serialStatus = new System.Windows.Forms.Label();
            this.serialBaudrate = new System.Windows.Forms.ComboBox();
            this.serialConnect = new System.Windows.Forms.Button();
            this.serialPortname = new System.Windows.Forms.ComboBox();
            this.rcvHex = new System.Windows.Forms.TextBox();
            this.rcvHexClear = new System.Windows.Forms.Button();
            this.rcvHexCopy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showHex = new System.Windows.Forms.RadioButton();
            this.showAscii = new System.Windows.Forms.RadioButton();
            this.asciiSend = new System.Windows.Forms.Button();
            this.asciiInputClear = new System.Windows.Forms.Button();
            this.asciiInput = new System.Windows.Forms.TextBox();
            this.asciiSend2 = new System.Windows.Forms.Button();
            this.asciiInputClear2 = new System.Windows.Forms.Button();
            this.asciiInput2 = new System.Windows.Forms.TextBox();
            this.asciiSend3 = new System.Windows.Forms.Button();
            this.asciiInputClear3 = new System.Windows.Forms.Button();
            this.asciiInput3 = new System.Windows.Forms.TextBox();
            this.inputControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hexInput3 = new System.Windows.Forms.MaskedTextBox();
            this.hexSend3 = new System.Windows.Forms.Button();
            this.hexInputClear3 = new System.Windows.Forms.Button();
            this.hexInput2 = new System.Windows.Forms.MaskedTextBox();
            this.hexSend2 = new System.Windows.Forms.Button();
            this.hexInputClear2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.inputControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // hexInput
            // 
            this.hexInput.Location = new System.Drawing.Point(3, 3);
            this.hexInput.Mask = "CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC " +
    "CC CC CC CC CC";
            this.hexInput.Name = "hexInput";
            this.hexInput.Size = new System.Drawing.Size(424, 23);
            this.hexInput.TabIndex = 1;
            // 
            // hexInputClear
            // 
            this.hexInputClear.Location = new System.Drawing.Point(514, 3);
            this.hexInputClear.Name = "hexInputClear";
            this.hexInputClear.Size = new System.Drawing.Size(75, 23);
            this.hexInputClear.TabIndex = 2;
            this.hexInputClear.Text = "Clear";
            this.hexInputClear.UseVisualStyleBackColor = true;
            this.hexInputClear.Click += new System.EventHandler(this.hexInputClear_Click);
            // 
            // hexSend
            // 
            this.hexSend.Location = new System.Drawing.Point(433, 3);
            this.hexSend.Name = "hexSend";
            this.hexSend.Size = new System.Drawing.Size(75, 23);
            this.hexSend.TabIndex = 3;
            this.hexSend.Text = "Send";
            this.hexSend.UseVisualStyleBackColor = true;
            this.hexSend.Click += new System.EventHandler(this.hexSend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.serialDisconnect);
            this.groupBox1.Controls.Add(this.serialStatus);
            this.groupBox1.Controls.Add(this.serialBaudrate);
            this.groupBox1.Controls.Add(this.serialConnect);
            this.groupBox1.Controls.Add(this.serialPortname);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(596, 133);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial port";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.handshakeRts);
            this.groupBox6.Controls.Add(this.handshakeXon);
            this.groupBox6.Controls.Add(this.handshakeNone);
            this.groupBox6.Location = new System.Drawing.Point(341, 72);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(236, 51);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Handshake";
            // 
            // handshakeRts
            // 
            this.handshakeRts.AutoSize = true;
            this.handshakeRts.Location = new System.Drawing.Point(153, 22);
            this.handshakeRts.Name = "handshakeRts";
            this.handshakeRts.Size = new System.Drawing.Size(68, 19);
            this.handshakeRts.TabIndex = 11;
            this.handshakeRts.Text = "RTS/CTS";
            this.handshakeRts.UseVisualStyleBackColor = true;
            // 
            // handshakeXon
            // 
            this.handshakeXon.AutoSize = true;
            this.handshakeXon.Location = new System.Drawing.Point(74, 22);
            this.handshakeXon.Name = "handshakeXon";
            this.handshakeXon.Size = new System.Drawing.Size(73, 19);
            this.handshakeXon.TabIndex = 10;
            this.handshakeXon.Text = "Xon/Xoff";
            this.handshakeXon.UseVisualStyleBackColor = true;
            // 
            // handshakeNone
            // 
            this.handshakeNone.AutoSize = true;
            this.handshakeNone.Checked = true;
            this.handshakeNone.Location = new System.Drawing.Point(14, 22);
            this.handshakeNone.Name = "handshakeNone";
            this.handshakeNone.Size = new System.Drawing.Size(54, 19);
            this.handshakeNone.TabIndex = 9;
            this.handshakeNone.TabStop = true;
            this.handshakeNone.Text = "None";
            this.handshakeNone.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.stopbit2);
            this.groupBox5.Controls.Add(this.stopbit15);
            this.groupBox5.Controls.Add(this.stopbit1);
            this.groupBox5.Location = new System.Drawing.Point(200, 72);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(135, 51);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "StopBits";
            // 
            // stopbit2
            // 
            this.stopbit2.AutoSize = true;
            this.stopbit2.Location = new System.Drawing.Point(97, 22);
            this.stopbit2.Name = "stopbit2";
            this.stopbit2.Size = new System.Drawing.Size(31, 19);
            this.stopbit2.TabIndex = 11;
            this.stopbit2.Text = "2";
            this.stopbit2.UseVisualStyleBackColor = true;
            // 
            // stopbit15
            // 
            this.stopbit15.AutoSize = true;
            this.stopbit15.Location = new System.Drawing.Point(51, 22);
            this.stopbit15.Name = "stopbit15";
            this.stopbit15.Size = new System.Drawing.Size(40, 19);
            this.stopbit15.TabIndex = 10;
            this.stopbit15.Text = "1.5";
            this.stopbit15.UseVisualStyleBackColor = true;
            // 
            // stopbit1
            // 
            this.stopbit1.AutoSize = true;
            this.stopbit1.Checked = true;
            this.stopbit1.Location = new System.Drawing.Point(14, 22);
            this.stopbit1.Name = "stopbit1";
            this.stopbit1.Size = new System.Drawing.Size(31, 19);
            this.stopbit1.TabIndex = 9;
            this.stopbit1.TabStop = true;
            this.stopbit1.Text = "1";
            this.stopbit1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.parityOdd);
            this.groupBox4.Controls.Add(this.parityEven);
            this.groupBox4.Controls.Add(this.parityNone);
            this.groupBox4.Location = new System.Drawing.Point(7, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(187, 51);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parity";
            // 
            // parityOdd
            // 
            this.parityOdd.AutoSize = true;
            this.parityOdd.Location = new System.Drawing.Point(130, 22);
            this.parityOdd.Name = "parityOdd";
            this.parityOdd.Size = new System.Drawing.Size(48, 19);
            this.parityOdd.TabIndex = 11;
            this.parityOdd.Text = "Odd";
            this.parityOdd.UseVisualStyleBackColor = true;
            // 
            // parityEven
            // 
            this.parityEven.AutoSize = true;
            this.parityEven.Location = new System.Drawing.Point(74, 22);
            this.parityEven.Name = "parityEven";
            this.parityEven.Size = new System.Drawing.Size(50, 19);
            this.parityEven.TabIndex = 10;
            this.parityEven.Text = "Even";
            this.parityEven.UseVisualStyleBackColor = true;
            // 
            // parityNone
            // 
            this.parityNone.AutoSize = true;
            this.parityNone.Checked = true;
            this.parityNone.Location = new System.Drawing.Point(14, 22);
            this.parityNone.Name = "parityNone";
            this.parityNone.Size = new System.Drawing.Size(54, 19);
            this.parityNone.TabIndex = 9;
            this.parityNone.TabStop = true;
            this.parityNone.Text = "None";
            this.parityNone.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.databit7);
            this.groupBox3.Controls.Add(this.databit8);
            this.groupBox3.Location = new System.Drawing.Point(250, 15);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(91, 51);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DataBits";
            // 
            // databit7
            // 
            this.databit7.AutoSize = true;
            this.databit7.Location = new System.Drawing.Point(51, 22);
            this.databit7.Name = "databit7";
            this.databit7.Size = new System.Drawing.Size(31, 19);
            this.databit7.TabIndex = 10;
            this.databit7.Text = "7";
            this.databit7.UseVisualStyleBackColor = true;
            // 
            // databit8
            // 
            this.databit8.AutoSize = true;
            this.databit8.Checked = true;
            this.databit8.Location = new System.Drawing.Point(14, 22);
            this.databit8.Name = "databit8";
            this.databit8.Size = new System.Drawing.Size(31, 19);
            this.databit8.TabIndex = 9;
            this.databit8.TabStop = true;
            this.databit8.Text = "8";
            this.databit8.UseVisualStyleBackColor = true;
            // 
            // serialDisconnect
            // 
            this.serialDisconnect.Location = new System.Drawing.Point(428, 33);
            this.serialDisconnect.Name = "serialDisconnect";
            this.serialDisconnect.Size = new System.Drawing.Size(75, 23);
            this.serialDisconnect.TabIndex = 7;
            this.serialDisconnect.Text = "Disconnect";
            this.serialDisconnect.UseVisualStyleBackColor = true;
            this.serialDisconnect.Click += new System.EventHandler(this.serialDisconnect_Click);
            // 
            // serialStatus
            // 
            this.serialStatus.AutoSize = true;
            this.serialStatus.ForeColor = System.Drawing.Color.Red;
            this.serialStatus.Location = new System.Drawing.Point(509, 36);
            this.serialStatus.Name = "serialStatus";
            this.serialStatus.Size = new System.Drawing.Size(79, 15);
            this.serialStatus.TabIndex = 6;
            this.serialStatus.Text = "Disconnected";
            // 
            // serialBaudrate
            // 
            this.serialBaudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialBaudrate.FormattingEnabled = true;
            this.serialBaudrate.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.serialBaudrate.Location = new System.Drawing.Point(130, 33);
            this.serialBaudrate.Name = "serialBaudrate";
            this.serialBaudrate.Size = new System.Drawing.Size(114, 23);
            this.serialBaudrate.TabIndex = 5;
            // 
            // serialConnect
            // 
            this.serialConnect.Location = new System.Drawing.Point(347, 33);
            this.serialConnect.Name = "serialConnect";
            this.serialConnect.Size = new System.Drawing.Size(75, 23);
            this.serialConnect.TabIndex = 4;
            this.serialConnect.Text = "Connect";
            this.serialConnect.UseVisualStyleBackColor = true;
            this.serialConnect.Click += new System.EventHandler(this.serialConnect_Click);
            // 
            // serialPortname
            // 
            this.serialPortname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialPortname.FormattingEnabled = true;
            this.serialPortname.Location = new System.Drawing.Point(10, 33);
            this.serialPortname.Name = "serialPortname";
            this.serialPortname.Size = new System.Drawing.Size(114, 23);
            this.serialPortname.TabIndex = 0;
            // 
            // rcvHex
            // 
            this.rcvHex.Location = new System.Drawing.Point(6, 22);
            this.rcvHex.Multiline = true;
            this.rcvHex.Name = "rcvHex";
            this.rcvHex.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rcvHex.Size = new System.Drawing.Size(506, 325);
            this.rcvHex.TabIndex = 5;
            // 
            // rcvHexClear
            // 
            this.rcvHexClear.Location = new System.Drawing.Point(518, 324);
            this.rcvHexClear.Name = "rcvHexClear";
            this.rcvHexClear.Size = new System.Drawing.Size(75, 23);
            this.rcvHexClear.TabIndex = 6;
            this.rcvHexClear.Text = "Claer";
            this.rcvHexClear.UseVisualStyleBackColor = true;
            this.rcvHexClear.Click += new System.EventHandler(this.rcvHexClear_Click);
            // 
            // rcvHexCopy
            // 
            this.rcvHexCopy.Location = new System.Drawing.Point(518, 295);
            this.rcvHexCopy.Name = "rcvHexCopy";
            this.rcvHexCopy.Size = new System.Drawing.Size(75, 23);
            this.rcvHexCopy.TabIndex = 7;
            this.rcvHexCopy.Text = "Copy";
            this.rcvHexCopy.UseVisualStyleBackColor = true;
            this.rcvHexCopy.Click += new System.EventHandler(this.rcvHexCopy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.showHex);
            this.groupBox2.Controls.Add(this.showAscii);
            this.groupBox2.Controls.Add(this.rcvHex);
            this.groupBox2.Controls.Add(this.rcvHexCopy);
            this.groupBox2.Controls.Add(this.rcvHexClear);
            this.groupBox2.Location = new System.Drawing.Point(12, 272);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(600, 353);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // showHex
            // 
            this.showHex.AutoSize = true;
            this.showHex.Checked = true;
            this.showHex.Location = new System.Drawing.Point(530, 23);
            this.showHex.Name = "showHex";
            this.showHex.Size = new System.Drawing.Size(47, 19);
            this.showHex.TabIndex = 1;
            this.showHex.TabStop = true;
            this.showHex.Text = "HEX";
            this.showHex.UseVisualStyleBackColor = true;
            // 
            // showAscii
            // 
            this.showAscii.AutoSize = true;
            this.showAscii.Location = new System.Drawing.Point(530, 48);
            this.showAscii.Name = "showAscii";
            this.showAscii.Size = new System.Drawing.Size(52, 19);
            this.showAscii.TabIndex = 0;
            this.showAscii.TabStop = true;
            this.showAscii.Text = "ASCII";
            this.showAscii.UseVisualStyleBackColor = true;
            // 
            // asciiSend
            // 
            this.asciiSend.Location = new System.Drawing.Point(433, 2);
            this.asciiSend.Name = "asciiSend";
            this.asciiSend.Size = new System.Drawing.Size(75, 23);
            this.asciiSend.TabIndex = 5;
            this.asciiSend.Text = "Send";
            this.asciiSend.UseVisualStyleBackColor = true;
            this.asciiSend.Click += new System.EventHandler(this.asciiSend_Click);
            // 
            // asciiInputClear
            // 
            this.asciiInputClear.Location = new System.Drawing.Point(514, 2);
            this.asciiInputClear.Name = "asciiInputClear";
            this.asciiInputClear.Size = new System.Drawing.Size(75, 23);
            this.asciiInputClear.TabIndex = 4;
            this.asciiInputClear.Text = "Clear";
            this.asciiInputClear.UseVisualStyleBackColor = true;
            this.asciiInputClear.Click += new System.EventHandler(this.asciiInputClear_Click);
            // 
            // asciiInput
            // 
            this.asciiInput.Location = new System.Drawing.Point(3, 3);
            this.asciiInput.Name = "asciiInput";
            this.asciiInput.Size = new System.Drawing.Size(424, 23);
            this.asciiInput.TabIndex = 0;
            // 
            // asciiSend2
            // 
            this.asciiSend2.Location = new System.Drawing.Point(433, 31);
            this.asciiSend2.Name = "asciiSend2";
            this.asciiSend2.Size = new System.Drawing.Size(75, 23);
            this.asciiSend2.TabIndex = 8;
            this.asciiSend2.Text = "Send";
            this.asciiSend2.UseVisualStyleBackColor = true;
            this.asciiSend2.Click += new System.EventHandler(this.asciiSend_Click);
            // 
            // asciiInputClear2
            // 
            this.asciiInputClear2.Location = new System.Drawing.Point(514, 31);
            this.asciiInputClear2.Name = "asciiInputClear2";
            this.asciiInputClear2.Size = new System.Drawing.Size(75, 23);
            this.asciiInputClear2.TabIndex = 7;
            this.asciiInputClear2.Text = "Clear";
            this.asciiInputClear2.UseVisualStyleBackColor = true;
            this.asciiInputClear2.Click += new System.EventHandler(this.asciiInputClear_Click);
            // 
            // asciiInput2
            // 
            this.asciiInput2.Location = new System.Drawing.Point(3, 32);
            this.asciiInput2.Name = "asciiInput2";
            this.asciiInput2.Size = new System.Drawing.Size(424, 23);
            this.asciiInput2.TabIndex = 6;
            // 
            // asciiSend3
            // 
            this.asciiSend3.Location = new System.Drawing.Point(433, 60);
            this.asciiSend3.Name = "asciiSend3";
            this.asciiSend3.Size = new System.Drawing.Size(75, 23);
            this.asciiSend3.TabIndex = 11;
            this.asciiSend3.Text = "Send";
            this.asciiSend3.UseVisualStyleBackColor = true;
            this.asciiSend3.Click += new System.EventHandler(this.asciiSend_Click);
            // 
            // asciiInputClear3
            // 
            this.asciiInputClear3.Location = new System.Drawing.Point(514, 60);
            this.asciiInputClear3.Name = "asciiInputClear3";
            this.asciiInputClear3.Size = new System.Drawing.Size(75, 23);
            this.asciiInputClear3.TabIndex = 10;
            this.asciiInputClear3.Text = "Clear";
            this.asciiInputClear3.UseVisualStyleBackColor = true;
            this.asciiInputClear3.Click += new System.EventHandler(this.asciiInputClear_Click);
            // 
            // asciiInput3
            // 
            this.asciiInput3.Location = new System.Drawing.Point(3, 61);
            this.asciiInput3.Name = "asciiInput3";
            this.asciiInput3.Size = new System.Drawing.Size(424, 23);
            this.asciiInput3.TabIndex = 9;
            // 
            // inputControl
            // 
            this.inputControl.Controls.Add(this.tabPage1);
            this.inputControl.Controls.Add(this.tabPage2);
            this.inputControl.Location = new System.Drawing.Point(12, 151);
            this.inputControl.Name = "inputControl";
            this.inputControl.SelectedIndex = 0;
            this.inputControl.Size = new System.Drawing.Size(600, 115);
            this.inputControl.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.hexInput3);
            this.tabPage1.Controls.Add(this.hexSend3);
            this.tabPage1.Controls.Add(this.hexInputClear3);
            this.tabPage1.Controls.Add(this.hexInput2);
            this.tabPage1.Controls.Add(this.hexSend2);
            this.tabPage1.Controls.Add(this.hexInputClear2);
            this.tabPage1.Controls.Add(this.hexInput);
            this.tabPage1.Controls.Add(this.hexSend);
            this.tabPage1.Controls.Add(this.hexInputClear);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(592, 87);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HEX input";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hexInput3
            // 
            this.hexInput3.Location = new System.Drawing.Point(3, 61);
            this.hexInput3.Mask = "CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC " +
    "CC CC CC CC CC";
            this.hexInput3.Name = "hexInput3";
            this.hexInput3.Size = new System.Drawing.Size(424, 23);
            this.hexInput3.TabIndex = 7;
            // 
            // hexSend3
            // 
            this.hexSend3.Location = new System.Drawing.Point(433, 61);
            this.hexSend3.Name = "hexSend3";
            this.hexSend3.Size = new System.Drawing.Size(75, 23);
            this.hexSend3.TabIndex = 9;
            this.hexSend3.Text = "Send";
            this.hexSend3.UseVisualStyleBackColor = true;
            this.hexSend3.Click += new System.EventHandler(this.hexSend_Click);
            // 
            // hexInputClear3
            // 
            this.hexInputClear3.Location = new System.Drawing.Point(514, 61);
            this.hexInputClear3.Name = "hexInputClear3";
            this.hexInputClear3.Size = new System.Drawing.Size(75, 23);
            this.hexInputClear3.TabIndex = 8;
            this.hexInputClear3.Text = "Clear";
            this.hexInputClear3.UseVisualStyleBackColor = true;
            this.hexInputClear3.Click += new System.EventHandler(this.hexInputClear_Click);
            // 
            // hexInput2
            // 
            this.hexInput2.Location = new System.Drawing.Point(3, 32);
            this.hexInput2.Mask = "CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC CC " +
    "CC CC CC CC CC";
            this.hexInput2.Name = "hexInput2";
            this.hexInput2.Size = new System.Drawing.Size(424, 23);
            this.hexInput2.TabIndex = 4;
            // 
            // hexSend2
            // 
            this.hexSend2.Location = new System.Drawing.Point(433, 32);
            this.hexSend2.Name = "hexSend2";
            this.hexSend2.Size = new System.Drawing.Size(75, 23);
            this.hexSend2.TabIndex = 6;
            this.hexSend2.Text = "Send";
            this.hexSend2.UseVisualStyleBackColor = true;
            this.hexSend2.Click += new System.EventHandler(this.hexSend_Click);
            // 
            // hexInputClear2
            // 
            this.hexInputClear2.Location = new System.Drawing.Point(514, 32);
            this.hexInputClear2.Name = "hexInputClear2";
            this.hexInputClear2.Size = new System.Drawing.Size(75, 23);
            this.hexInputClear2.TabIndex = 5;
            this.hexInputClear2.Text = "Clear";
            this.hexInputClear2.UseVisualStyleBackColor = true;
            this.hexInputClear2.Click += new System.EventHandler(this.hexInputClear_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.asciiSend3);
            this.tabPage2.Controls.Add(this.asciiInput);
            this.tabPage2.Controls.Add(this.asciiInputClear3);
            this.tabPage2.Controls.Add(this.asciiInputClear);
            this.tabPage2.Controls.Add(this.asciiInput3);
            this.tabPage2.Controls.Add(this.asciiSend);
            this.tabPage2.Controls.Add(this.asciiSend2);
            this.tabPage2.Controls.Add(this.asciiInput2);
            this.tabPage2.Controls.Add(this.asciiInputClear2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(592, 87);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ASCII input";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 631);
            this.Controls.Add(this.inputControl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Main";
            this.Text = "Serial communication console";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.inputControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox hexInput;
        private System.Windows.Forms.Button hexInputClear;
        private System.Windows.Forms.Button hexSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button serialConnect;
        private System.Windows.Forms.ComboBox serialPortname;
        private System.Windows.Forms.ComboBox serialBaudrate;
        private System.Windows.Forms.TextBox rcvHex;
        private System.Windows.Forms.Label serialStatus;
        private System.Windows.Forms.Button serialDisconnect;
        private System.Windows.Forms.Button rcvHexClear;
        private System.Windows.Forms.Button rcvHexCopy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton showHex;
        private System.Windows.Forms.RadioButton showAscii;
        private System.Windows.Forms.Button asciiSend;
        private System.Windows.Forms.Button asciiInputClear;
        private System.Windows.Forms.TextBox asciiInput;
        private System.Windows.Forms.Button asciiSend3;
        private System.Windows.Forms.Button asciiInputClear3;
        private System.Windows.Forms.TextBox asciiInput3;
        private System.Windows.Forms.Button asciiSend2;
        private System.Windows.Forms.Button asciiInputClear2;
        private System.Windows.Forms.TextBox asciiInput2;
        private System.Windows.Forms.TabControl inputControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MaskedTextBox hexInput3;
        private System.Windows.Forms.Button hexSend3;
        private System.Windows.Forms.Button hexInputClear3;
        private System.Windows.Forms.MaskedTextBox hexInput2;
        private System.Windows.Forms.Button hexSend2;
        private System.Windows.Forms.Button hexInputClear2;
        private System.Windows.Forms.RadioButton databit8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton parityEven;
        private System.Windows.Forms.RadioButton parityNone;
        private System.Windows.Forms.RadioButton databit7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton stopbit2;
        private System.Windows.Forms.RadioButton stopbit15;
        private System.Windows.Forms.RadioButton stopbit1;
        private System.Windows.Forms.RadioButton parityOdd;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton handshakeRts;
        private System.Windows.Forms.RadioButton handshakeXon;
        private System.Windows.Forms.RadioButton handshakeNone;
    }
}


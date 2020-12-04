using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SerialCom_Console
{
    public partial class Main : Form
    {
        private SerialPort serialport;

        private List<Button> sendHexButton;
        private List<MaskedTextBox> sendHexText;
        private List<Button> clearHexButton;

        private List<Button> sendAsciiButton;
        private List<TextBox> sendAsciiText;
        private List<Button> clearAsciiButton;

        public Main()
        {
            InitializeComponent();

            serialport = new SerialPort();
            inputControl.Enabled = false;

            sendHexButton = new List<Button>(new Button[] { hexSend, hexSend2, hexSend3 });
            sendHexText = new List<MaskedTextBox>(new MaskedTextBox[] { hexInput, hexInput2, hexInput3 });
            clearHexButton = new List<Button>(new Button[] { hexInputClear, hexInputClear2, hexInputClear3 });

            sendAsciiButton = new List<Button>(new Button[] { asciiSend, asciiSend2, asciiSend3 });
            sendAsciiText = new List<TextBox>(new TextBox[] { asciiInput, asciiInput2, asciiInput3 });
            clearAsciiButton = new List<Button>(new Button[] { asciiInputClear, asciiInputClear2, asciiInputClear3 });
        }

        private void SendHex(string inputstr)
        {
            string[] sendstr = inputstr.TrimEnd().Split(" ");

            List<byte> sendhexlist = new List<byte>();

            foreach (string item in sendstr)
            {
                if (int.TryParse(item, System.Globalization.NumberStyles.HexNumber, null, out int value))
                {
                    sendhexlist.Add((byte)value);
                }
            }

            AddLog($"Input accepted {sendhexlist.Count} bytes.");
            if (sendhexlist.Count == 0)
            {
                return;
            }

            SerialHexWrite(sendhexlist.ToArray());
        }

        private void SerialHexWrite(byte[] data)
        {
            serialport.Write(data, 0, data.Length);
            AddSndLog(data);
        }

        private void serialConnect_Click(object sender, EventArgs e)
        {
            if (serialPortname.Items.Count == 0)
            {
                MessageBox.Show("COM port is not selected");
                return;
            }

            int databit = 8;
            if(databit7.Checked)
            {
                databit = 7;
            }

            Parity parity = Parity.None;
            if(parityEven.Checked)
            {
                parity = Parity.Even;
            }
            else if(parityOdd.Checked)
            {
                parity = Parity.Odd;
            }

            StopBits stopbit = StopBits.One;
            if(stopbit15.Checked)
            {
                stopbit = StopBits.OnePointFive;
            }
            else if(stopbit2.Checked)
            {
                stopbit = StopBits.Two;
            }

            Handshake flowcont = Handshake.None;
            if(handshakeXon.Checked)
            {
                flowcont = Handshake.XOnXOff;
            }
            else if(handshakeRts.Checked)
            {
                flowcont = Handshake.RequestToSend;
            }

            if (!SerialOpen(serialPortname.SelectedItem.ToString(), int.Parse(serialBaudrate.SelectedItem.ToString()), databit, parity, stopbit, flowcont))
            {
                MessageBox.Show($"Error in opening COM port {serialPortname.SelectedItem}");
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] serialport_list = SerialPort.GetPortNames();

            serialPortname.Items.Clear();

            foreach (var item in serialport_list)
            {
                serialPortname.Items.Add(item);
            }

            if (serialPortname.Items.Count > 0)
            {
                serialPortname.SelectedIndex = 0;
            }

            serialBaudrate.SelectedIndex = 6;
        }

        private bool SerialOpen(string port, int rate, int databit = 8, Parity parity= Parity.None, StopBits stopbit = StopBits.One, Handshake flow = Handshake.None)
        {
            if(serialport.IsOpen)
            {
                SerialClose();
            }
            
            serialport = new SerialPort();
            serialport.DataReceived += Serialport_DataReceived;

            serialport.PortName = port;
            serialport.BaudRate = rate;

            serialport.DataBits = databit;
            serialport.Parity = parity;
            serialport.StopBits = stopbit;
            serialport.Handshake = flow;

            try
            {
                serialport.Open();
            }
            catch (Exception)
            {
                return false;
            }

            AddLog($"Serialport opened.\r\n{port}/Rate {rate}/Databit {databit}/Parity {parity}/Stopbit{stopbit}/Handshake {flow}");

            serialStatus.Text = "Connected";
            serialStatus.ForeColor = Color.Blue;
            inputControl.Enabled = true;

            return true;
        }

        private void Serialport_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;

            int datalen = sp.BytesToRead;
            byte[] buf = new byte[datalen];
            sp.Read(buf, 0, datalen);

            Invoke(new Action<byte[]>(AddRcvLog), buf);
        }

        private void AddLog(string str)
        {
            rcvHex.AppendText(str + "\r\n");
        }

        private void AddRcvLog(byte[] hex)
        {
            if(showHex.Checked)
            {
                AddLog($"Rcv: {BitConverter.ToString(hex)}");
            }
            else
            {
                AddLog($"Rcv: {Encoding.ASCII.GetString(hex)}");
            }
        }

        private void AddSndLog(byte[] hex)
        {
            if (showHex.Checked)
            {
                AddLog($"Snd: {BitConverter.ToString(hex)}");
            }
            else
            {
                AddLog($"Snd: {Encoding.ASCII.GetString(hex)}");
            }
        }

        private void SerialClose()
        {
            if(serialport.IsOpen)
            {
                serialport.DataReceived -= Serialport_DataReceived;
                serialport.Close();
            }

            serialStatus.Text = "Disconnected";
            serialStatus.ForeColor = Color.Red;
            inputControl.Enabled = false;

            AddLog("Serialport closed.");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerialClose();
            serialport.Dispose();
        }

        private void serialDisconnect_Click(object sender, EventArgs e)
        {
            SerialClose();
        }

        private void rcvHexClear_Click(object sender, EventArgs e)
        {
            rcvHex.Clear();
        }

        private void rcvHexCopy_Click(object sender, EventArgs e)
        {
            if(rcvHex.Text == "")
            {
                return;
            }
            Clipboard.SetText(rcvHex.Text);
            MessageBox.Show("Copied to clipboard.");
        }

        private void SendAscii(string str)
        {
            byte[] sendhex = Encoding.ASCII.GetBytes(str);

            AddLog($"Input accepted {sendhex.Length} bytes.");
            if (sendhex.Length == 0)
            {
                return;
            }

            SerialHexWrite(sendhex.ToArray());
        }

        private void asciiSend_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sendAsciiButton.Count; i++)
            {
                if (sender.Equals(sendAsciiButton[i]))
                {
                    SendAscii(sendAsciiText[i].Text);
                }
            }
        }

        private void asciiInputClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clearAsciiButton.Count; i++)
            {
                if (sender.Equals(clearAsciiButton[i]))
                {
                    sendAsciiText[i].Clear();
                }
            }
        }

        private void hexSend_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sendHexButton.Count; i++)
            {
                if (sender.Equals(sendHexButton[i]))
                {
                    SendHex(sendHexText[i].Text);
                }
            }
        }

        private void hexInputClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < clearHexButton.Count; i++)
            {
                if (sender.Equals(clearHexButton[i]))
                {
                    sendHexText[i].Clear();
                }
            }
        }
    }
}

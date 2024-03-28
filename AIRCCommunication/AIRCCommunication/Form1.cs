using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AIRCCommunication
{
    public partial class AIRCCommunication : Form
    {
        // serial 
        string data_send;
        string data_read;
        int flag = 0, intlen;
        string file_name;

        //TCP Client
        private TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        Thread ctThread;
        int flagg = 0;
        int flagg_close = 0;
        int count;

        //Tcp Server
        private TcpListener listener;
        private TcpClient client;
        private Thread listenThread;
        int flaggg = 0;
        int bytesRead = 0;
        public AIRCCommunication()
        {
            InitializeComponent();
        }
        // Serial Com

        private void AIRCCommunication_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox_Port.Items.AddRange(ports);
        }

        private void SendData_Click(object sender, EventArgs e)
        {
            if (SerialPort1.IsOpen)
            {
                data_send = textBoxDataSend.Text;
                SerialPort1.Write(data_send);
            }
        }


        private void Disconnect_Click(object sender, EventArgs e)
        {
            if (SerialPort1.IsOpen)
            {
                SerialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort serialPort = (SerialPort)sender;

            string strNumber = Convert.ToString(flag);


            string file_format = ".bin";
            string file_date = textBoxDate.Text;
            file_name = "_read_" + strNumber;
            // Đọc dữ liệu từ cổng serial
            byte[] buffer = new byte[serialPort.BytesToRead];
            serialPort.Read(buffer, 0, buffer.Length);

            // Ghi dữ liệu vào file dưới dạng bit nhị phân
            string filePath = textBox_Link.Text + @"\dataSerial_" + file_date + "_" + file_name + file_format;
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Append))
                {
                    fs.Write(buffer, 0, buffer.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi ghi dữ liệu vào file: " + ex.Message);
            }

            //data_read = SerialPort1.ReadExisting();
            data_read = Encoding.ASCII.GetString(buffer);
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {

            textBoxDataRead.Text += data_read;

            //File.WriteAllText(@"D:\01test data port\test.txt", TexboxDataRead.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); //Get list COM ports
            if (intlen != ports.Length)
            {
                intlen = ports.Length;
                comboBox_Port.Items.Clear();
                for (int i = 0; i < intlen; i++)
                {
                    comboBox_Port.Items.Add(ports[i]);
                }
            }
            textBox_TimeNumber.Text = Convert.ToString(flag);
        }

        private void ClearDisplay_Click(object sender, EventArgs e)
        {
            textBoxDataRead.Text = null;
        }

        private void Open_Click_1(object sender, EventArgs e)
        {
            try
            {
                SerialPort1.PortName = comboBox_Port.Text;
                SerialPort1.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                SerialPort1.DataBits = Convert.ToInt32(comboBoxDataBit.Text);
                SerialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopBit.Text);
                SerialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParityBit.Text);

                SerialPort1.Open();
                progressBar1.Value = 100;

            }

            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SendData_Click_1(object sender, EventArgs e)
        {
            if (SerialPort1.IsOpen)
            {
                data_send = textBoxDataSend.Text;
                SerialPort1.Write(data_send);
            }
        }

        private void NextTime_Click(object sender, EventArgs e)
        {
            flag++;
            textBoxDataRead.AppendText(Environment.NewLine);
        }

        // TCP Client
        private void getMessage()
        {
            string returndata;
            flagg_close = 1;
            serverStream = clientSocket.GetStream();
            var buffsize = 1024;//clientSocket.ReceiveBufferSize;
            byte[] instream = new byte[buffsize];


            //while (true && (clientSocket.Connected == true))
            while ((count = serverStream.Read(instream, 0, buffsize)) > 0)
            {

                string file_number = Convert.ToString(flagg);

                try
                {
                    using (FileStream fileStream = new FileStream(textBox_Link.Text + @"\dataClient_" + file_number + "_" + textBox_ClientTime.Text + ".bin", FileMode.Append))
                    {
                        fileStream.Write(instream, 0, count);
                    }

                    string data_receive = Encoding.ASCII.GetString(instream, 0, count);
                    msg("Data Received: " + data_receive);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi ghi dữ liệu vào file: " + ex.Message);
                }
                flagg_close = 0;
            }
        }

        private void msg(string message)
        {
            if (textBox_ClientDataRead.InvokeRequired)
            {
                textBox_ClientDataRead.Invoke(new Action<string>(msg), new object[] { message });
            }
            else
            {
                textBox_ClientDataRead.AppendText(message + Environment.NewLine + Environment.NewLine);

            }
            textBox_ClientLength.Text = Convert.ToString(count);
        }

        private void button_ClientSend_Click(object sender, EventArgs e)
        {
            byte[] outstream = Encoding.ASCII.GetBytes(textBox_ClientDataSend.Text);
            serverStream.Write(outstream, 0, outstream.Length);
            serverStream.Flush();
        }

        private void button_ClientClose_Click(object sender, EventArgs e)
        {
            if (flagg_close == 0)
            {
                try
                {
                    // Đóng kết nối với server
                    if (clientSocket != null && clientSocket.Connected)
                    {
                        // Nếu đã kết nối, đóng kết nối
                        clientSocket.Close();
                    }
                    MessageBox.Show("Đã đóng kết nối với server.");
                    button_ClientConnect.Enabled = true;
                    button_ClientClose.Enabled = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi đóng kết nối với server: " + ex.Message);
                    button_ClientConnect.Enabled = false;
                    button_ClientClose.Enabled = true;
                }
                flagg_close = 1;
            }

        }


        private void button_ClientNewFile_Click(object sender, EventArgs e)
        {
            flagg++;
            textBox_ClientNumber.Text = Convert.ToString(flagg);
        }

        private void button_ClientConnect_Click(object sender, EventArgs e)
        {
            try
            {

                if (!clientSocket.Connected)
                {
                    // Nếu không mở, mở kết nối mới
                    //clientSocket.Connect(textBox1.Text, Int32.Parse(textBox2.Text));
                    clientSocket = new TcpClient(textBox_ClientIP.Text, Int32.Parse(textBox_ClientPort.Text));
                    ctThread = new Thread(getMessage);
                    ctThread.Start();
                    MessageBox.Show("Kết nối thành công!");
                    button_ClientConnect.Enabled = false;
                    button_ClientClose.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Kết nối đã được thiết lập.");
                }
            }
            catch (Exception ex)
            {
                button_ClientConnect.Enabled = true;
                button_ClientClose.Enabled = false;
                MessageBox.Show("Lỗi khi kết nối với server: " + ex.Message);
            }
        }
        private void ClearDisplayClient_Click(object sender, EventArgs e)
        {

            textBox_ClientDataRead.Text = null;
        }




        //SERVER
        private void button_ServerListener_Click(object sender, EventArgs e)
        {
            listenThread = new Thread(StartListening);
            listenThread.IsBackground = true;
            listenThread.Start();
            button_ServerListener.Enabled = false;
            button_ServerClose.Enabled = true;
        }
        private void StartListening()
        {
            int Portt = Int32.Parse(textBox_ServerPort.Text);
            try
            {
                listener = new TcpListener(IPAddress.Any, Portt);
                listener.Start();
                AddMessageToTextBox("Listener started. Waiting for connections...");
                while (true)
                {

                    client = listener.AcceptTcpClient();
                    AddMessageToTextBox("Client connected.");

                    Thread clientThread = new Thread(() => HandleClient(client));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                AddMessageToTextBox("Error: " + ex.Message);
            }
        }
        private void AddMessageToTextBox(string message)
        {
            if (textBox_ServerReceiveData.InvokeRequired)
            {
                textBox_ServerReceiveData.Invoke(new Action<string>(AddMessageToTextBox), new object[] { message });
            }
            else
            {
                textBox_ServerReceiveData.AppendText(message + Environment.NewLine);
            }
            textBox3_ServerLength.Text = Convert.ToString(bytesRead);
        }

        private void button_ServerClose_Click(object sender, EventArgs e)
        {
            listener.Stop();
            button_ServerListener.Enabled = true;
            button_ServerClose.Enabled = false;
        }

        private void button_ServerSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null && client.Connected)
                {
                    NetworkStream stream = client.GetStream();
                    byte[] data = Encoding.ASCII.GetBytes(textBox_ServerSendData.Text);
                    stream.Write(data, 0, data.Length);
                    stream.Flush();
                    AddMessageToTextBox("Sent: " + textBox_ServerSendData.Text);
                }
                else
                {
                    AddMessageToTextBox("Error: Client is not connected.");
                }
            }
            catch (Exception ex)
            {
                AddMessageToTextBox("Error: " + ex.Message);
            }
        }

        private void button_ServerNewFile_Click(object sender, EventArgs e)
        {
            flaggg++;
            textBox_ServerNumber.Text = Convert.ToString(flaggg);
        }




        private void HandleClient(TcpClient client)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                byte[] buffer = new byte[1024];
                bytesRead = 0;

                while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string file_number = Convert.ToString(flaggg);
                    using (FileStream fileStream = new FileStream(textBox_ServerLink.Text + @"\" + "dataServer" + file_number + ".bin", FileMode.Append)) //Append
                    {
                        fileStream.Write(buffer, 0, bytesRead);
                    }

                    string dataReceived = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                    AddMessageToTextBox("Received: " + dataReceived);
                }
            }
            catch (Exception ex)
            {
                AddMessageToTextBox("Error: " + ex.Message);
            }
            finally
            {
                client.Close();
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ClearDisplayServer_Click(object sender, EventArgs e)
        {
            textBox_ServerReceiveData.Text = null;
        }

    }
}

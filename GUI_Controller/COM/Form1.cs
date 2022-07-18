using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//for Serial
using System.IO;
using System.IO.Ports;
using System.Xml;
using HookApp;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        String ReceiveData = String.Empty;
        String TransmitData = String.Empty;
        String InputData = String.Empty; // Khai báo string buff dùng cho hiển thị dữ liệu sau này.
        delegate void SetTextCallback(string text); // Khai bao delegate SetTextCallBack voi tham so string
        byte keypress = 0;
        Y2KeyboardHook _keyboardHook;

        public Form1()
        {
            InitializeComponent();
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            cmb_baudrate.Items.AddRange(BaudRate);
            Serial_Port.DataReceived += new SerialDataReceivedEventHandler(DataReceive);    //for Receive Data

            this.TopMost = true;

            //ListBox listBox1 = new ListBox();
            //listBox1.Location = new Point(10, 10);
            //listBox1.Size = new Size(200, 200);

            this.Controls.Add(listBox1);

            _keyboardHook = new Y2KeyboardHook();
            _keyboardHook.Install();

            _keyboardHook.KeyDown += (sender, e) =>
            {
                //listBox1.Items.Add("KeyDown: " + e.KeyCode);
                //listBox1.SelectedIndex = listBox1.Items.Count - 1;
                //Serial_Port.Write("KeyDown: " + e.KeyCode);
                if (Serial_Port.IsOpen && (keypress==0))
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Up:
                            Serial_Port.Write("F");
                            break;
                        case Keys.Down:
                            Serial_Port.Write("R");
                            break;
                            /*
                        case Keys.Right:
                            Serial_Port.Write("Right");
                            break;
                        case Keys.Left:
                            Serial_Port.Write("Left");
                            break;
                            */
                    }
                    keypress = 1;
                }
                
            };

            _keyboardHook.KeyUp += (sender, e) =>
            {
                //listBox1.Items.Add("KeyRelease: " + e.KeyCode);
                //listBox1.SelectedIndex = listBox1.Items.Count - 1;
                //Serial_Port.Write("KeyRelease: " + e.KeyCode);
                if (Serial_Port.IsOpen)
                {
                    switch (e.KeyCode)
                    {
                        case Keys.Up:
                            Serial_Port.Write("S");
                            break;
                        case Keys.Down:
                            Serial_Port.Write("S");
                            break;
                            /*
                        case Keys.Right:
                            Serial_Port.Write("Stop");
                            break;
                        case Keys.Left:
                            Serial_Port.Write("Stop");
                            break;
                            */
                    }
                    keypress = 0;
                }
            };

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            Serial_Port.PortName = "Select Com Port ...";
            Serial_Port.BaudRate = 9600;
            Serial_Port.DataBits = 8;
            Serial_Port.Parity = Parity.None;
            Serial_Port.StopBits = StopBits.One;

            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cbx_ComPort.Items.Add(port);
            }
            */
            cbx_ComPort.DataSource = SerialPort.GetPortNames();
            cmb_baudrate.SelectedIndex = 3;
        }
/* ****************************************** */
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {

                if (Serial_Port.IsOpen)
                {
                    Serial_Port.Close();
                }
                //this.Close();
            }
            catch { }
        }

        /* ******************************************** */
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (cbx_ComPort.Text == "Select Com Port")
                MessageBox.Show("Select COM Port !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Serial_Port.PortName = cbx_ComPort.Text;
                Serial_Port.BaudRate = Convert.ToInt32(cmb_baudrate.Text);
                Serial_Port.DataBits = 8;
                Serial_Port.Parity = Parity.None;
                Serial_Port.StopBits = StopBits.One;

                if (Serial_Port.IsOpen)
                {
                    Serial_Port.Close();
                    cbx_ComPort.Enabled = true;
                    cmb_baudrate.Enabled = true;
                    lbl_Status.Text = "Not Connected";
                    lbl_Status.BackColor = Color.Red;
                }
                try
                {
                    Serial_Port.Open();
                    //MessageBox.Show(cbx_ComPort.Text + " is connected.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lbl_Status.Text = "Connected";
                    lbl_Status.BackColor = Color.Lime;
                    cbx_ComPort.Enabled = false;
                    cmb_baudrate.Enabled = false;
                    ReceiveData = String.Empty;
                    TransmitData = String.Empty;
                }
                catch
                {
                    MessageBox.Show("COM Port is not connected !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            Serial_Port.Close();
            lbl_Status.Text = "Not Connected !";
            lbl_Status.BackColor = Color.Red;
            cbx_ComPort.Enabled = true;
            cmb_baudrate.Enabled = true;
            MessageBox.Show("COM Port is disconnected !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void cbx_ComPort_TextChanged(object sender, EventArgs e)
        {
            Serial_Port.Close();
            lbl_Status.Text = "Not Connected";
            lbl_Status.BackColor = Color.Red;
            Serial_Port.PortName = cbx_ComPort.Text;
            //MessageBox.Show(cbx_ComPort.Text);
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (!Serial_Port.IsOpen)
                MessageBox.Show("COM Port is not connected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                TransmitData = txt_Send.Text;
                Serial_Port.Write(TransmitData);
            }
        }

      
        private void DataReceive(object obj, SerialDataReceivedEventArgs e)
        {
            //InputData = Serial_Port.ReadExisting();
            try
            {
                InputData = Serial_Port.ReadTo("#");
                //InputData = Serial_Port.ReadTo("\x00");
                SetText(InputData);
            }
            catch { }

        }
        private void SetText(string text)
        {

            
            if (this.rtb_text.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText); // khởi tạo 1 delegate mới gọi đến SetText
                this.Invoke(d, new object[] { text });
            }
            
            else
            { 
                  //code Tested OK
                this.rtb_text.Text = text;
                ReceiveData = rtb_text.Text;
                //txt_Receive.Text = ReceiveData.Substring(2);

                /*
                try
                {
                    ReceiveData = text;
                    if (ReceiveData.Substring(0, 2) == "SW")
                    {
                        txt_Receive.Text = ReceiveData.Substring(2);
                    }
                    if (ReceiveData.Substring(0, 2) == "@V")
                    {
                        txt_volt.Text = ReceiveData.Substring(2);
                    }
                    ReceiveData = String.Empty;
                }
                catch
                {
                }
                */
            }   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            try
            {

                if (Serial_Port.IsOpen)
                {
                    Serial_Port.Close();
                }
                this.Close();
            }
            catch { }
        }

        private void cbx_Motor_Choi_CheckedChanged(object sender, EventArgs e)
        {
            if(Serial_Port.IsOpen && cbx_Motor_Choi.Checked)
            {
                Serial_Port.Write("C");
                MessageBox.Show("Motor Chổi ON");

            }
            if(Serial_Port.IsOpen && !cbx_Motor_Choi.Checked)
            {
                Serial_Port.Write("T");
                MessageBox.Show("Motor Chổi OFF");
            }
        }




        ////////////////////////Keypress in form focus//////////////////////////////
        /*
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            
            //capture up arrow key
            if (keyData == Keys.Up)
            {
                MessageBox.Show("You pressed Up arrow key");
                return true;
            }
            //capture down arrow key
            if (keyData == Keys.Down)
            {
                MessageBox.Show("You pressed Down arrow key");
                return true;
            }
            //capture left arrow key
            if (keyData == Keys.Left)
            {
                MessageBox.Show("You pressed Left arrow key");
                return true;
            }
            //capture right arrow key
            if (keyData == Keys.Right)
            {
                MessageBox.Show("You pressed Right arrow key");
                return true;
            }
            

            return base.ProcessCmdKey(ref msg, keyData);
        }
        */

    }

}

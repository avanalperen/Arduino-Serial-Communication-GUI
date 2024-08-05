using System.IO.Ports;

namespace Arduino_Serial_Communication_GUI
{
    public partial class ArduinoSerialComGUI : Form
    {

        // Create port value
        private SerialPort sp = new SerialPort();

        public ArduinoSerialComGUI()
        {
            InitializeComponent();
        }

        private void ArduinoSerialComGUI_Load(object sender, EventArgs e)
        {
            string[] portNames = SerialPort.GetPortNames();
            comboBoxComPort.Items.Clear();
            comboBoxComPort.Items.AddRange(portNames);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                // Show datas in text
                sp.PortName = comboBoxComPort.Text;
                sp.BaudRate = Convert.ToInt32(comboBoxBaudRate.Text);
                sp.DataBits = Convert.ToInt32(comboBoxDataBits.Text);
                sp.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopBits.Text);
                sp.Parity = (Parity)Enum.Parse(typeof(Parity), comboBoxParityBits.Text);

                sp.Open();

                progressBar1.Value = 100;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

            if (sp.IsOpen)
            {
                sp.Close();

                progressBar1.Value = 0;
            }
        }

        private void buttonSendData_Click(object sender, EventArgs e)
        {

        }
    }
}

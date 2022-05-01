using SimpleTCP;
using System.Text;

namespace AreYouGoingToHaveLunch
{
    public partial class AreYouGoingToHaveLunch : Form
    {
        public AreYouGoingToHaveLunch()
        {
            InitializeComponent(); 
        }

        private SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.StringEncoder = Encoding.ASCII;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object? sender, SimpleTCP.Message message)
        {
            textBoxStatus.Invoke((MethodInvoker)delegate ()
            {
                String incomingMessage = String.Format("{0}\r\n", message.MessageString.TrimEnd('\u0013'));
                textBoxStatus.Text += incomingMessage;

                message.ReplyLine(String.Format("Delivered: {0}", incomingMessage));
            });
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(textBoxHost.Text);
            server.Start(ip, Convert.ToUInt16(textBoxPort.Text));
            buttonStart.Enabled = false;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
                server.Stop();
                buttonStart.Enabled = true;
        }


    }
}
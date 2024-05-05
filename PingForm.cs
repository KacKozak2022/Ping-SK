using System.Net;
using System.Net.NetworkInformation;

namespace Ping_projekt_SK
{
    public partial class PingForm : Form
    {
        private const int COUNT = 4;
        private const int TTL = 56;
        private readonly List<string> LIST = new List<string>
        {
            "1.1.1.1",
            "8.8.8.8",
            "212.77.98.9",
            "157.158.3.1",
            "192.168.1.1"
        };

        private void addToReplies(string message)
        {
            lstReplies.Items.Add(message);
        }

        public PingForm()
        {
            InitializeComponent();
            nudPacketCount.Value = COUNT;
            nudTTL.Value = TTL;

            foreach (string ip in LIST)
                lstAddresses.Items.Add(ip);
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            try
            {
                string ipAddress = txtCurrent.Text;
                int packets = (int)nudPacketCount.Value;
                int packetsReceived = 0;
                int ttl = (int)nudTTL.Value;

                Ping ping = new Ping();
                PingOptions options = new PingOptions();
                options.Ttl = ttl;

                addToReplies($"[{DateTime.Now}] Replies from {ipAddress}:");

                for (int i = 0; i < packets; i++)
                {
                    PingReply reply = ping.Send(ipAddress, 1000, new byte[32], options);

                    if (reply.Status == IPStatus.Success)
                    {
                        addToReplies($"bytes={reply.Buffer.Length} time={reply.RoundtripTime}ms TTL={reply.Options.Ttl}");
                        packetsReceived++;
                    }
                    else
                        addToReplies("Request timed out");
                }

                addToReplies($"Packets: Sent={packets} Received={packetsReceived} Lost={packets - packetsReceived} ({((double) packets - packetsReceived)/packets * 100}% loss)");
                addToReplies("");
            }
            catch (Exception ex)
            {
                lstReplies.Items.Clear();
                MessageBox.Show($"Wyst¹pi³ b³¹d: {ex.Message}");
            }
        }

        private void lstAddresses_Click(object sender, EventArgs e)
        {
            txtCurrent.Text = lstAddresses.Items[lstAddresses.SelectedIndex].ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstAddresses.Items.Add(txtNew.Text);
        }
    }
}

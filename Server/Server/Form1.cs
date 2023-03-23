using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtIp_TextChanged(object sender, EventArgs e)
        {

        }
        UdpClient udp;
        IPEndPoint ipd;
        int remoteport = 44444;
        int localPort = 33333;
        private void onReceive(IAsyncResult A)
        {
            byte[] buff = udp.EndReceive(A, ref ipd);
            udp.BeginReceive(new AsyncCallback(onReceive), udp);
            ControlInvoke(tb_Mess, () => tb_Mess.AppendText("Client: " + Encoding.UTF8.GetString(buff) + Environment.NewLine));
        }

        delegate void VoidDelegate();
        public static void ControlInvoke(Control ctr, Action func)
        {
            if (ctr.IsDisposed || ctr.Disposing)
                return;
            if (ctr.InvokeRequired)
            {
                ctr.Invoke(new VoidDelegate(() => ControlInvoke(ctr, func)));
                return;
            }
            func();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(TxtIp.Text, out ip))
                MessageBox.Show("Hãy nhập chính xác IP để kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                udp = new UdpClient(localPort);
                ipd = new IPEndPoint(IPAddress.Parse(TxtIp.Text), remoteport);
                udp.BeginReceive(new AsyncCallback(onReceive), udp);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

            IPAddress ip;
            if (!IPAddress.TryParse(TxtIp.Text, out ip))
                MessageBox.Show("Hãy nhập chính xác IP ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string msg = "";
                udp.Connect(ipd);
                udp.Send(Encoding.UTF8.GetBytes(TxtMess.Text), TxtMess.Text.Length);
                msg = "Me: " + TxtMess.Text;
                ListSent.Items.Insert(0, msg);
                TxtMess.Clear();
            }
        }
    }
}

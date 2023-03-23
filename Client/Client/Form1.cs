using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        UdpClient udp;
        IPEndPoint ipe;
        int remoteport = 33333;
        int localPort = 44444;
        private void onReceive(IAsyncResult AB)
        {
            byte[] buff = udp.EndReceive(AB, ref ipe);
            udp.BeginReceive(new AsyncCallback(onReceive), udp);
            ControlInvoke(tb_Mess, () => tb_Mess.AppendText("Server: " + Encoding.UTF8.GetString(buff) + Environment.NewLine));
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(TxtIp.Text, out ip))
                MessageBox.Show("Hãy nhập chính xác IP ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                udp.Connect(ipe);
                udp.Send(Encoding.UTF8.GetBytes(TxtMess.Text), TxtMess.Text.Length);
                string msg = "";
                msg = "Me: " + TxtMess.Text;
                ListSent.Items.Insert(0, msg);
                TxtMess.Clear();
            }
        }
        delegate void VoidDelegate();
        public static void ControlInvoke(Control ctr,Action func)
        {
            if (ctr.IsDisposed || ctr.Disposing)
                return;
            if(ctr.InvokeRequired)
            {
                ctr.Invoke(new VoidDelegate(() => ControlInvoke(ctr, func)));
                return;
            }
            func();
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            IPAddress ip;
            if (!IPAddress.TryParse(TxtIp.Text, out ip))
                MessageBox.Show("Hãy nhập IP để kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                udp = new UdpClient(localPort);
                ipe = new IPEndPoint(IPAddress.Parse(TxtIp.Text), remoteport);
                udp.BeginReceive(new AsyncCallback(onReceive), udp);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;


namespace CSharp_Web_Server
{
    public partial class SelectInterface : Form
    {
        IPAddress[] ipList = Dns.GetHostEntry(Dns.GetHostName()).AddressList;

        public SelectInterface()
        {
            InitializeComponent();
            foreach (IPAddress ip in ipList)
            {
                cboxIP.Items.Add(ip.ToString());
            }
        }
        private void cboxIP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int port = -1;

            if (Int32.TryParse(tboxPort.Text, out port))
            {
                Listener l = new Listener(new IPEndPoint(ipList[cboxIP.SelectedIndex], port));
            }
            else
            {
                MessageBox.Show("Invalid port!");
            }
        }
    }
}

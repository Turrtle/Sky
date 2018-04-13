using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using System.Net;
using System.Diagnostics;

namespace opensource
{
    public partial class Form1 : Form
    {
        WebClient script = new WebClient();
        public Form1()
        {
            Process.Start("https://discord.gg/WEDKNGA");
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(script.DownloadString("Pastebin Link here"));
        }
    }
}

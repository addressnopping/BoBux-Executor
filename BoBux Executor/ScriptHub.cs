using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BoBux_Executor
{
    public partial class ScriptHub : Form
    {
        EasyExploits.Module module = new EasyExploits.Module();
        public ScriptHub()
        {
            InitializeComponent();
        }
        Point lastPoint;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/mDr81iyC");
            module.ExecuteScript(Script);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/ecbhY0g4");
            module.ExecuteScript(Script);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/juALHSnz");
            module.ExecuteScript(Script);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/BW0i1P3c");
            module.ExecuteScript(Script);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/dXUf0ku1");
            module.ExecuteScript(Script);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/ySQhutw7");
            module.ExecuteScript(Script);
        }
    }
}

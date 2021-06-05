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

        private void button13_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/PuPgZN70");
            module.ExecuteScript(Script);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/FU02DCMf");
            module.ExecuteScript(Script);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/ZJmARj6E");
            module.ExecuteScript(Script);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/h0516bLT");
            module.ExecuteScript(Script);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/3C3sx2mT");
            module.ExecuteScript(Script);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/7DPzKTRL");
            module.ExecuteScript(Script);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/WDDRAFEu");
            module.ExecuteScript(Script);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/AYmZ2DXz");
            module.ExecuteScript(Script);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/PkCDJuFz");
            module.ExecuteScript(Script);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/sJALMsH5");
            module.ExecuteScript(Script);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/b1z4Znkh");
            module.ExecuteScript(Script);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("https://pastebin.com/raw/X0BL7NXv");
            module.ExecuteScript(Script);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("");
            module.ExecuteScript(Script);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("");
            module.ExecuteScript(Script);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("");
            module.ExecuteScript(Script);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("");
            module.ExecuteScript(Script);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("");
            module.ExecuteScript(Script);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            WebClient wb = new WebClient();
            string Script = wb.DownloadString("");
            module.ExecuteScript(Script);
        }
    }
}

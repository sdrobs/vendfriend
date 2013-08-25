using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace windowHandler
{
    public partial class Form3 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (Program.GUIref4 != null)
            {
                    Program.GUIref4.Owner = Program.GUIref;
            }

            Program.GUIref.WindowState = FormWindowState.Normal;
            this.Dispose();
        }

        private void form_Resize(object sender, EventArgs e)
        {
            int[] width = {ulabel0.Width, ulabel1.Width, ulabel2.Width, ulabel3.Width, ulabel4.Width, ulabel5.Width};
            this.Width = width.Max();
            label1.Location = new Point(this.Width - 12, 1); 
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading;

namespace windowHandler
{
    public partial class Form4 : Form
    {
        public bool first = true;
        Rectangle rect;
        Region region;

        public Form4()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private int cGrip = 16;      // Grip size
        private int cCaption = 25;   // Caption bar height;

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)1;  // HTCAPTION
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            rect = new Rectangle(Point.Empty, this.Size);
            region = new Region(rect);

            rect.Inflate(-1 * (this.Width - 3), -1 * (this.Height - 3));
            region.Exclude(rect);

            this.Region = region;
            this.Owner = Program.GUIref;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            rect = new Rectangle(Point.Empty, this.Size);
            region = new Region(rect);
            rect.Inflate(-1 * (this.Width - 3), -1 * (this.Height - 3));
            region.Exclude(rect);

            this.Region = region;
            this.cGrip = Program.GUIref4.ClientSize.Width + Program.GUIref4.ClientSize.Height;
            this.cCaption = 3;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                InterceptMouse.active = true;
                InterceptMouse.stopped = false;
                first = false;
            }
        }


    }
}
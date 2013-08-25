using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace windowHandler
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {

            Program.Formref.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            System.Threading.Thread trd = new System.Threading.Thread(windowHandler.GUI.RT.tekDownloader);
            trd.IsBackground = true;
            trd.Start();
        }
    }
}

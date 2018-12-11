using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_gui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ClickMe_Click(object sender, EventArgs e)
        {
            ClickMe.Text = "Goodbye Kind World";
            timer1.Enabled = true;
        }
                
        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

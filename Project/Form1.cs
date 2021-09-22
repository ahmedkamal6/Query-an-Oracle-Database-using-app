using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormConnected f = new FormConnected();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDisconnected f = new FormDisconnected();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormCrystal f = new FormCrystal();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2Crystal f = new Form2Crystal();
            f.Show();
        }
    }
}

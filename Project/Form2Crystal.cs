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
    public partial class Form2Crystal : Form
    {
        CrystalReport3 CR;
        public Form2Crystal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;
        }

        private void Form2Crystal_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport3();
        }
    }
}

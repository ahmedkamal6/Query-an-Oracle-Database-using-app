using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Project
{
    public partial class FormCrystal : Form
    {
        CrystalReport2 CR;
        public FormCrystal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                CR.SetParameterValue(0, int.Parse(comboBox1.Text));
                crystalReportViewer1.ReportSource = CR;           
        }

        private void FormCrystal_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport2();
            foreach (ParameterDiscreteValue pdv in CR.ParameterFields[0].DefaultValues)
                comboBox1.Items.Add(pdv.Value);
            comboBox1.Text = comboBox1.Items[0].ToString();
        }
    }
}

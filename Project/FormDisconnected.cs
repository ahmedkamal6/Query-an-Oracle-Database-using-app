using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace Project
{
    public partial class FormDisconnected : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public FormDisconnected()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "User Id=scott;Password=tiger;Data Source=orcl";
            string cmdstr = "";
            
            if (radioButton1.Checked)
                cmdstr = "select * from employee where employee.jobtitle = 'delivery'";
            else if (radioButton2.Checked)
                cmdstr = "select * from employee where employee.jobtitle = 'manager'";
            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            try
            {
                adapter.Update(ds.Tables[0]);
                MessageBox.Show("Updated Successfully");
            }
            catch (Exception end)
            {
                MessageBox.Show("Error!!");
            }
        }

        private void FormDisconnected_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}

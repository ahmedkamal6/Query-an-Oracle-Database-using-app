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
    public partial class FormConnected : Form
    {
        string ordb = "Data source=orcl;User Id=scott;Password=tiger;";
        OracleConnection conn;
        public FormConnected()
        {
            InitializeComponent();
        }

        private void FormConnected_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(ordb);
            conn.Open();
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].HeaderCell.Value = "ProductID";
            dataGridView1.Columns[1].HeaderCell.Value = "ProductName";
            dataGridView1.Columns[2].HeaderCell.Value = "ProductCategory";
            dataGridView1.Columns[3].HeaderCell.Value = "ProductStock";
            dataGridView1.Columns[4].HeaderCell.Value = "ProductPrice";
            dataGridView1.Columns[5].HeaderCell.Value = "ProductSupplierID";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select prod_id from product";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cmb_id.Items.Add(dr[0]);
                cmb2_id.Items.Add(dr[0]);
            }
            dr.Close();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void FormConnected_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }

        private void cmb_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select prod_name , prod_category,stock,price,sup_id from product where prod_id =:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", cmb_id.SelectedItem.ToString());

            OracleDataReader odr = c.ExecuteReader();
            if (odr.Read())
            {
                prodname.Text = odr[0].ToString();
                category.Text = odr[1].ToString();
                stock.Text = odr[2].ToString();
                price.Text = odr[3].ToString();
                sup_id.Text = odr[4].ToString();
            }
            odr.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmnd = new OracleCommand();
            cmnd.Connection = conn;
            cmnd.CommandText = "insert into product values(:id,:name,:cat,:stk,:price,:sup)";
            cmnd.Parameters.Add("id", cmb2_id.Text);
            cmnd.Parameters.Add("name", name.Text);
            cmnd.Parameters.Add("cat", cat.Text);
            cmnd.Parameters.Add("stk", st.Text);
            cmnd.Parameters.Add("price", pr.Text);
            cmnd.Parameters.Add("sup", sup.Text);
            try
            {
                int r = cmnd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("product added");
                    cmb2_id.Items.Add(cmb2_id.Text);
                    cmb_id.Items.Add(cmb2_id.Text);
                    cmb2_id.Text = "";
                    name.Text = " ";
                    cat.Text = " ";
                    st.Text = " ";
                    pr.Text = " ";
                    sup.Text = " ";
                }
            }
            catch(Exception exc)
            {
                if (exc.Message == "ORA-00001: unique constraint (SCOTT.SYS_C0013801) violated")
                    MessageBox.Show("id already exists");
                else if (exc.Message == "ORA-02291: integrity constraint (SCOTT.SYS_C0013802) violated - parent key not found")
                    MessageBox.Show("supplier must exist");
                else 
                    MessageBox.Show(exc.Message);
            }
           
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand cmnd = new OracleCommand();
            cmnd.Connection = conn;

            cmnd.CommandText = "delete from product where prod_id =:id";
            cmnd.Parameters.Add("id", cmb2_id.Text);

            try
            {
                int r = cmnd.ExecuteNonQuery();
                if (r != -1)
                    MessageBox.Show("product deleted");
                cmb2_id.Items.Remove(cmb2_id.Text);
                cmb_id.Items.Remove(cmb_id.Text);
                cmb2_id.Text = "";
                name.Text = " ";
                cat.Text = " ";
                st.Text = " ";
                pr.Text = " ";
                sup.Text = " ";


            }

            catch (Exception exce)
            {
               
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            OracleCommand cmnd = new OracleCommand();
            cmnd.Connection = conn;
            cmnd.CommandText = "selection";
            cmnd.CommandType = CommandType.StoredProcedure;
            cmnd.Parameters.Add("p_id", Convert.ToInt32(idtxt.Text));           
            cmnd.Parameters.Add("stock", OracleDbType.Int32,ParameterDirection.Output);
            cmnd.Parameters.Add("price", OracleDbType.Int32,ParameterDirection.Output);
            cmnd.Parameters.Add("sup", OracleDbType.Int32, ParameterDirection.Output);
            try
            {
                cmnd.ExecuteNonQuery();
                stocktxt.Text = cmnd.Parameters["stock"].Value.ToString();
                pricetxt.Text = cmnd.Parameters["price"].Value.ToString();
                suptxt.Text = cmnd.Parameters["sup"].Value.ToString();
            }
            catch(Exception esc)
            {
                MessageBox.Show("no data found");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            OracleCommand cmnd = new OracleCommand();
            cmnd.Connection = conn;
            cmnd.CommandText = "selectall";
            cmnd.CommandType = CommandType.StoredProcedure;
            cmnd.Parameters.Add("erow", OracleDbType.RefCursor, ParameterDirection.Output);          
            OracleDataReader dr = cmnd.ExecuteReader();
            while(dr.Read())
            {
                dataGridView1.Rows.Add(dr[0], dr[1], dr[2], dr[3], dr[4], dr[5]);
            }
            dr.Close();
            dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

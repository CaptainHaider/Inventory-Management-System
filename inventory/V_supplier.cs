using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace inventory
{
    public partial class V_supplier : Form
    {
        SqlConnection cs = new SqlConnection("Data Source=DELL-PC; Initial Catalog=supermart; Integrated Security=TRUE");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public V_supplier()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void V_supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermartDataSet1.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.supermartDataSet1.supplier);

            DataTable dt = new DataTable();
            SqlDataAdapter ap = new SqlDataAdapter();
            ap.SelectCommand = new SqlCommand("SELECT * FROM supplier", cs);
            ap.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (textBox1.Text == "Please Enter Customer Name")
            {
                textBox1.Text = "";
            }
            else
                textBox1.ForeColor = Color.Black;

            if (textBox1.Text != string.Empty)
            {
                try
                {
                    dataGridView1.DataSource = null;
                    DataTable dt = new DataTable();
                    SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM supplier WHERE sup_name like '" + textBox1.Text + "%'", cs);
                    ad.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Please Enter a valid Supplier Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM supplier", cs);
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            V_supplier_Load(sender, e);
            da.SelectCommand = new SqlCommand("SELECT * FROM supplier", cs);
            ds.Clear();
            da.Fill(ds);
        }
    }
}

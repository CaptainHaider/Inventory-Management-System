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
    public partial class v_customer : Form
    {
        SqlConnection cs = new SqlConnection("Data Source=DELL-PC; Initial Catalog=supermart; Integrated Security=TRUE");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public v_customer()
        {
            InitializeComponent();
           
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
                    SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM customer WHERE cus_name like '" + textBox1.Text + "%'", cs);
                    ad.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch
                {
                    MessageBox.Show("Please Enter a valid Customer Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                dataGridView1.DataSource = null;
                DataTable dt = new DataTable();
                SqlDataAdapter ad = new SqlDataAdapter("SELECT * FROM Customer", cs);
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            v_customer_Load(sender, e);
            da.SelectCommand = new SqlCommand("SELECT * FROM customer", cs);
            ds.Clear();
            da.Fill(ds);
        }

        private void v_customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermartDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.supermartDataSet.customer);
            DataTable dt = new DataTable();
            SqlDataAdapter ap = new SqlDataAdapter();
            ap.SelectCommand = new SqlCommand("SELECT * FROM customer", cs);
            ap.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

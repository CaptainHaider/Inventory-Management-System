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
    public partial class V_sale : Form
    {
        SqlConnection cs = new SqlConnection("Data Source=DELL-PC; Initial Catalog=supermart; Integrated Security=TRUE");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        public V_sale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                dataGridView1.DataSource = null;
                da.SelectCommand = new SqlCommand("SELECT sale.sale_id, customer.cus_name, item.item_name,sale.quantity,sale.total_price,sale.selling_price,sale.date FROM customer Inner Join sale on customer.cus_id = sale.cus_id Inner Join item on sale.item_id = item.item_id WHERE customer.cus_name like '" + textBox1.Text + "%' OR item.item_name like '" + textBox1.Text + "%'", cs);
                ds.Clear();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];

                bs.DataSource = ds.Tables[0];
            }
            catch
            {
                MessageBox.Show("Please Enter a valid supply name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }

        private void V_sale_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ap = new SqlDataAdapter();
            ap.SelectCommand = new SqlCommand("SELECT sale.sale_id, customer.cus_name, item.item_name,sale.quantity,sale.total_price,sale.selling_price,sale.date FROM customer Inner Join sale on customer.cus_id = sale.cus_id Inner Join item on sale.item_id = item.item_id", cs);
            ap.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            V_sale_Load(sender, e);
            da.SelectCommand = new SqlCommand("SELECT sale.sale_id, customer.cus_name, item.item_name,sale.quantity,sale.total_price,sale.selling_price,sale.date FROM customer Inner Join sale on customer.cus_id = sale.cus_id Inner Join item on sale.item_id = item.item_id", cs);
            ds.Clear();
            da.Fill(ds);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            V_sale_Load(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

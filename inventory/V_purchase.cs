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
    public partial class V_purchase : Form
    {
        SqlConnection cs = new SqlConnection("Data Source=DELL-PC; Initial Catalog=supermart; Integrated Security=TRUE");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        public V_purchase()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           V_purchase_Load(sender, e);
           da.SelectCommand = new SqlCommand("SELECT purchase.purchase_id, supplier.sup_name, item.item_name,purchase.cost_price,purchase.quantity, purchase.unit, purchase.entry_date FROM supplier Inner Join purchase on supplier.sup_id = purchase.sup_id Inner Join item on purchase.item_id = item.item_id", cs);
            ds.Clear();
            da.Fill(ds);
        }

        private void V_purchase_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter ap = new SqlDataAdapter();
            ap.SelectCommand = new SqlCommand("SELECT purchase.purchase_id, supplier.sup_name, item.item_name,purchase.cost_price,purchase.quantity, purchase.unit, purchase.entry_date FROM supplier Inner Join purchase on supplier.sup_id = purchase.sup_id Inner Join item on purchase.item_id = item.item_id", cs);
            ap.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = null;
                da.SelectCommand = new SqlCommand("SELECT purchase.purchase_id, supplier.sup_name, item.item_name,purchase.cost_price,purchase.quantity,purchase.unit , purchase.entry_date FROM supplier Inner Join purchase on supplier.sup_id = purchase.sup_id Inner Join item on purchase.item_id = item.item_id WHERE supplier.sup_name like '" + textBox1.Text + "%' OR item.item_name like '" + textBox1.Text + "%'", cs);
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

      

      
    }
}

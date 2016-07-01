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
    public partial class A_supplier : Form
    {
        SqlConnection cs = new SqlConnection("Data Source=DELL-PC; Initial Catalog=supermart; Integrated Security=TRUE");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public A_supplier()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void A_supplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermartDataSet1.supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter1.Fill(this.supermartDataSet1.supplier);
           
            
            // TODO: This line of code loads data into the 'supermartDataSet.supplier' table. You can move, or remove it, as needed.
           


           
            DataTable dt = new DataTable();
            da.SelectCommand = new SqlCommand("SELECT * FROM supplier", cs);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            da.InsertCommand = new SqlCommand("INSERT INTO [supplier] (sup_name,sup_address,sup_phone,entry_date) VALUES (@sup_name,@sup_address,@sup_phone,@entry_date)", cs);
            da.InsertCommand.Parameters.Add("@sup_name", SqlDbType.VarChar).Value = textBox1.Text;
            da.InsertCommand.Parameters.Add("@sup_address", SqlDbType.VarChar).Value = textBox2.Text;
            da.InsertCommand.Parameters.Add("@sup_phone", SqlDbType.Int).Value = textBox3.Text;
            da.InsertCommand.Parameters.Add("@entry_date", SqlDbType.Date).Value = DateTime.Now;
            
            
            
            

            cs.Open();
            try
            {
                da.InsertCommand.ExecuteNonQuery();
                A_supplier_Load(sender, e);
                Initialization();
                MessageBox.Show("Data Entered");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            cs.Close();
        
        }
        public void Initialization()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            A_supplier_Load(sender, e);
            da.SelectCommand = new SqlCommand("SELECT * FROM customer", cs);
            ds.Clear();
            da.Fill(ds);
        }
    }

}

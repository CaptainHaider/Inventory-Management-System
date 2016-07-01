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
    public partial class A_customer : Form
    {
        
        SqlConnection cs = new SqlConnection("Data Source=DELL-PC; Initial Catalog=supermart; Integrated Security=TRUE");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public A_customer()
        {
            InitializeComponent();
        }

        private void A_customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermartDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.supermartDataSet.customer);

            DataTable dt = new DataTable();
            da.SelectCommand = new SqlCommand("SELECT * FROM Customer", cs);
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void button1_Click(object sender, EventArgs e)
        {


            da.InsertCommand = new SqlCommand("INSERT INTO [customer] (cus_name,cus_address,cus_phone,entry_date) VALUES (@cus_name,@cus_address,@cus_phone,@entry_date)", cs);
            da.InsertCommand.Parameters.Add("@cus_name", SqlDbType.VarChar).Value = textBox1.Text;
            da.InsertCommand.Parameters.Add("@cus_address", SqlDbType.VarChar).Value = textBox3.Text;
            da.InsertCommand.Parameters.Add("@cus_phone", SqlDbType.Int).Value = textBox2.Text;
            da.InsertCommand.Parameters.Add("@entry_date", SqlDbType.Date).Value = DateTime.Now;
            cs.Open();
            try
            {
                da.InsertCommand.ExecuteNonQuery();
                A_customer_Load(sender, e);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Permanently Delete this Record?", "Confirm Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                da.DeleteCommand = new SqlCommand("DELETE FROM Customer WHERE cus_id = @cus_id", cs);
                da.DeleteCommand.Parameters.Add("@cus_id", SqlDbType.Int).Value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                cs.Open();
                try
                {
                    da.DeleteCommand.ExecuteNonQuery();
                    A_customer_Load(sender, e);
                    Initialization();
                    MessageBox.Show("Data Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                cs.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        }

        
        }
    




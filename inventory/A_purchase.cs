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
    public partial class A_purchase : Form
    {
        SqlConnection cs = new SqlConnection("Data Source=DELL-PC; Initial Catalog=supermart; Integrated Security=TRUE");
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataAdapter da2 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public A_purchase()
        {
            InitializeComponent();
        }

        private void A_purchase_Load(object sender, EventArgs e)
        {


            DataTable dt10 = new DataTable();
            //join grid view giving name with respect to id
            da.SelectCommand = new SqlCommand("SELECT purchase.purchase_id, supplier.sup_name,purchase.selling_price, item.item_name,purchase.cost_price,purchase.quantity, purchase.unit, purchase.entry_date FROM supplier Inner Join purchase on supplier.sup_id = purchase.sup_id Inner Join item on purchase.item_id = item.item_id", cs);
            ds.Clear();
            da.Fill(dt10);

            dataGridView1.DataSource = dt10;

            Supplier_Name();
        }
        public void Supplier_Name()
        {
            SqlDataAdapter da1 = new SqlDataAdapter();
            DataTable dt9 = new DataTable();
            da1.SelectCommand = new SqlCommand("SELECT sup_name FROM [supplier]", cs);
            ds.Clear();
            da1.Fill(dt9);

            comboBox2.Items.Clear();
            foreach (DataRow Sup_name in dt9.Rows)
            {
                comboBox2.Items.Add(Sup_name[0]);
            }
            comboBox2.Text = "Select Supplier_Name".ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //Sup_ID
            DataTable dt1 = new DataTable();
            da.SelectCommand = new SqlCommand("SELECT sup_id FROM supplier WHERE sup_name = '" + comboBox2.Text + "'", cs);
            ds.Clear();
            da.Fill(dt1);

            DataTable dt2 = new DataTable();
            da.SelectCommand = new SqlCommand("SELECT item_id FROM item WHERE item_name = '" + textBox1.Text + "'", cs);
            ds.Clear();
            da.Fill(dt2);
            //checking whehter item exists or not
            if (dt2.Rows.Count == 0)
            {
                da.InsertCommand = new SqlCommand("INSERT INTO [item] (item_name,quantity,price,date,selling_price) VALUES (@item_name,@quantity,@price,@date,@selling_price)", cs);
                da.InsertCommand.Parameters.Add("@item_name", SqlDbType.VarChar).Value = textBox1.Text;
                da.InsertCommand.Parameters.Add("@quantity", SqlDbType.Int).Value = textBox3.Text;
                da.InsertCommand.Parameters.Add("@price", SqlDbType.Int).Value = textBox2.Text;
                da.InsertCommand.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now;
                da.InsertCommand.Parameters.Add("@selling_price", SqlDbType.Int).Value = textBox2.Text;

                cs.Open();
                try
                {
                    da.InsertCommand.ExecuteNonQuery();
                    //da4.InsertCommand.ExecuteNonQuery();
                }
                catch { }
                cs.Close();

                DataTable dt4 = new DataTable();
                da.SelectCommand = new SqlCommand("SELECT item_id FROM item WHERE item_name = '" + textBox1.Text + "'", cs);
                ds.Clear();
                da.Fill(dt4);

                DataTable dt6 = new DataTable();
                da.SelectCommand = new SqlCommand("SELECT sup_id FROM supplier WHERE sup_name = '" + comboBox2.Text + "'", cs);
                ds.Clear();
                da.Fill(dt6);

                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.InsertCommand = new SqlCommand("INSERT INTO [purchase] (sup_id,item_id,cost_price,quantity,selling_price,unit,entry_date) VALUES (@sup_id,@item_id,@cost_price,@quantity,@selling_price,@unit,@entry_date)", cs);
                da1.InsertCommand.Parameters.Add("@sup_id", SqlDbType.Int).Value = (dt6.Rows[0][0].ToString());
                da1.InsertCommand.Parameters.Add("@item_id", SqlDbType.Int).Value = (dt4.Rows[0][0].ToString());
                da1.InsertCommand.Parameters.Add("@cost_price", SqlDbType.Int).Value = textBox2.Text;
                da1.InsertCommand.Parameters.Add("@quantity", SqlDbType.Int).Value = textBox3.Text;
                da1.InsertCommand.Parameters.Add("@selling_price", SqlDbType.Int).Value = textBox4.Text;
                da1.InsertCommand.Parameters.Add("@unit", SqlDbType.Int).Value = textBox5.Text;
                da1.InsertCommand.Parameters.Add("@entry_date", SqlDbType.Date).Value = DateTime.Now;
                // inserting into item at the time

                cs.Open();
                try
                {
                    da1.InsertCommand.ExecuteNonQuery();
                    A_purchase_Load(sender, e);
                    Initialization();
                    MessageBox.Show("Data Entered");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                cs.Close();

            }
            //if item exists then update
            else
            {
                //Item_ID
                DataTable dt3 = new DataTable();
                da.SelectCommand = new SqlCommand("SELECT quantity FROM [item] WHERE item_name = '" + textBox1.Text + "'", cs);
                ds.Clear();
                da.Fill(dt3);

                //Update quantity of Stock
                //updating extra if it exists
                da2.UpdateCommand = new SqlCommand("UPDATE [item] SET quantity += " + textBox3.Text + ",price ='" + textBox2.Text + "' WHERE item_id = @item_id", cs);
                da2.UpdateCommand.Parameters.Add("@quantity", SqlDbType.Int).Value = Convert.ToInt32(dt3.Rows[0][0].ToString()) + Convert.ToInt32(textBox2.Text);
                da2.UpdateCommand.Parameters.Add("@item_id", SqlDbType.Int).Value = dt2.Rows[0][0].ToString();
                cs.Open();
                da2.UpdateCommand.ExecuteNonQuery();
                cs.Close();
                SqlDataAdapter da8 = new SqlDataAdapter();
                da8.InsertCommand = new SqlCommand("INSERT INTO [purchase] (sup_id,item_id,cost_price,quantity,selling_price,unit,entry_date) VALUES (@sup_id,@item_id,@cost_price,@quantity,@selling_price,@unit,@entry_date)", cs);
                da8.InsertCommand.Parameters.Add("@sup_id", SqlDbType.Int).Value = Convert.ToInt32(dt1.Rows[0][0].ToString());
                da8.InsertCommand.Parameters.Add("@item_id", SqlDbType.Int).Value = Convert.ToInt32(dt1.Rows[0][0].ToString());
                da8.InsertCommand.Parameters.Add("@cost_price", SqlDbType.Int).Value = textBox2.Text;
                da8.InsertCommand.Parameters.Add("@quantity", SqlDbType.Int).Value = textBox3.Text;
                da8.InsertCommand.Parameters.Add("@selling_price", SqlDbType.Int).Value = textBox4.Text;
                da8.InsertCommand.Parameters.Add("@unit", SqlDbType.Int).Value = textBox5.Text;
                da8.InsertCommand.Parameters.Add("@entry_date", SqlDbType.Date).Value = DateTime.Now;
                // inserting into item at the time

                cs.Open();
                try
                {
                    da8.InsertCommand.ExecuteNonQuery();
                    A_purchase_Load(sender, e);
                    Initialization();
                    MessageBox.Show("Data Entered");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                cs.Close();

            }


        }
        public void Initialization()
        {
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Permanently Delete this Record?", "Confirm Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                da.DeleteCommand = new SqlCommand("DELETE FROM Purchase WHERE item_id = @item_id", cs);
                da.DeleteCommand.Parameters.Add("@item_id", SqlDbType.Int).Value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                cs.Open();
                try
                {
                    da.DeleteCommand.ExecuteNonQuery();
                    A_purchase_Load(sender, e);
                    Initialization();
                    MessageBox.Show("Data Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

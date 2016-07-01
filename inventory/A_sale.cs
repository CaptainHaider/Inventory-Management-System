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
    public partial class A_sale : Form
    {
        int availableQuantity,b;
        SqlConnection cs = new SqlConnection("Data Source=DELL-PC; Initial Catalog=supermart; Integrated Security=TRUE");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public A_sale()
        {
            InitializeComponent();
        }

        private void comboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void customer_name()
        {
            SqlDataAdapter da1 = new SqlDataAdapter();
            DataTable dt9 = new DataTable();
            da1.SelectCommand = new SqlCommand("SELECT cus_name FROM [customer]", cs);
            ds.Clear();
            da1.Fill(dt9);

           comboBox1.Items.Clear();
            foreach (DataRow cus_name in dt9.Rows)
            {
                comboBox1.Items.Add(cus_name[0]);
            }
            comboBox1.Text = "Select Customer_Name".ToString();
        }

        public void Item_Name()
        {
            SqlDataAdapter da5 = new SqlDataAdapter();
            DataTable dt10 = new DataTable();
            da5.SelectCommand = new SqlCommand("SELECT item_name FROM [item]", cs);
            ds.Clear();
            da5.Fill(dt10);

            comboBox2.Items.Clear();
            foreach (DataRow item_name in dt10.Rows)
            {
                comboBox2.Items.Add(item_name[0]);
            }
            comboBox2.Text = "Select Item_Name".ToString();
        }

        private void A_sale_Load(object sender, EventArgs e)
        {
            label5.Visible = false;
            label6.Visible = false;

            //Get Selling History
            DataTable dt = new DataTable();
            da.SelectCommand = new SqlCommand("SELECT sale.sale_id, customer.cus_name, item.item_name, sale.quantity, sale.selling_price, sale.total_price, sale.date FROM customer Inner Join sale on customer.cus_id = sale.cus_id Inner Join item on sale.item_id = item.item_id", cs);
            ds.Clear();
            da.Fill(dt);

            dataGridView1.DataSource = dt;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customer_name();
            Item_Name();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt13 = new DataTable();
            da.SelectCommand = new SqlCommand("SELECT  quantity ,selling_price FROM [item] WHERE item_name = '" + comboBox2.Text + "'", cs);
            ds.Clear();
            da.Fill(dt13);



            if (dt13.Rows.Count > 0)
            {
                label5.Visible = true;
                label5.Text = "Available Quantity: " + dt13.Rows[0][0].ToString();
                availableQuantity = Convert.ToInt32(dt13.Rows[0][0].ToString());

                label6.Visible = true;
                label6.Text = "Selling Price: " + dt13.Rows[0][1].ToString();
                //textBox1.Text = "" + dt13.Rows[0][1].ToString();
            }
            else
            {
                label5.Visible = false;
                label6.Visible = false;
            }

            b = (txtQuantity.Text != "") ? Convert.ToInt32(txtQuantity.Text) : 0;
            if (b > availableQuantity)
            {
                MessageBox.Show("Quantity should be less than available Quantity", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtQuantity.Focus();
            }

            else
            {
                //Cus_ID
                DataTable dt1 = new DataTable();
                da.SelectCommand = new SqlCommand("SELECT cus_id FROM customer WHERE cus_name = '" + comboBox1.Text + "'", cs);
                ds.Clear();
                da.Fill(dt1);

                //Item_ID
                DataTable dt2 = new DataTable();
                da.SelectCommand = new SqlCommand("SELECT item_id, selling_price, quantity FROM [item] WHERE item_name = '" + comboBox2.Text + "'", cs);
                ds.Clear();
                da.Fill(dt2);

                //Calculating Balance


                //Calculating Total Amount
                long totalAmount = calculateTotalAmount();


                //Sale Stock
                da.InsertCommand = new SqlCommand("INSERT INTO [sale] (cus_id, item_id, quantity, selling_price,total_price, date) VALUES (@cus_id, @item_id, @quantity, @selling_price, @total_price, @date)", cs);
                da.InsertCommand.Parameters.Add("@cus_id", SqlDbType.Int).Value = dt1.Rows[0][0].ToString();
                da.InsertCommand.Parameters.Add("@item_id", SqlDbType.Int).Value = dt2.Rows[0][0].ToString();
                da.InsertCommand.Parameters.Add("@date", SqlDbType.Date).Value = DateTime.Now;
                if (string.IsNullOrEmpty(txtQuantity.Text))
                    da.InsertCommand.Parameters.Add("@quantity", SqlDbType.Int).Value = DBNull.Value;
                else
                    da.InsertCommand.Parameters.Add("@quantity", SqlDbType.Int).Value = txtQuantity.Text;
                da.InsertCommand.Parameters.Add("@selling_price", SqlDbType.Int).Value = txtSellingPrice.Text;
                da.InsertCommand.Parameters.Add("@total_price", SqlDbType.Int).Value = totalAmount;



                //Reduce quantity of Stock
                SqlDataAdapter da2 = new SqlDataAdapter();
                da2.UpdateCommand = new SqlCommand("UPDATE [item] SET quantity = @quantity WHERE item_id = @item_id", cs);
                if (string.IsNullOrEmpty(txtQuantity.Text))
                    da2.UpdateCommand.Parameters.Add("@quantity", SqlDbType.Int).Value = Convert.ToInt32(dt2.Rows[0][2].ToString());
                else
                    da2.UpdateCommand.Parameters.Add("@quantity", SqlDbType.Int).Value = Convert.ToInt32(dt2.Rows[0][2].ToString()) - Convert.ToInt32(txtQuantity.Text);
                da2.UpdateCommand.Parameters.Add("@item_id", SqlDbType.Int).Value = dt2.Rows[0][0].ToString();

                cs.Open();
                try
                {
                    da.InsertCommand.ExecuteNonQuery();
                    da2.UpdateCommand.ExecuteNonQuery();
                    A_sale_Load(sender, e);
                    //Initialization();
                    MessageBox.Show("Data Entered");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                cs.Close();
               
            }
        }
             private long calculateTotalAmount()
        {
            long total = 0;
            try
            {
                if (txtSellingPrice.Text != ""  && txtQuantity.Text != "")
                {
                    int Quantity = Convert.ToInt32(txtQuantity.Text);
                    total = Convert.ToInt64(txtSellingPrice.Text) * Quantity;
                }
                else if (txtSellingPrice.Text != ""  && txtQuantity.Text == "")
                {
                    total = Convert.ToInt64(txtSellingPrice.Text);
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid value", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Stop);
               
            }
            return total;
        }

             private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
             {
                 da.SelectCommand = new SqlCommand("SELECT * FROM Sale", cs);
                 ds.Clear();
                 da.Fill(ds);
             }

             private void label5_Click(object sender, EventArgs e)
             {
                 

             }

             private void button2_Click(object sender, EventArgs e)
             {


                   if (MessageBox.Show("Are you sure you want to Permanently Delete this Record?", "Confirm Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                da.DeleteCommand = new SqlCommand("DELETE FROM Sale WHERE sale_id = @sale_id", cs);
                da.DeleteCommand.Parameters.Add("@sale_id", SqlDbType.Int).Value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                cs.Open();
                try
                {
                    da.DeleteCommand.ExecuteNonQuery();
                    A_sale_Load(sender, e);
                    MessageBox.Show("Data Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                cs.Close();
            }
        }


             

             private void txtQuantity_TextChanged(object sender, EventArgs e)
             {

             }

             private void label6_Click(object sender, EventArgs e)
             {

             }

             private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
             {
                 DataTable dt13 = new DataTable();
                 da.SelectCommand = new SqlCommand("SELECT  quantity FROM [item] WHERE item_name = '" + comboBox2.Text + "'", cs);
                 ds.Clear();
                 da.Fill(dt13);
                 DataTable dt2 = new DataTable();
                 da.SelectCommand = new SqlCommand("SELECT  selling_price FROM [item] WHERE item_name = '" + comboBox2.Text + "'", cs);
                 ds.Clear();
                 da.Fill(dt2);
                 if (dt13.Rows.Count > 0)
                 {
                     label5.Visible = true;
                     label5.Text = "Available Quantity: " + dt13.Rows[0][0].ToString();
                     availableQuantity = Convert.ToInt32(dt13.Rows[0][0].ToString());

                     label6.Visible = true;
                     label6.Text = "Selling Price: " + dt2.Rows[0][0].ToString();
                    // SellingPrice = Convert.ToInt32( dt2.Rows[0][0].ToString());
                 }
                 else
                 {
                     label5.Visible = false;
                     label6.Visible = false;
                 }

                
             }
    }
}

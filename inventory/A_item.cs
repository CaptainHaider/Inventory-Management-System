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
    public partial class A_item : Form
    {
        SqlConnection cs = new SqlConnection("Data Source=DELL-PC; Initial Catalog=supermart; Integrated Security=TRUE");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        public A_item()
        {
            InitializeComponent();
        }

        private void A_item_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'supermartDataSet2.item' table. You can move, or remove it, as needed.
            this.itemTableAdapter.Fill(this.supermartDataSet2.item);
            
           

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Permanently Delete this Record?", "Confirm Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                da.DeleteCommand = new SqlCommand("DELETE FROM item WHERE item_name = @item_name", cs);
                da.DeleteCommand.Parameters.Add("@item_name", SqlDbType.VarChar).Value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                cs.Open();
                try
                {
                    da.DeleteCommand.ExecuteNonQuery();
                    A_item_Load(sender, e);
                    
                    MessageBox.Show("Data Deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                cs.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

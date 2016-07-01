using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace inventory
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void addDateToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_customer ac = new A_customer();
           
            ac.Show();
        }

        private void vcusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            v_customer vc = new v_customer();
            vc.Show();
        }

        private void asaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_sale sa = new A_sale();
            sa.Show();
        }

        private void asupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_supplier sp = new A_supplier();
            sp.Show();
        }

        private void apurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_purchase ap = new A_purchase();
            ap.Show();
        }

        private void aitemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A_item it = new A_item();
            it.Show();
        }

        private void vitemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_item te = new V_item();
            te.Show();
        }

        private void vpurchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_purchase vp = new V_purchase();
            vp.Show();
        }

        private void vsupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_supplier sq = new V_supplier();
            sq.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help h = new help();
            h.Show();
        }

        private void vsaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V_sale gf = new V_sale();
            gf.Show();
        } 
    }
}

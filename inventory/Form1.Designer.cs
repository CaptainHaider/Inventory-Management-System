namespace inventory
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vcusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vsupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vitemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vpurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vsaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aitemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apurchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.addDateToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(796, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vcusToolStripMenuItem,
            this.vsupplierToolStripMenuItem,
            this.vitemToolStripMenuItem,
            this.vpurchaseToolStripMenuItem,
            this.vsaleToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.viewToolStripMenuItem.Text = "View Data";
            // 
            // vcusToolStripMenuItem
            // 
            this.vcusToolStripMenuItem.Name = "vcusToolStripMenuItem";
            this.vcusToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.vcusToolStripMenuItem.Text = "V_customer";
            this.vcusToolStripMenuItem.Click += new System.EventHandler(this.vcusToolStripMenuItem_Click);
            // 
            // vsupplierToolStripMenuItem
            // 
            this.vsupplierToolStripMenuItem.Name = "vsupplierToolStripMenuItem";
            this.vsupplierToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.vsupplierToolStripMenuItem.Text = "V_supplier";
            this.vsupplierToolStripMenuItem.Click += new System.EventHandler(this.vsupplierToolStripMenuItem_Click);
            // 
            // vitemToolStripMenuItem
            // 
            this.vitemToolStripMenuItem.Name = "vitemToolStripMenuItem";
            this.vitemToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.vitemToolStripMenuItem.Text = "V_item";
            this.vitemToolStripMenuItem.Click += new System.EventHandler(this.vitemToolStripMenuItem_Click);
            // 
            // vpurchaseToolStripMenuItem
            // 
            this.vpurchaseToolStripMenuItem.Name = "vpurchaseToolStripMenuItem";
            this.vpurchaseToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.vpurchaseToolStripMenuItem.Text = "V_purchase";
            this.vpurchaseToolStripMenuItem.Click += new System.EventHandler(this.vpurchaseToolStripMenuItem_Click);
            // 
            // vsaleToolStripMenuItem
            // 
            this.vsaleToolStripMenuItem.Name = "vsaleToolStripMenuItem";
            this.vsaleToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.vsaleToolStripMenuItem.Text = "V_sale";
            this.vsaleToolStripMenuItem.Click += new System.EventHandler(this.vsaleToolStripMenuItem_Click);
            // 
            // addDateToolStripMenuItem
            // 
            this.addDateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acustomerToolStripMenuItem,
            this.asupplierToolStripMenuItem,
            this.aitemToolStripMenuItem,
            this.apurchaseToolStripMenuItem,
            this.asaleToolStripMenuItem});
            this.addDateToolStripMenuItem.Name = "addDateToolStripMenuItem";
            this.addDateToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.addDateToolStripMenuItem.Text = "Add Data";
            this.addDateToolStripMenuItem.Click += new System.EventHandler(this.addDateToolStripMenuItem_Click);
            // 
            // acustomerToolStripMenuItem
            // 
            this.acustomerToolStripMenuItem.Name = "acustomerToolStripMenuItem";
            this.acustomerToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.acustomerToolStripMenuItem.Text = "A_customer";
            this.acustomerToolStripMenuItem.Click += new System.EventHandler(this.acustomerToolStripMenuItem_Click);
            // 
            // asupplierToolStripMenuItem
            // 
            this.asupplierToolStripMenuItem.Name = "asupplierToolStripMenuItem";
            this.asupplierToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.asupplierToolStripMenuItem.Text = "A_supplier";
            this.asupplierToolStripMenuItem.Click += new System.EventHandler(this.asupplierToolStripMenuItem_Click);
            // 
            // aitemToolStripMenuItem
            // 
            this.aitemToolStripMenuItem.Name = "aitemToolStripMenuItem";
            this.aitemToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.aitemToolStripMenuItem.Text = "A_item";
            this.aitemToolStripMenuItem.Click += new System.EventHandler(this.aitemToolStripMenuItem_Click);
            // 
            // apurchaseToolStripMenuItem
            // 
            this.apurchaseToolStripMenuItem.Name = "apurchaseToolStripMenuItem";
            this.apurchaseToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.apurchaseToolStripMenuItem.Text = "A_purchase";
            this.apurchaseToolStripMenuItem.Click += new System.EventHandler(this.apurchaseToolStripMenuItem_Click);
            // 
            // asaleToolStripMenuItem
            // 
            this.asaleToolStripMenuItem.Name = "asaleToolStripMenuItem";
            this.asaleToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.asaleToolStripMenuItem.Text = "A_sale";
            this.asaleToolStripMenuItem.Click += new System.EventHandler(this.asaleToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            this.viewHelpToolStripMenuItem.Click += new System.EventHandler(this.viewHelpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 488);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Inventory System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vcusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vsupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vitemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vpurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vsaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aitemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apurchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}


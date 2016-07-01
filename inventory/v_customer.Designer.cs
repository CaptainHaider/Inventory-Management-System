namespace inventory
{
    partial class v_customer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_customer));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cusidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermartDataSet = new inventory.supermartDataSet();
            this.customerTableAdapter = new inventory.supermartDataSetTableAdapters.customerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermartDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUSTOMER NAME";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusidDataGridViewTextBoxColumn,
            this.cusnameDataGridViewTextBoxColumn,
            this.cusphoneDataGridViewTextBoxColumn,
            this.cusaddressDataGridViewTextBoxColumn,
            this.entrydateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.customerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(169, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(554, 245);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cusidDataGridViewTextBoxColumn
            // 
            this.cusidDataGridViewTextBoxColumn.DataPropertyName = "cus_id";
            this.cusidDataGridViewTextBoxColumn.HeaderText = "cus_id";
            this.cusidDataGridViewTextBoxColumn.Name = "cusidDataGridViewTextBoxColumn";
            this.cusidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cusnameDataGridViewTextBoxColumn
            // 
            this.cusnameDataGridViewTextBoxColumn.DataPropertyName = "cus_name";
            this.cusnameDataGridViewTextBoxColumn.HeaderText = "cus_name";
            this.cusnameDataGridViewTextBoxColumn.Name = "cusnameDataGridViewTextBoxColumn";
            this.cusnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cusphoneDataGridViewTextBoxColumn
            // 
            this.cusphoneDataGridViewTextBoxColumn.DataPropertyName = "cus_phone";
            this.cusphoneDataGridViewTextBoxColumn.HeaderText = "cus_phone";
            this.cusphoneDataGridViewTextBoxColumn.Name = "cusphoneDataGridViewTextBoxColumn";
            this.cusphoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cusaddressDataGridViewTextBoxColumn
            // 
            this.cusaddressDataGridViewTextBoxColumn.DataPropertyName = "cus_address";
            this.cusaddressDataGridViewTextBoxColumn.HeaderText = "cus_address";
            this.cusaddressDataGridViewTextBoxColumn.Name = "cusaddressDataGridViewTextBoxColumn";
            this.cusaddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entrydateDataGridViewTextBoxColumn
            // 
            this.entrydateDataGridViewTextBoxColumn.DataPropertyName = "entry_date";
            this.entrydateDataGridViewTextBoxColumn.HeaderText = "entry_date";
            this.entrydateDataGridViewTextBoxColumn.Name = "entrydateDataGridViewTextBoxColumn";
            this.entrydateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.supermartDataSet;
            // 
            // supermartDataSet
            // 
            this.supermartDataSet.DataSetName = "supermartDataSet";
            this.supermartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // v_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 569);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "v_customer";
            this.Text = "View Customer Data";
            this.Load += new System.EventHandler(this.v_customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermartDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private supermartDataSet supermartDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private supermartDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrydateDataGridViewTextBoxColumn;
    }
}
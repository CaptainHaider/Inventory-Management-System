namespace inventory
{
    partial class V_supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_supplier));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermartDataSet1 = new inventory.supermartDataSet1();
            this.supplierTableAdapter = new inventory.supermartDataSet1TableAdapters.supplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermartDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SUPPLIER NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supidDataGridViewTextBoxColumn,
            this.supaddressDataGridViewTextBoxColumn,
            this.supphoneDataGridViewTextBoxColumn,
            this.entrydateDataGridViewTextBoxColumn,
            this.supnameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.supplierBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(97, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 187);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // supidDataGridViewTextBoxColumn
            // 
            this.supidDataGridViewTextBoxColumn.DataPropertyName = "sup_id";
            this.supidDataGridViewTextBoxColumn.HeaderText = "sup_id";
            this.supidDataGridViewTextBoxColumn.Name = "supidDataGridViewTextBoxColumn";
            this.supidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // supaddressDataGridViewTextBoxColumn
            // 
            this.supaddressDataGridViewTextBoxColumn.DataPropertyName = "sup_address";
            this.supaddressDataGridViewTextBoxColumn.HeaderText = "sup_address";
            this.supaddressDataGridViewTextBoxColumn.Name = "supaddressDataGridViewTextBoxColumn";
            // 
            // supphoneDataGridViewTextBoxColumn
            // 
            this.supphoneDataGridViewTextBoxColumn.DataPropertyName = "sup_phone";
            this.supphoneDataGridViewTextBoxColumn.HeaderText = "sup_phone";
            this.supphoneDataGridViewTextBoxColumn.Name = "supphoneDataGridViewTextBoxColumn";
            // 
            // entrydateDataGridViewTextBoxColumn
            // 
            this.entrydateDataGridViewTextBoxColumn.DataPropertyName = "entry_date";
            this.entrydateDataGridViewTextBoxColumn.HeaderText = "entry_date";
            this.entrydateDataGridViewTextBoxColumn.Name = "entrydateDataGridViewTextBoxColumn";
            // 
            // supnameDataGridViewTextBoxColumn
            // 
            this.supnameDataGridViewTextBoxColumn.DataPropertyName = "sup_name";
            this.supnameDataGridViewTextBoxColumn.HeaderText = "sup_name";
            this.supnameDataGridViewTextBoxColumn.Name = "supnameDataGridViewTextBoxColumn";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.supermartDataSet1;
            // 
            // supermartDataSet1
            // 
            this.supermartDataSet1.DataSetName = "supermartDataSet1";
            this.supermartDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // V_supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 569);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "V_supplier";
            this.Text = "View Supplier Record";
            this.Load += new System.EventHandler(this.V_supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermartDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private supermartDataSet1 supermartDataSet1;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private supermartDataSet1TableAdapters.supplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn supidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supnameDataGridViewTextBoxColumn;
    }
}
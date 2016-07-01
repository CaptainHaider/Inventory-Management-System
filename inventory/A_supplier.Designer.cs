namespace inventory
{
    partial class A_supplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_supplier));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermartDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supermartDataSet = new inventory.supermartDataSet();
            this.supplierTableAdapter = new inventory.supermartDataSetTableAdapters.supplierTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.supidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrydateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.supermartDataSet1 = new inventory.supermartDataSet1();
            this.supplierTableAdapter1 = new inventory.supermartDataSet1TableAdapters.supplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermartDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermartDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermartDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADDRESS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(421, 47);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 20);
            this.textBox2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PHONE #";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 20);
            this.textBox3.TabIndex = 5;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            this.supplierBindingSource.DataSource = this.supermartDataSetBindingSource;
            // 
            // supermartDataSetBindingSource
            // 
            this.supermartDataSetBindingSource.DataSource = this.supermartDataSet;
            this.supermartDataSetBindingSource.Position = 0;
            // 
            // supermartDataSet
            // 
            this.supermartDataSet.DataSetName = "supermartDataSet";
            this.supermartDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(684, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.DataSource = this.supplierBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(47, 333);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(705, 236);
            this.dataGridView1.TabIndex = 8;
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
            // supplierBindingSource1
            // 
            this.supplierBindingSource1.DataMember = "supplier";
            this.supplierBindingSource1.DataSource = this.supermartDataSet1;
            // 
            // supermartDataSet1
            // 
            this.supermartDataSet1.DataSetName = "supermartDataSet1";
            this.supermartDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // supplierTableAdapter1
            // 
            this.supplierTableAdapter1.ClearBeforeFill = true;
            // 
            // A_supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 569);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "A_supplier";
            this.Text = "Add Supplier Data";
            this.Load += new System.EventHandler(this.A_supplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermartDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermartDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermartDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.BindingSource supermartDataSetBindingSource;
        private supermartDataSet supermartDataSet;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private supermartDataSetTableAdapters.supplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private supermartDataSet1 supermartDataSet1;
        private System.Windows.Forms.BindingSource supplierBindingSource1;
        private supermartDataSet1TableAdapters.supplierTableAdapter supplierTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn supidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrydateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supnameDataGridViewTextBoxColumn;
    }
}
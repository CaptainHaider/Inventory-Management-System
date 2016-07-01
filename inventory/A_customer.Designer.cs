namespace inventory
{
    partial class A_customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A_customer));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PHONE #";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "ADDRESS";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(187, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(372, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(187, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(82, 90);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(187, 20);
            this.textBox3.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(618, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "New Entry";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(618, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(163, 272);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(548, 297);
            this.dataGridView1.TabIndex = 10;
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
            // 
            // cusphoneDataGridViewTextBoxColumn
            // 
            this.cusphoneDataGridViewTextBoxColumn.DataPropertyName = "cus_phone";
            this.cusphoneDataGridViewTextBoxColumn.HeaderText = "cus_phone";
            this.cusphoneDataGridViewTextBoxColumn.Name = "cusphoneDataGridViewTextBoxColumn";
            // 
            // cusaddressDataGridViewTextBoxColumn
            // 
            this.cusaddressDataGridViewTextBoxColumn.DataPropertyName = "cus_address";
            this.cusaddressDataGridViewTextBoxColumn.HeaderText = "cus_address";
            this.cusaddressDataGridViewTextBoxColumn.Name = "cusaddressDataGridViewTextBoxColumn";
            // 
            // entrydateDataGridViewTextBoxColumn
            // 
            this.entrydateDataGridViewTextBoxColumn.DataPropertyName = "entry_date";
            this.entrydateDataGridViewTextBoxColumn.HeaderText = "entry_date";
            this.entrydateDataGridViewTextBoxColumn.Name = "entrydateDataGridViewTextBoxColumn";
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
            // A_customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(889, 569);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "A_customer";
            this.Text = "Add Customer Data";
            this.Load += new System.EventHandler(this.A_customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supermartDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
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
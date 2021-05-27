namespace QuizMahasiswa
{
    partial class MasterBarang024
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbSupplier = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idbarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namabarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namasupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblbarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barangDataSet = new QuizMahasiswa.BarangDataSet();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbl_barangTableAdapter = new QuizMahasiswa.BarangDataSetTableAdapters.tbl_barangTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(223, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Master Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nama Barang";
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(296, 122);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(144, 26);
            this.txtNamaBarang.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Harga";
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(296, 161);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(144, 26);
            this.txtHarga.TabIndex = 6;
            this.txtHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarga_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Stok";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(296, 199);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(144, 26);
            this.txtStock.TabIndex = 8;
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nama Supplier";
            // 
            // cbSupplier
            // 
            this.cbSupplier.FormattingEnabled = true;
            this.cbSupplier.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbSupplier.Location = new System.Drawing.Point(296, 237);
            this.cbSupplier.Name = "cbSupplier";
            this.cbSupplier.Size = new System.Drawing.Size(144, 28);
            this.cbSupplier.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbarangDataGridViewTextBoxColumn,
            this.namabarangDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.namasupplierDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblbarangBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(59, 288);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(481, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // idbarangDataGridViewTextBoxColumn
            // 
            this.idbarangDataGridViewTextBoxColumn.DataPropertyName = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.HeaderText = "id_barang";
            this.idbarangDataGridViewTextBoxColumn.Name = "idbarangDataGridViewTextBoxColumn";
            this.idbarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namabarangDataGridViewTextBoxColumn
            // 
            this.namabarangDataGridViewTextBoxColumn.DataPropertyName = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.HeaderText = "nama_barang";
            this.namabarangDataGridViewTextBoxColumn.Name = "namabarangDataGridViewTextBoxColumn";
            this.namabarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namasupplierDataGridViewTextBoxColumn
            // 
            this.namasupplierDataGridViewTextBoxColumn.DataPropertyName = "nama_supplier";
            this.namasupplierDataGridViewTextBoxColumn.HeaderText = "nama_supplier";
            this.namasupplierDataGridViewTextBoxColumn.Name = "namasupplierDataGridViewTextBoxColumn";
            this.namasupplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblbarangBindingSource
            // 
            this.tblbarangBindingSource.DataMember = "tbl_barang";
            this.tblbarangBindingSource.DataSource = this.barangDataSet;
            // 
            // barangDataSet
            // 
            this.barangDataSet.DataSetName = "BarangDataSet";
            this.barangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(167, 458);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbl_barangTableAdapter
            // 
            this.tbl_barangTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID Barang";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(296, 81);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(144, 26);
            this.txtID.TabIndex = 14;
            // 
            // btnClear
            // 
            this.btnClear.AutoSize = true;
            this.btnClear.Location = new System.Drawing.Point(350, 458);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // MasterBarang024
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 522);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbSupplier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MasterBarang024";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MasterBarang024_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblbarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barangDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbSupplier;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private BarangDataSet barangDataSet;
        private System.Windows.Forms.BindingSource tblbarangBindingSource;
        private BarangDataSetTableAdapters.tbl_barangTableAdapter tbl_barangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namasupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnClear;
    }
}


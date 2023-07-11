namespace APOTIKNEW
{
    partial class InputObat
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
            this.obatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apotikNEWDataSet = new APOTIKNEW.ApotikNEWDataSet();
            this.obatTableAdapter = new APOTIKNEW.ApotikNEWDataSetTableAdapters.ObatTableAdapter();
            this.idobat = new System.Windows.Forms.Label();
            this.namaobat = new System.Windows.Forms.Label();
            this.hargaobat = new System.Windows.Forms.Label();
            this.stokobat = new System.Windows.Forms.Label();
            this.cbxjenisobat = new System.Windows.Forms.ComboBox();
            this.txtidobat = new System.Windows.Forms.TextBox();
            this.txtnamaobat = new System.Windows.Forms.TextBox();
            this.jenisobat = new System.Windows.Forms.Label();
            this.txthargaobat = new System.Windows.Forms.TextBox();
            this.txtstokobat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btninput = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaObatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaobatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokobatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisobatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apotikNEWDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // obatBindingSource
            // 
            this.obatBindingSource.DataMember = "Obat";
            this.obatBindingSource.DataSource = this.apotikNEWDataSet;
            // 
            // apotikNEWDataSet
            // 
            this.apotikNEWDataSet.DataSetName = "ApotikNEWDataSet";
            this.apotikNEWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // obatTableAdapter
            // 
            this.obatTableAdapter.ClearBeforeFill = true;
            // 
            // idobat
            // 
            this.idobat.AutoSize = true;
            this.idobat.Location = new System.Drawing.Point(48, 50);
            this.idobat.Name = "idobat";
            this.idobat.Size = new System.Drawing.Size(52, 16);
            this.idobat.TabIndex = 0;
            this.idobat.Text = "ID Obat";
            // 
            // namaobat
            // 
            this.namaobat.AutoSize = true;
            this.namaobat.Location = new System.Drawing.Point(45, 84);
            this.namaobat.Name = "namaobat";
            this.namaobat.Size = new System.Drawing.Size(76, 16);
            this.namaobat.TabIndex = 1;
            this.namaobat.Text = "Nama Obat";
            // 
            // hargaobat
            // 
            this.hargaobat.AutoSize = true;
            this.hargaobat.Location = new System.Drawing.Point(45, 119);
            this.hargaobat.Name = "hargaobat";
            this.hargaobat.Size = new System.Drawing.Size(77, 16);
            this.hargaobat.TabIndex = 2;
            this.hargaobat.Text = "Harga Obat";
            // 
            // stokobat
            // 
            this.stokobat.AutoSize = true;
            this.stokobat.Location = new System.Drawing.Point(45, 156);
            this.stokobat.Name = "stokobat";
            this.stokobat.Size = new System.Drawing.Size(62, 16);
            this.stokobat.TabIndex = 3;
            this.stokobat.Text = "stok obat";
            // 
            // cbxjenisobat
            // 
            this.cbxjenisobat.FormattingEnabled = true;
            this.cbxjenisobat.Items.AddRange(new object[] {
            "Tablet",
            "Sirup",
            "Kapsul"});
            this.cbxjenisobat.Location = new System.Drawing.Point(170, 187);
            this.cbxjenisobat.Name = "cbxjenisobat";
            this.cbxjenisobat.Size = new System.Drawing.Size(121, 24);
            this.cbxjenisobat.TabIndex = 4;
            // 
            // txtidobat
            // 
            this.txtidobat.Location = new System.Drawing.Point(170, 47);
            this.txtidobat.Name = "txtidobat";
            this.txtidobat.Size = new System.Drawing.Size(100, 22);
            this.txtidobat.TabIndex = 5;
            // 
            // txtnamaobat
            // 
            this.txtnamaobat.Location = new System.Drawing.Point(170, 84);
            this.txtnamaobat.Name = "txtnamaobat";
            this.txtnamaobat.Size = new System.Drawing.Size(100, 22);
            this.txtnamaobat.TabIndex = 6;
            // 
            // jenisobat
            // 
            this.jenisobat.AutoSize = true;
            this.jenisobat.Location = new System.Drawing.Point(45, 190);
            this.jenisobat.Name = "jenisobat";
            this.jenisobat.Size = new System.Drawing.Size(69, 16);
            this.jenisobat.TabIndex = 7;
            this.jenisobat.Text = "Jenis obat";
            // 
            // txthargaobat
            // 
            this.txthargaobat.Location = new System.Drawing.Point(170, 119);
            this.txthargaobat.Name = "txthargaobat";
            this.txthargaobat.Size = new System.Drawing.Size(100, 22);
            this.txthargaobat.TabIndex = 8;
            // 
            // txtstokobat
            // 
            this.txtstokobat.Location = new System.Drawing.Point(170, 156);
            this.txtstokobat.Name = "txtstokobat";
            this.txtstokobat.Size = new System.Drawing.Size(100, 22);
            this.txtstokobat.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(425, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Input Obat";
            // 
            // btninput
            // 
            this.btninput.Location = new System.Drawing.Point(48, 248);
            this.btninput.Name = "btninput";
            this.btninput.Size = new System.Drawing.Size(75, 23);
            this.btninput.TabIndex = 11;
            this.btninput.Text = "INPUT";
            this.btninput.UseVisualStyleBackColor = true;
            this.btninput.Click += new System.EventHandler(this.btninput_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDObatDataGridViewTextBoxColumn,
            this.namaObatDataGridViewTextBoxColumn,
            this.hargaobatDataGridViewTextBoxColumn,
            this.stokobatDataGridViewTextBoxColumn,
            this.jenisobatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.obatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 331);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(665, 132);
            this.dataGridView1.TabIndex = 14;
            // 
            // iDObatDataGridViewTextBoxColumn
            // 
            this.iDObatDataGridViewTextBoxColumn.DataPropertyName = "ID_Obat";
            this.iDObatDataGridViewTextBoxColumn.HeaderText = "ID_Obat";
            this.iDObatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDObatDataGridViewTextBoxColumn.Name = "iDObatDataGridViewTextBoxColumn";
            this.iDObatDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaObatDataGridViewTextBoxColumn
            // 
            this.namaObatDataGridViewTextBoxColumn.DataPropertyName = "Nama_Obat";
            this.namaObatDataGridViewTextBoxColumn.HeaderText = "Nama_Obat";
            this.namaObatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaObatDataGridViewTextBoxColumn.Name = "namaObatDataGridViewTextBoxColumn";
            this.namaObatDataGridViewTextBoxColumn.Width = 125;
            // 
            // hargaobatDataGridViewTextBoxColumn
            // 
            this.hargaobatDataGridViewTextBoxColumn.DataPropertyName = "Harga_obat";
            this.hargaobatDataGridViewTextBoxColumn.HeaderText = "Harga_obat";
            this.hargaobatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hargaobatDataGridViewTextBoxColumn.Name = "hargaobatDataGridViewTextBoxColumn";
            this.hargaobatDataGridViewTextBoxColumn.Width = 125;
            // 
            // stokobatDataGridViewTextBoxColumn
            // 
            this.stokobatDataGridViewTextBoxColumn.DataPropertyName = "stok_obat";
            this.stokobatDataGridViewTextBoxColumn.HeaderText = "stok_obat";
            this.stokobatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.stokobatDataGridViewTextBoxColumn.Name = "stokobatDataGridViewTextBoxColumn";
            this.stokobatDataGridViewTextBoxColumn.Width = 125;
            // 
            // jenisobatDataGridViewTextBoxColumn
            // 
            this.jenisobatDataGridViewTextBoxColumn.DataPropertyName = "Jenis_obat";
            this.jenisobatDataGridViewTextBoxColumn.HeaderText = "Jenis_obat";
            this.jenisobatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jenisobatDataGridViewTextBoxColumn.Name = "jenisobatDataGridViewTextBoxColumn";
            this.jenisobatDataGridViewTextBoxColumn.Width = 125;
            // 
            // InputObat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(909, 509);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btninput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtstokobat);
            this.Controls.Add(this.txthargaobat);
            this.Controls.Add(this.jenisobat);
            this.Controls.Add(this.txtnamaobat);
            this.Controls.Add(this.txtidobat);
            this.Controls.Add(this.cbxjenisobat);
            this.Controls.Add(this.stokobat);
            this.Controls.Add(this.hargaobat);
            this.Controls.Add(this.namaobat);
            this.Controls.Add(this.idobat);
            this.Name = "InputObat";
            this.Text = "Input Obat";
            this.Load += new System.EventHandler(this.InputObat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apotikNEWDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ApotikNEWDataSet apotikNEWDataSet;
        private System.Windows.Forms.BindingSource obatBindingSource;
        private ApotikNEWDataSetTableAdapters.ObatTableAdapter obatTableAdapter;
        private System.Windows.Forms.Label idobat;
        private System.Windows.Forms.Label namaobat;
        private System.Windows.Forms.Label hargaobat;
        private System.Windows.Forms.Label stokobat;
        private System.Windows.Forms.ComboBox cbxjenisobat;
        private System.Windows.Forms.TextBox txtidobat;
        private System.Windows.Forms.TextBox txtnamaobat;
        private System.Windows.Forms.Label jenisobat;
        private System.Windows.Forms.TextBox txthargaobat;
        private System.Windows.Forms.TextBox txtstokobat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btninput;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaobatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokobatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisobatDataGridViewTextBoxColumn;
    }
}
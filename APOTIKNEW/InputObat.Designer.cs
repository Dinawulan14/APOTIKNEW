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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxjenisobat = new System.Windows.Forms.ComboBox();
            this.tbidobat = new System.Windows.Forms.TextBox();
            this.tbnamaobat = new System.Windows.Forms.TextBox();
            this.tbjenisobat = new System.Windows.Forms.Label();
            this.tbhargaobat = new System.Windows.Forms.TextBox();
            this.tbstokobat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btninput = new System.Windows.Forms.Button();
            this.buttbtnhapuson2 = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Obat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Obat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Harga Obat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "stok obat";
            // 
            // cbxjenisobat
            // 
            this.cbxjenisobat.FormattingEnabled = true;
            this.cbxjenisobat.Location = new System.Drawing.Point(170, 187);
            this.cbxjenisobat.Name = "cbxjenisobat";
            this.cbxjenisobat.Size = new System.Drawing.Size(121, 24);
            this.cbxjenisobat.TabIndex = 4;
            // 
            // tbidobat
            // 
            this.tbidobat.Location = new System.Drawing.Point(170, 47);
            this.tbidobat.Name = "tbidobat";
            this.tbidobat.Size = new System.Drawing.Size(100, 22);
            this.tbidobat.TabIndex = 5;
            // 
            // tbnamaobat
            // 
            this.tbnamaobat.Location = new System.Drawing.Point(170, 84);
            this.tbnamaobat.Name = "tbnamaobat";
            this.tbnamaobat.Size = new System.Drawing.Size(100, 22);
            this.tbnamaobat.TabIndex = 6;
            // 
            // tbjenisobat
            // 
            this.tbjenisobat.AutoSize = true;
            this.tbjenisobat.Location = new System.Drawing.Point(45, 190);
            this.tbjenisobat.Name = "tbjenisobat";
            this.tbjenisobat.Size = new System.Drawing.Size(69, 16);
            this.tbjenisobat.TabIndex = 7;
            this.tbjenisobat.Text = "Jenis obat";
            // 
            // tbhargaobat
            // 
            this.tbhargaobat.Location = new System.Drawing.Point(170, 119);
            this.tbhargaobat.Name = "tbhargaobat";
            this.tbhargaobat.Size = new System.Drawing.Size(100, 22);
            this.tbhargaobat.TabIndex = 8;
            // 
            // tbstokobat
            // 
            this.tbstokobat.Location = new System.Drawing.Point(170, 156);
            this.tbstokobat.Name = "tbstokobat";
            this.tbstokobat.Size = new System.Drawing.Size(100, 22);
            this.tbstokobat.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Stencil", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(314, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Form Data Obat";
            // 
            // btninput
            // 
            this.btninput.Location = new System.Drawing.Point(48, 248);
            this.btninput.Name = "btninput";
            this.btninput.Size = new System.Drawing.Size(75, 23);
            this.btninput.TabIndex = 11;
            this.btninput.Text = "INPUT";
            this.btninput.UseVisualStyleBackColor = true;
            // 
            // buttbtnhapuson2
            // 
            this.buttbtnhapuson2.Location = new System.Drawing.Point(170, 247);
            this.buttbtnhapuson2.Name = "buttbtnhapuson2";
            this.buttbtnhapuson2.Size = new System.Drawing.Size(75, 23);
            this.buttbtnhapuson2.TabIndex = 12;
            this.buttbtnhapuson2.Text = "HAPUS";
            this.buttbtnhapuson2.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(300, 247);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(75, 23);
            this.btnedit.TabIndex = 13;
            this.btnedit.Text = "EDIT";
            this.btnedit.UseVisualStyleBackColor = true;
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
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.buttbtnhapuson2);
            this.Controls.Add(this.btninput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbstokobat);
            this.Controls.Add(this.tbhargaobat);
            this.Controls.Add(this.tbjenisobat);
            this.Controls.Add(this.tbnamaobat);
            this.Controls.Add(this.tbidobat);
            this.Controls.Add(this.cbxjenisobat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputObat";
            this.Text = "Data Obat";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxjenisobat;
        private System.Windows.Forms.TextBox tbidobat;
        private System.Windows.Forms.TextBox tbnamaobat;
        private System.Windows.Forms.Label tbjenisobat;
        private System.Windows.Forms.TextBox tbhargaobat;
        private System.Windows.Forms.TextBox tbstokobat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btninput;
        private System.Windows.Forms.Button buttbtnhapuson2;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaObatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaobatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokobatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenisobatDataGridViewTextBoxColumn;
    }
}
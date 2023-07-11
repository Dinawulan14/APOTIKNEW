using System;

namespace APOTIKNEW
{
    partial class DataPelanggan
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
            this.label1 = new System.Windows.Forms.Label();
            this.idpelanggan = new System.Windows.Forms.Label();
            this.pelangganBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apotikNEWDataSet1 = new APOTIKNEW.ApotikNEWDataSet1();
            this.pelangganTableAdapter = new APOTIKNEW.ApotikNEWDataSet1TableAdapters.PelangganTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtidpelanggan = new System.Windows.Forms.TextBox();
            this.txtnamapelanggan = new System.Windows.Forms.TextBox();
            this.txtalamatpelanggan = new System.Windows.Forms.TextBox();
            this.cbxjeniskelamin = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jeniskelaminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatPelangganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apotikNEWDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Pelanggan";
            // 
            // idpelanggan
            // 
            this.idpelanggan.Location = new System.Drawing.Point(0, 0);
            this.idpelanggan.Name = "idpelanggan";
            this.idpelanggan.Size = new System.Drawing.Size(100, 23);
            this.idpelanggan.TabIndex = 13;
            // 
            // pelangganBindingSource
            // 
            this.pelangganBindingSource.DataMember = "Pelanggan";
            this.pelangganBindingSource.DataSource = this.apotikNEWDataSet1;
            // 
            // apotikNEWDataSet1
            // 
            this.apotikNEWDataSet1.DataSetName = "ApotikNEWDataSet1";
            this.apotikNEWDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pelangganTableAdapter
            // 
            this.pelangganTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "ID Pelanggan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nama Pelanggan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "jenis kelamin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Alamat Pelanggan";
            // 
            // txtidpelanggan
            // 
            this.txtidpelanggan.Location = new System.Drawing.Point(188, 100);
            this.txtidpelanggan.Name = "txtidpelanggan";
            this.txtidpelanggan.Size = new System.Drawing.Size(100, 22);
            this.txtidpelanggan.TabIndex = 18;
            // 
            // txtnamapelanggan
            // 
            this.txtnamapelanggan.Location = new System.Drawing.Point(188, 148);
            this.txtnamapelanggan.Name = "txtnamapelanggan";
            this.txtnamapelanggan.Size = new System.Drawing.Size(100, 22);
            this.txtnamapelanggan.TabIndex = 19;
            // 
            // txtalamatpelanggan
            // 
            this.txtalamatpelanggan.Location = new System.Drawing.Point(188, 256);
            this.txtalamatpelanggan.Name = "txtalamatpelanggan";
            this.txtalamatpelanggan.Size = new System.Drawing.Size(100, 22);
            this.txtalamatpelanggan.TabIndex = 20;
            // 
            // cbxjeniskelamin
            // 
            this.cbxjeniskelamin.AutoCompleteCustomSource.AddRange(new string[] {
            "L",
            "P"});
            this.cbxjeniskelamin.FormattingEnabled = true;
            this.cbxjeniskelamin.Location = new System.Drawing.Point(188, 204);
            this.cbxjeniskelamin.Name = "cbxjeniskelamin";
            this.cbxjeniskelamin.Size = new System.Drawing.Size(121, 24);
            this.cbxjeniskelamin.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPelangganDataGridViewTextBoxColumn,
            this.namaPelangganDataGridViewTextBoxColumn,
            this.jeniskelaminDataGridViewTextBoxColumn,
            this.alamatPelangganDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pelangganBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(229, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(596, 150);
            this.dataGridView1.TabIndex = 22;
            // 
            // iDPelangganDataGridViewTextBoxColumn
            // 
            this.iDPelangganDataGridViewTextBoxColumn.DataPropertyName = "ID_Pelanggan";
            this.iDPelangganDataGridViewTextBoxColumn.HeaderText = "ID_Pelanggan";
            this.iDPelangganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPelangganDataGridViewTextBoxColumn.Name = "iDPelangganDataGridViewTextBoxColumn";
            this.iDPelangganDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaPelangganDataGridViewTextBoxColumn
            // 
            this.namaPelangganDataGridViewTextBoxColumn.DataPropertyName = "Nama_Pelanggan";
            this.namaPelangganDataGridViewTextBoxColumn.HeaderText = "Nama_Pelanggan";
            this.namaPelangganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaPelangganDataGridViewTextBoxColumn.Name = "namaPelangganDataGridViewTextBoxColumn";
            this.namaPelangganDataGridViewTextBoxColumn.Width = 125;
            // 
            // jeniskelaminDataGridViewTextBoxColumn
            // 
            this.jeniskelaminDataGridViewTextBoxColumn.DataPropertyName = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.HeaderText = "jenis_kelamin";
            this.jeniskelaminDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jeniskelaminDataGridViewTextBoxColumn.Name = "jeniskelaminDataGridViewTextBoxColumn";
            this.jeniskelaminDataGridViewTextBoxColumn.Width = 125;
            // 
            // alamatPelangganDataGridViewTextBoxColumn
            // 
            this.alamatPelangganDataGridViewTextBoxColumn.DataPropertyName = "Alamat_Pelanggan";
            this.alamatPelangganDataGridViewTextBoxColumn.HeaderText = "Alamat_Pelanggan";
            this.alamatPelangganDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alamatPelangganDataGridViewTextBoxColumn.Name = "alamatPelangganDataGridViewTextBoxColumn";
            this.alamatPelangganDataGridViewTextBoxColumn.Width = 125;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(64, 342);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 23;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            // 
            // DataPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(972, 450);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbxjeniskelamin);
            this.Controls.Add(this.txtalamatpelanggan);
            this.Controls.Add(this.txtnamapelanggan);
            this.Controls.Add(this.txtidpelanggan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idpelanggan);
            this.Controls.Add(this.label1);
            this.Name = "DataPelanggan";
            this.Text = "Data Pelanggan";
            this.Load += new System.EventHandler(this.DataPelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pelangganBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apotikNEWDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label idpelanggan;
        private ApotikNEWDataSet1 apotikNEWDataSet1;
        private System.Windows.Forms.BindingSource pelangganBindingSource;
        private ApotikNEWDataSet1TableAdapters.PelangganTableAdapter pelangganTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtidpelanggan;
        private System.Windows.Forms.TextBox txtnamapelanggan;
        private System.Windows.Forms.TextBox txtalamatpelanggan;
        private System.Windows.Forms.ComboBox cbxjeniskelamin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jeniskelaminDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatPelangganDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnsave;
    }
}
﻿namespace APOTIKNEW
{
    partial class DataMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataMaster));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.inputObatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataPengelolaanStokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputObatToolStripMenuItem,
            this.dataPelangganToolStripMenuItem,
            this.dataPengelolaanStokToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(100, 24);
            this.toolStripDropDownButton1.Text = "DataMaster";
            // 
            // inputObatToolStripMenuItem
            // 
            this.inputObatToolStripMenuItem.Name = "inputObatToolStripMenuItem";
            this.inputObatToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.inputObatToolStripMenuItem.Text = "InputObat";
            this.inputObatToolStripMenuItem.Click += new System.EventHandler(this.inputObatToolStripMenuItem_Click);
            // 
            // dataPelangganToolStripMenuItem
            // 
            this.dataPelangganToolStripMenuItem.Name = "dataPelangganToolStripMenuItem";
            this.dataPelangganToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.dataPelangganToolStripMenuItem.Text = "DataPelanggan";
            this.dataPelangganToolStripMenuItem.Click += new System.EventHandler(this.dataPelangganToolStripMenuItem_Click);
            // 
            // dataPengelolaanStokToolStripMenuItem
            // 
            this.dataPengelolaanStokToolStripMenuItem.Name = "dataPengelolaanStokToolStripMenuItem";
            this.dataPengelolaanStokToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.dataPengelolaanStokToolStripMenuItem.Text = "DataPengelolaanStok";
            this.dataPengelolaanStokToolStripMenuItem.Click += new System.EventHandler(this.dataPengelolaanStokToolStripMenuItem_Click);
            // 
            // DataMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Name = "DataMaster";
            this.Text = "DataMaster";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem inputObatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPelangganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataPengelolaanStokToolStripMenuItem;
    }
}
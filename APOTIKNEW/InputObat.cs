using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace APOTIKNEW
{
    public partial class InputObat : Form
    {
        public InputObat()
        {
            InitializeComponent();
        }  

        private void label1_Click(object sender, EventArgs e)
        {
            double IDObat = Convert.ToDouble(txtidobat.Text);
            double NamaObat = Convert.ToDouble(txtnamaobat.Text);
            double HargaObat = Convert.ToDouble(txthargaobat.Text);
            double stokobat = Convert.ToDouble(txtstokobat.Text);
            double JenisObat = Convert.ToDouble(jenisobat.Text);
        }
        private void InputObat_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtidobat.Text, txtnamaobat.Text, txthargaobat.Text, txtstokobat.Text, cbxjenisobat.Text);
            txtidobat.Clear();
            txtnamaobat.Clear();
            txthargaobat.Clear();
            cbxjenisobat.Text = "";
        }
        private void cbxjensisobat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxjenisobat.Text == "Jenis Obat")
            {
                cbxjenisobat.Items.Clear();
                cbxjenisobat.Items.Add("Tablet");
                cbxjenisobat.Items.Add("Kapsul");
                cbxjenisobat.Items.Add("Sirup");
            }
        }

        private void btninput_Click(object sender, EventArgs e)
        {
            string idobat = txtidobat.Text;
            string namaobat = txtnamaobat.Text;
            string hargaobat = txthargaobat.Text;
            string stokobat = txtstokobat.Text;
            string jenisobat = cbxjenisobat.Text;

            if (idobat == "")
            {
                MessageBox.Show("Masukkan idobat ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (namaobat == "")
            {
                MessageBox.Show("Masukkan namaobat ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (hargaobat == "")
            {
                MessageBox.Show("Masukkan hargaobat ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (stokobat == "")
            {
                MessageBox.Show("Masukkan stokobat ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (jenisobat == "")
                MessageBox.Show("Masukkan jenisobat ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void InputObat_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataMaster fo = new DataMaster();
            fo.Show();
            this.Hide();
        }
    }
    }

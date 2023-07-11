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
    public partial class DataPelanggan : Form
    {
        public DataPelanggan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            double IDPelanggan = Convert.ToDouble(txtidpelanggan.Text);
            double namaPelanggan = Convert.ToDouble(txtnamapelanggan.Text);
            double jenisKelamin = Convert.ToDouble(cbxjeniskelamin.Text);
            double alamatPelanggan = Convert.ToDouble(txtalamatpelanggan.Text);
        }

        private void DataPelanggan_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(txtidpelanggan.Text, txtnamapelanggan.Text, cbxjeniskelamin.Text, txtalamatpelanggan);
            txtidpelanggan.Clear();
            txtnamapelanggan.Clear();
            txtalamatpelanggan.Clear();
            cbxjeniskelamin.Text = "";
        } 
        private void cbxjeniskelamin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxjeniskelamin.Text == "Jenis Kelamin")
            {
                cbxjeniskelamin.Items.Clear();
                cbxjeniskelamin.Items.Add("L");
                cbxjeniskelamin.Items.Add("P");
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            string idPelanggan = txtidpelanggan.Text;
            string namaPelangan = txtnamapelanggan.Text;
            string jenisKelamin = cbxjeniskelamin.Text;
            string alamatPelanggan = txtalamatpelanggan.Text;
            if (idPelanggan == "")
            {
                MessageBox.Show("Masukkan Id Pelanggan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (namaPelangan == "")
            {
                MessageBox.Show("Masukkan nama pelanggan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (jenisKelamin == "")
            {
                MessageBox.Show("Masukkan jeniskelamin", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (alamatPelanggan == "")
            {
                MessageBox.Show("Masukkan alamat pelanggan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
       
        }
    }
}

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
    public partial class DataPengelolaanStok : Form
    {
        public DataPengelolaanStok()
        {
            InitializeComponent();

        }

        private void refreshform()
        {
            throw new NotImplementedException();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            double Idapoteker = Convert.ToDouble(txtIdapoteker.Text);
            double Namaapoteker = Convert.ToDouble(txtnamaapoteker.Text);
            double jeniskelamin = Convert.ToDouble(cbxjeniskelamin.Text);
            double nohp = Convert.ToDouble(txtnohp.Text);
            double alamatapoteker = Convert.ToDouble(txtalamatapoteker.Text);
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
            double idkaryawan = Convert.ToDouble(txtidkaryawan.Text);
            double namakaryawan = Convert.ToDouble(txtnamakaryawan.Text);
            double noohp = Convert.ToDouble(txtnoohp.Text);
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            double idsupplier = Convert.ToDouble(txtidsupplier);
            double alamatsupplier = Convert.ToDouble(txtalamatsupplier);
            double nohpp = Convert.ToDouble(txtnohpp.Text);
        }

        private void cbxjeniskelamin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxjeniskelamin.Text == "Jenis Kelamin")
            {
                cbxjeniskelamin.Items.Clear();
                cbxjeniskelamin.Items.Add("L");
                cbxjeniskelamin.Items.Add("P");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            double Idapoteker = Convert.ToDouble(txtIdapoteker.Text);
            double Namaapoteker = Convert.ToDouble(txtnamaapoteker.Text);
            double jeniskelamin = Convert.ToDouble(cbxjeniskelamin.Text);
            double nohp = Convert.ToDouble(txtnohp.Text);
            double alamatapoteker = Convert.ToDouble(txtalamatapoteker.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            double idkaryawan = Convert.ToDouble(txtidkaryawan.Text);
            double namakaryawan = Convert.ToDouble(txtnamakaryawan.Text);
            double noohp = Convert.ToDouble(txtnoohp.Text);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            double idsupplier = Convert.ToDouble(txtidsupplier);
            double alamatsupplier = Convert.ToDouble(txtalamatsupplier);
            double nohpp = Convert.ToDouble(txtnohpp.Text);
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            string idapoteker = txtIdapoteker.Text;
            string namaapoteker = txtnamaapoteker.Text;
            string jeniskelamin = cbxjeniskelamin.Text;
            string nohp = txtnohp.Text;
            string alamatapoteker = txtalamatapoteker.Text;
            string idkaryawan = txtidkaryawan.Text;
            string namakaryawan = txtidkaryawan.Text;
            string noohp = txtnoohp.Text;
            string idsupplier = txtidsupplier.Text;
            string alamatsupplier = txtalamatsupplier.Text;
            string nohpp = txtnohpp.Text;

            if (idapoteker == "")
            {
                MessageBox.Show("Masukkan idapoteker ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (namaapoteker == "")
            {
                MessageBox.Show("Masukkan namapoteker ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (jeniskelamin == "")
            {
                MessageBox.Show("Masukkan jeniskelamin ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nohp == "")
            {
                MessageBox.Show("Masukkan nohp ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (alamatapoteker == "")
            {
                MessageBox.Show("Masukkan alamatapoteker ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (idkaryawan == "")
            {
                MessageBox.Show("Masukkan idkaryawan ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (namakaryawan == "")
            {
                MessageBox.Show("Masukkan namakaryawan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (noohp == "")
            {
                MessageBox.Show("Masukkan noohp ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (idsupplier == "")
            {
                MessageBox.Show("Masukkan idsupplier ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (alamatsupplier == "")
            {
                MessageBox.Show("Masukkan alamatsupplier ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (nohpp == "")
            {
                MessageBox.Show("Masukkan nohpp ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            }
            }
    }
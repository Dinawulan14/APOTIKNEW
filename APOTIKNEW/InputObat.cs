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

        private void button1_Click(object sender, EventArgs e)
        {
            double IDObat = Convert.ToDouble(tbidobat.Text);
            double NamaObat = Convert.ToDouble(tbnamaobat.Text);
            double HargaObat = Convert.ToDouble(tbhargaobat.Text);
            double stokobat = Convert.ToDouble(tbstokobat.Text);
            double JenisObat = Convert.ToDouble(tbjenisobat.Text);
        }

        private void InputObat_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(tbidobat.Text, tbnamaobat.Text, tbhargaobat.Text, tbstokobat.Text, cbxjenisobat.Text);
            tbidobat.Clear();
            tbnamaobat.Clear();
            tbhargaobat.Clear();
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
    }
}

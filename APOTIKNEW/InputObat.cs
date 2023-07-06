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
            double stokobat= Convert.ToDouble(tbstokobat.Text);
            double JenisObat = Convert.ToDouble(tbjenisobat.Text);
        }

        private void InputObat_Load(object sender, EventArgs e)
        { 
            // TODO: This line of code loads data into the 'apotikNEWDataSet.Obat' table. You can move, or remove it, as needed.
            this.obatTableAdapter.Fill(this.apotikNEWDataSet.Obat);

        }
    }
}

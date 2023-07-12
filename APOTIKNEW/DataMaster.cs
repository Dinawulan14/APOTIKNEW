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
    public partial class DataMaster : Form
    {
        public DataMaster()
        {
            InitializeComponent();
        }

        private void inputObatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InputObat fm = new InputObat();
            fm.Show();
            this.Hide();
        }

        private void dataPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataPelanggan fo = new DataPelanggan();
            fo.Show();
            this.Hide();
        }

        private void dataPengelolaanStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataPengelolaanStok fr = new DataPengelolaanStok();
            fr.Show();
            this.Hide();
        }
    }
}

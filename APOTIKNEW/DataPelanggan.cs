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

        }

        private void DataPelanggan_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apotikNEWDataSet1.Pelanggan' table. You can move, or remove it, as needed.
            this.pelangganTableAdapter.Fill(this.apotikNEWDataSet1.Pelanggan);

        }
    }
}

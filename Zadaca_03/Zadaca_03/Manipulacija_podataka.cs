using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca_03
{
    public partial class Manipulacija_podataka : Form
    {
        public Manipulacija_podataka()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Manipulacija_podataka_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pI2324_msokser22_DBDataSet.Zdravstveni_podaci' table. You can move, or remove it, as needed.
            this.zdravstveni_podaciTableAdapter.Fill(this.pI2324_msokser22_DBDataSet.Zdravstveni_podaci);

        }
    }
}

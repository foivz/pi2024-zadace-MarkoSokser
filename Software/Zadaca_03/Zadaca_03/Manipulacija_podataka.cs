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
            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                if (dataGridView1.Columns[e.ColumnIndex].Name == "osobnebilješkeDataGridViewTextBoxColumn")
                {
                    dataGridView1.BeginEdit(true);
                }

                
        }

        private void Manipulacija_podataka_Load(object sender, EventArgs e)
        {
           
            this.zdravstveni_podaciTableAdapter.Fill(this.pI2324_msokser22_DBDataSet.Zdravstveni_podaci);

        }

        private void Promjeni_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Contains("terminDataGridViewTextBoxColumn"))
            {
                // Pretvorite postojeći stupac u CalendarColumn
                int colIndex = dataGridView1.Columns["terminDataGridViewTextBoxColumn"].Index;
                dataGridView1.Columns.RemoveAt(colIndex);
                CalendarColumn calendarColumn = new CalendarColumn
                {
                    Name = "terminDataGridViewTextBoxColumn",
                    HeaderText = "Termin",
                    DataPropertyName = "terminDataGridViewTextBoxColumn" // Ako koristite DataBinding
                };
                dataGridView1.Columns.Insert(colIndex, calendarColumn);

                dataGridView1.Columns["terminDataGridViewTextBoxColumn"].ReadOnly = false;
                MessageBox.Show("Uređivanje stupca je aktivno", "Potvrda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        }



        private void Odustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Pohrani_Click(object sender, EventArgs e)
        {

        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
           
        }


    }
}




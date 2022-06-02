using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiakadSederhana.Entitas;

namespace SiakadSederhana
{
    public partial class FormSemester : Form
    {
        public static List<Semester> ListSemester = new List<Semester>();
        private Semester SemesterDiklik = null;
        public FormSemester()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Semester NewSemester= new Semester();
                NewSemester.Nim = "Nim " + i.ToString();
                NewSemester.NamaSemester = "" + i.ToString();
                NewSemester.IdSem= i;

                ListSemester.Add(NewSemester);
            }

            dataGridViewData.DataSource = ListSemester;
        }    

        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nilaiCell = dataGridViewData.Rows[e.RowIndex].Cells[0].Value;

            if (nilaiCell != null)
            {
                var isiCell = nilaiCell.ToString();

                SemesterDiklik = ListSemester.Find(x => x.Nim== isiCell);
            }
        }


        private void buttonTambah_Click_1(object sender, EventArgs e)
        {
            FormTambahSemester FormTambahSem = new FormTambahSemester();
            FormTambahSem.Show();
            FormTambahSem.tambah = true;
            FormTambahSem.buttonHapus.Visible = false;
            
        }

        private void buttonUbah_Click_1(object sender, EventArgs e)
        {
            FormTambahSemester FormTambahSem = new FormTambahSemester();
            FormTambahSem.semesterDipilih = SemesterDiklik;
            FormTambahSem.Show();
            FormTambahSem.tambah = false;
            FormTambahSem.labelTop.Text = "Ubah Semester";
            FormTambahSem.buttonHapus.Visible = false;
        }

        private void buttonHapus_Click_1(object sender, EventArgs e)
        {
            FormTambahSemester FormTambahSem = new FormTambahSemester();
            FormTambahSem.semesterDipilih = SemesterDiklik;
            FormTambahSem.Show();
            FormTambahSem.labelTop.Text = "Hapus Semester";
            FormTambahSem.buttonSimpan.Visible = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = ListSemester;
        }
    }
}

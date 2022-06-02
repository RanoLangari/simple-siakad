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
    public partial class FormNilai : Form
    {
        public static List<Nilai> ListNilai= new List<Nilai>();

        public Nilai NilaiDiKlik = null;
        public FormNilai()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Nilai newNilai= new Nilai();
                newNilai.NIM ="2006080053" +i.ToString();
                newNilai.Mata_Kuliah= "Nama MK " + i.ToString();
                newNilai.Semester = 1 + i;
                newNilai.Nilai_Angka = "8" + i;
                newNilai.Predikat_Nilai = "A";
                ListNilai.Add(newNilai);
                dataGridViewData.DataSource = ListNilai;
            }
        }


        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahNilai NewNilai = new FormTambahNilai();
            NewNilai.Show();
            NewNilai.tambah = true;
            NewNilai.buttonHapus.Visible = false;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormTambahNilai NewNilai = new FormTambahNilai();
            NewNilai.NilaiDipilihh = NilaiDiKlik;
            NewNilai.Show();
            NewNilai.tambah = false;
            NewNilai.labelTambahUbahNilai.Text = "Ubah Nilai";
            NewNilai.buttonHapus.Visible = false;

        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            FormTambahNilai NewNilai = new FormTambahNilai();
            NewNilai.NilaiDipilihh = NilaiDiKlik;
            NewNilai.Show();
            NewNilai.labelTambahUbahNilai.Text = "Hapus Nilai";
            NewNilai.buttonSimpan.Visible = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = ListNilai;
        }

        private void dataGridViewData_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var nilaiCell = dataGridViewData.Rows[e.RowIndex].Cells[0].Value;

            if (nilaiCell != null)
            {
                var isiCell = nilaiCell.ToString();

                NilaiDiKlik = ListNilai.Find(x => x.NIM == isiCell);
            }
        }
    }
}

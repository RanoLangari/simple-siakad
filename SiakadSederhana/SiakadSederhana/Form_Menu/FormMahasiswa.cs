using SiakadSederhana.Entitas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiakadSederhana
{
    public partial class FormMahasiswa : Form
    {
        public static List<Mahasiswa> ListMahasiswa = new List<Mahasiswa>();
        private Mahasiswa MahasiswaDiKlik = null;
        public FormMahasiswa() // constructor
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                Mahasiswa NewMahasiswa = new Mahasiswa();
                NewMahasiswa.Nim = "NIM " + i.ToString();
                NewMahasiswa.Nama = "Nama Mahasiswa " + i.ToString();
                NewMahasiswa.JenisKelamin = "Pria";
                NewMahasiswa.Angkatan = 2020 + i;
                ListMahasiswa.Add(NewMahasiswa);
                dataGridViewData.DataSource = ListMahasiswa;

            }
        }

        private void buttonTambah_Click(object sender, EventArgs e) // event
        {
            FormTambahMahasiswa NewTambahMHS = new FormTambahMahasiswa();
            NewTambahMHS.Show();
            NewTambahMHS.tambah = true;
            NewTambahMHS.buttonHapus.Visible = false;


        }

        public void buttonUbah_Click(object sender, EventArgs e) // event
        { 
            FormTambahMahasiswa NewTambahMHS = new FormTambahMahasiswa();
            NewTambahMHS.MahasiswaDipilih = MahasiswaDiKlik;
            NewTambahMHS.Show();
            NewTambahMHS.labelTambahUbahMHS.Text = "Ubah Mahasiswa";
            NewTambahMHS.buttonHapus.Visible = false;
            
            NewTambahMHS.tambah = false;
        }

        private void buttonHapus_Click(object sender, EventArgs e) // event
        {
            FormTambahMahasiswa NewTambahMHS = new FormTambahMahasiswa();
            NewTambahMHS.MahasiswaDipilih = MahasiswaDiKlik;
            NewTambahMHS.Show();
            NewTambahMHS.labelTambahUbahMHS.Text = "Hapus Mahasiswa";
            NewTambahMHS.button1.Visible = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e) // event
        {
            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = ListMahasiswa;
            
        }

        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e) // event
        {
            var nilaiCell = dataGridViewData.Rows[e.RowIndex].Cells[0].Value;

            if (nilaiCell != null)
            {
                var isiCell = nilaiCell.ToString();
                MahasiswaDiKlik = ListMahasiswa.Find(x => x.Nim == isiCell);
            }
        }

    }
}
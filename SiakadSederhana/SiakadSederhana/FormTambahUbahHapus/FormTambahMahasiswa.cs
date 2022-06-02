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
    public partial class FormTambahMahasiswa : Form
    {
        public Mahasiswa MahasiswaDipilih = null;
        public static List<Mahasiswa> ListMahasiswa = new List<Mahasiswa>();

        public bool tambah = false;
        public FormTambahMahasiswa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tambah == true)
            {
                
                Mahasiswa NewMahasiswa= new Mahasiswa();
                NewMahasiswa.Nim = textBox1.Text;
                NewMahasiswa.Nama= textBox2.Text;
                NewMahasiswa.JenisKelamin = textBox3.Text;
                NewMahasiswa.Angkatan= int.Parse(textBox4.Text);
                if (textBox1.Text.Length != 10)
                {
                    MessageBox.Show("Panjang NIM harus 10 Karakter");
                    return;
                }

                long longNim = 0;

                if (long.TryParse(textBox1.Text, out longNim) == false)
                {
                    MessageBox.Show("NIM harus Angka");
                    return;
                }
                if (textBox2.Text.Length < 3)
                {
                    MessageBox.Show("Nama harus lebih dari 3 karakter!");
                    return;
                }
                else if (textBox2.Text.Length > 50)
                {
                    MessageBox.Show("Nama harus lebih dari 3 karakter!");
                    return;
                }
                if (textBox3.Text != "Pria" && textBox3.Text != "Wanita")
                {
                    MessageBox.Show("Jenis kelamin Harus 'Pria' atau 'Wanita'");
                    return;
                }

                FormMahasiswa.ListMahasiswa.Add(NewMahasiswa);
                MessageBox.Show("Data telah ditambahkan.");
                this.Close();
            }
            else //Tambah == false
            {
                if (MahasiswaDipilih != null)
                {
                    var MahasiswaYangMauDiedit = FormMahasiswa.ListMahasiswa.Find(x => x.Nim== MahasiswaDipilih.Nim);

                    if (MahasiswaYangMauDiedit != null)
                    {
                        MahasiswaYangMauDiedit.Nim= textBox1.Text;
                        MahasiswaYangMauDiedit.Nama= textBox2.Text;
                        MahasiswaYangMauDiedit.JenisKelamin = textBox3.Text;
                        MahasiswaYangMauDiedit.Angkatan = int.Parse(textBox4.Text);
                        if (textBox1.Text.Length != 10)
                        {
                            MessageBox.Show("Panjang NIM harus 10 Karakter");
                            return;
                        }

                        long longNim = 0;

                        if (long.TryParse(textBox1.Text, out longNim) == false)
                        {
                            MessageBox.Show("NIM harus Angka");
                            return;
                        }
                        if (textBox2.Text.Length < 3)
                        {
                            MessageBox.Show("Nama harus lebih dari 3 karakter!");
                            return;
                        }
                        else if (textBox2.Text.Length > 50)
                        {
                            MessageBox.Show("Nama harus lebih dari 3 karakter!");
                            return;
                        }
                        if (textBox3.Text != "Pria" && textBox3.Text != "Wanita")
                        {
                            MessageBox.Show("Jenis kelamin Harus 'Pria' atau 'Wanita'");
                            return;
                        }

                        MessageBox.Show("Data telah diubah.");
                        this.Close();
                    }
                }
            }
        }

        private void FormTambahMahasiswa_Shown(object sender, EventArgs e)
        {
            if (MahasiswaDipilih != null)
            {
                textBox1.Text = MahasiswaDipilih.Nim;
                textBox2.Text = MahasiswaDipilih.Nama;
                textBox3.Text = MahasiswaDipilih.JenisKelamin;
                textBox4.Text = MahasiswaDipilih.Angkatan.ToString();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            
            if (MahasiswaDipilih != null)
            {
                var MahasiswaYangMauDihapus = FormMahasiswa.ListMahasiswa.Find(x => x.Nim == MahasiswaDipilih.Nim);

                if (MahasiswaYangMauDihapus != null)
                {
                    MahasiswaYangMauDihapus.Nim = textBox1.Text;
                    MahasiswaYangMauDihapus.Nama = textBox2.Text;
                    MahasiswaYangMauDihapus.JenisKelamin = textBox3.Text;
                    MahasiswaYangMauDihapus.Angkatan = int.Parse(textBox4.Text);

                    FormMahasiswa.ListMahasiswa.Remove(MahasiswaYangMauDihapus);
                    MessageBox.Show("Data telah dihapus.");

                    this.Close();
                }
            }
        }

       
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


      
    }
}
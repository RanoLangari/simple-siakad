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
    public partial class FormTambahNilai : Form
    {
        public Nilai NilaiDipilihh = null;

        public bool tambah = false;
        public FormTambahNilai()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (tambah == true)
            {
                Nilai NewNilai= new Nilai();
                NewNilai.NIM = textBoxKodeNIm.Text;
                NewNilai.Mata_Kuliah= textBoxNamaMk.Text;
                NewNilai.Semester = int.Parse(textBoxSemester.Text);
                NewNilai.Nilai_Angka = textBoxNilaiAngka.Text;
                NewNilai.Predikat_Nilai = textBoxPredikatNilai.Text;

                FormNilai.ListNilai.Add(NewNilai);
                MessageBox.Show("Data telah ditambahkan.");
                

                this.Close();
            }
            else //Tambah == false
            {
                if (NilaiDipilihh != null)
                {
                    var NilaiyangMauDiEdit = FormNilai.ListNilai.Find(x => x.NIM== NilaiDipilihh.NIM);

                    if (NilaiyangMauDiEdit!= null)
                    {
                        NilaiyangMauDiEdit.NIM= textBoxKodeNIm.Text;
                        NilaiyangMauDiEdit.Mata_Kuliah= textBoxNamaMk.Text;
                        NilaiyangMauDiEdit.Semester= int.Parse(textBoxPredikatNilai.Text);
                        NilaiyangMauDiEdit.Nilai_Angka = textBoxNilaiAngka.Text;
                        NilaiyangMauDiEdit.Predikat_Nilai = textBoxPredikatNilai.Text;

                        MessageBox.Show("Data telah diubah.");

                        this.Close();
                    }
                }
            }
        }

        private void FormTambahNilai_Shown(object sender, EventArgs e)
        {
            if (NilaiDipilihh != null)
            {
                textBoxKodeNIm.Text = NilaiDipilihh.NIM.ToString();
                textBoxNamaMk.Text = NilaiDipilihh.Mata_Kuliah;
                textBoxSemester.Text = NilaiDipilihh.Semester.ToString();
                textBoxNilaiAngka.Text = NilaiDipilihh.Nilai_Angka;
                textBoxPredikatNilai.Text = NilaiDipilihh.Predikat_Nilai;
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (NilaiDipilihh != null)
            {
                var NilaiyangMauDiHapus = FormNilai.ListNilai.Find(x => x.NIM == NilaiDipilihh.NIM);
                if (NilaiyangMauDiHapus != null)
                {
                    NilaiyangMauDiHapus.NIM = textBoxKodeNIm.Text;
                    NilaiyangMauDiHapus.Mata_Kuliah = textBoxNamaMk.Text;
                    NilaiyangMauDiHapus.Semester= int.Parse(textBoxSemester.Text);
                    NilaiyangMauDiHapus.Nilai_Angka = textBoxNilaiAngka.Text;
                    NilaiyangMauDiHapus.Predikat_Nilai = textBoxPredikatNilai.Text;
                    FormNilai.ListNilai.Remove(NilaiyangMauDiHapus);
                    MessageBox.Show("Data telah Dihapus");
                    this.Close();
                }
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FormTambahSemester : Form
    {
        public Semester semesterDipilih = null;

        public bool tambah = false;

        public FormTambahSemester()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (tambah == true)
            {
                Semester NewSemester= new Semester();
                NewSemester.Nim= textBoxNIM.Text;
                NewSemester.NamaSemester= textBoxNamaSem.Text;
                NewSemester.IdSem= int.Parse(textBoxIdSem.Text);
                FormSemester.ListSemester.Add(NewSemester);
                MessageBox.Show("Data telah ditambahkan.");

                this.Close();
            }
            else //Tambah == false
            {
                if (semesterDipilih != null)
                {
                    var SemesterYangMauDiedit= FormSemester.ListSemester.Find(x => x.Nim== semesterDipilih.Nim);

                    if (SemesterYangMauDiedit != null)
                    {
                        SemesterYangMauDiedit.Nim= textBoxNIM.Text;
                        SemesterYangMauDiedit.NamaSemester= textBoxNamaSem.Text;
                        SemesterYangMauDiedit.IdSem= int.Parse(textBoxIdSem.Text);

                        MessageBox.Show("Data telah diubah.");

                        this.Close();
                    }
                }
            }
        }

        private void FormTambahSemester_Shown(object sender, EventArgs e)
        {
            if (semesterDipilih != null)
            {
                textBoxNIM.Text = semesterDipilih.Nim;
                textBoxNamaSem.Text = semesterDipilih.NamaSemester;
                textBoxIdSem.Text = semesterDipilih.IdSem.ToString();
            
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (semesterDipilih != null)
            {
                var SemesterYangMauDiHapus = FormSemester.ListSemester.Find(x => x.Nim == semesterDipilih.Nim);

                if (SemesterYangMauDiHapus != null)
                {
                    SemesterYangMauDiHapus.Nim = textBoxNIM.Text;
                    SemesterYangMauDiHapus.NamaSemester = textBoxNamaSem.Text;
                    SemesterYangMauDiHapus.IdSem = int.Parse(textBoxIdSem.Text);
                    FormSemester.ListSemester.Remove(SemesterYangMauDiHapus);
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using SiakadSederhana;

namespace UAS_SIAKAD
{
    public partial class MainForm : Form
    {
        private IconButton CurrentButton;
        private Panel LeftBorderBtn;

       
        public MainForm()
        {
            InitializeComponent();
            LeftBorderBtn = new Panel();
            LeftBorderBtn.Size = new Size(7, 60);
            panel1.Controls.Add(LeftBorderBtn);
    
        }
        private struct RGBColors // structs
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);


        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                CurrentButton = (IconButton)senderBtn;
                CurrentButton.BackColor = Color.FromArgb(37, 36, 81);
                CurrentButton.ForeColor = color;
                CurrentButton.TextAlign = ContentAlignment.MiddleCenter;
                CurrentButton.IconColor = color;
                CurrentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrentButton.ImageAlign = ContentAlignment.MiddleRight;
                LeftBorderBtn.BackColor = color;
                LeftBorderBtn.Location = new Point(0, CurrentButton.Location.Y);
                LeftBorderBtn.Visible = true;
                LeftBorderBtn.BringToFront();
                //icon current child form
                IconCurrentChild.IconChar = CurrentButton.IconChar;
                IconCurrentChild.IconColor = color;

                
            }
           
        }
        private void DisableButton()
        {
            if (CurrentButton != null)
            {
                CurrentButton.BackColor = Color.FromArgb(31, 30, 68);
                CurrentButton.ForeColor = Color.Gainsboro;
                CurrentButton.TextAlign = ContentAlignment.MiddleLeft;
                CurrentButton.IconColor = Color.Gainsboro;
                CurrentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        
        

       

        private void Mahasiswa_Icon_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            openChildForm(new FormMahasiswa());
            LABEL_SIAKAD.Visible = false;
            pictureBoxSiakad.Visible = false;            
        }

        private void MataKuliah_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            openChildForm(new FormMataKuliah());
            LABEL_SIAKAD.Visible = false;
            pictureBoxSiakad.Visible = false;
        }

        private void Semester_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            openChildForm(new FormSemester());
            LABEL_SIAKAD.Visible = false;
            pictureBoxSiakad.Visible = false;
        }

        public void Nilai_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            openChildForm(new FormNilai());
            LABEL_SIAKAD.Visible = false;
            pictureBoxSiakad.Visible = false;
        }


        private Form activeform = null;
        private void openChildForm(Form ChildForm)
        {
            if (activeform != null)
               activeform.Close();
            activeform = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            PanelDesktop.Controls.Add(ChildForm);
            PanelDesktop.Tag = ChildForm;
            ChildForm.Show();
            label1.Text = ChildForm.Text;
        }

        private void ButtonKeluar_Click(object sender, EventArgs e)
        {
            LABEL_SIAKAD.Visible = false;
            ActivateButton(sender, RGBColors.color1);
            if (MessageBox.Show("Kamu Yakin?", "Konfirmasi Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

      
    }
}

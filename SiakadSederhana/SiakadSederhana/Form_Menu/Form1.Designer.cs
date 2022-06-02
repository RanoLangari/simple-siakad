
namespace UAS_SIAKAD
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonKeluar = new FontAwesome.Sharp.IconButton();
            this.Nilai = new FontAwesome.Sharp.IconButton();
            this.Semester = new FontAwesome.Sharp.IconButton();
            this.MataKuliah = new FontAwesome.Sharp.IconButton();
            this.Mahasiswa_Icon = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.IconCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PanelDesktop = new System.Windows.Forms.Panel();
            this.pictureBoxSiakad = new System.Windows.Forms.PictureBox();
            this.LABEL_SIAKAD = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChild)).BeginInit();
            this.PanelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSiakad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.ButtonKeluar);
            this.panel1.Controls.Add(this.Nilai);
            this.panel1.Controls.Add(this.Semester);
            this.panel1.Controls.Add(this.MataKuliah);
            this.panel1.Controls.Add(this.Mahasiswa_Icon);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 491);
            this.panel1.TabIndex = 0;
            // 
            // ButtonKeluar
            // 
            this.ButtonKeluar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.ButtonKeluar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonKeluar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonKeluar.FlatAppearance.BorderSize = 0;
            this.ButtonKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonKeluar.ForeColor = System.Drawing.Color.Gainsboro;
            this.ButtonKeluar.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.ButtonKeluar.IconColor = System.Drawing.Color.Gainsboro;
            this.ButtonKeluar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ButtonKeluar.IconSize = 32;
            this.ButtonKeluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonKeluar.Location = new System.Drawing.Point(0, 439);
            this.ButtonKeluar.Name = "ButtonKeluar";
            this.ButtonKeluar.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.ButtonKeluar.Size = new System.Drawing.Size(189, 52);
            this.ButtonKeluar.TabIndex = 6;
            this.ButtonKeluar.Text = "Keluar";
            this.ButtonKeluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ButtonKeluar.UseVisualStyleBackColor = false;
            this.ButtonKeluar.Click += new System.EventHandler(this.ButtonKeluar_Click);
            // 
            // Nilai
            // 
            this.Nilai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Nilai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nilai.Dock = System.Windows.Forms.DockStyle.Top;
            this.Nilai.FlatAppearance.BorderSize = 0;
            this.Nilai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nilai.ForeColor = System.Drawing.Color.Gainsboro;
            this.Nilai.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleUp;
            this.Nilai.IconColor = System.Drawing.Color.Gainsboro;
            this.Nilai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Nilai.IconSize = 32;
            this.Nilai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nilai.Location = new System.Drawing.Point(0, 277);
            this.Nilai.Name = "Nilai";
            this.Nilai.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.Nilai.Size = new System.Drawing.Size(189, 52);
            this.Nilai.TabIndex = 5;
            this.Nilai.Text = "Nilai";
            this.Nilai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Nilai.UseVisualStyleBackColor = false;
            this.Nilai.Click += new System.EventHandler(this.Nilai_Click);
            // 
            // Semester
            // 
            this.Semester.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Semester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Semester.Dock = System.Windows.Forms.DockStyle.Top;
            this.Semester.FlatAppearance.BorderSize = 0;
            this.Semester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Semester.ForeColor = System.Drawing.Color.Gainsboro;
            this.Semester.IconChar = FontAwesome.Sharp.IconChar.CalendarTimes;
            this.Semester.IconColor = System.Drawing.Color.Gainsboro;
            this.Semester.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Semester.IconSize = 32;
            this.Semester.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Semester.Location = new System.Drawing.Point(0, 225);
            this.Semester.Name = "Semester";
            this.Semester.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.Semester.Size = new System.Drawing.Size(189, 52);
            this.Semester.TabIndex = 4;
            this.Semester.Text = "Semester";
            this.Semester.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Semester.UseVisualStyleBackColor = false;
            this.Semester.Click += new System.EventHandler(this.Semester_Click);
            // 
            // MataKuliah
            // 
            this.MataKuliah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.MataKuliah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MataKuliah.Dock = System.Windows.Forms.DockStyle.Top;
            this.MataKuliah.FlatAppearance.BorderSize = 0;
            this.MataKuliah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MataKuliah.ForeColor = System.Drawing.Color.Gainsboro;
            this.MataKuliah.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.MataKuliah.IconColor = System.Drawing.Color.Gainsboro;
            this.MataKuliah.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MataKuliah.IconSize = 32;
            this.MataKuliah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MataKuliah.Location = new System.Drawing.Point(0, 173);
            this.MataKuliah.Name = "MataKuliah";
            this.MataKuliah.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.MataKuliah.Size = new System.Drawing.Size(189, 52);
            this.MataKuliah.TabIndex = 3;
            this.MataKuliah.Text = "Mata Kuliah";
            this.MataKuliah.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MataKuliah.UseVisualStyleBackColor = false;
            this.MataKuliah.Click += new System.EventHandler(this.MataKuliah_Click);
            // 
            // Mahasiswa_Icon
            // 
            this.Mahasiswa_Icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.Mahasiswa_Icon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Mahasiswa_Icon.Dock = System.Windows.Forms.DockStyle.Top;
            this.Mahasiswa_Icon.FlatAppearance.BorderSize = 0;
            this.Mahasiswa_Icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mahasiswa_Icon.ForeColor = System.Drawing.Color.Gainsboro;
            this.Mahasiswa_Icon.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.Mahasiswa_Icon.IconColor = System.Drawing.Color.Gainsboro;
            this.Mahasiswa_Icon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Mahasiswa_Icon.IconSize = 32;
            this.Mahasiswa_Icon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Mahasiswa_Icon.Location = new System.Drawing.Point(0, 121);
            this.Mahasiswa_Icon.Name = "Mahasiswa_Icon";
            this.Mahasiswa_Icon.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.Mahasiswa_Icon.Size = new System.Drawing.Size(189, 52);
            this.Mahasiswa_Icon.TabIndex = 2;
            this.Mahasiswa_Icon.Text = "Mahasiswa";
            this.Mahasiswa_Icon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Mahasiswa_Icon.UseVisualStyleBackColor = false;
            this.Mahasiswa_Icon.Click += new System.EventHandler(this.Mahasiswa_Icon_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(189, 121);
            this.panel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 121);
            this.label2.TabIndex = 0;
            this.label2.Text = "Siakad App";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.IconCurrentChild);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(189, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(721, 50);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(38, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Home";
            // 
            // IconCurrentChild
            // 
            this.IconCurrentChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.IconCurrentChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.IconCurrentChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentChild.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.IconCurrentChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentChild.IconSize = 27;
            this.IconCurrentChild.Location = new System.Drawing.Point(5, 3);
            this.IconCurrentChild.Name = "IconCurrentChild";
            this.IconCurrentChild.Size = new System.Drawing.Size(27, 28);
            this.IconCurrentChild.TabIndex = 0;
            this.IconCurrentChild.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(189, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(721, 10);
            this.panel4.TabIndex = 2;
            // 
            // PanelDesktop
            // 
            this.PanelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.PanelDesktop.Controls.Add(this.pictureBoxSiakad);
            this.PanelDesktop.Controls.Add(this.LABEL_SIAKAD);
            this.PanelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelDesktop.Location = new System.Drawing.Point(189, 60);
            this.PanelDesktop.Name = "PanelDesktop";
            this.PanelDesktop.Size = new System.Drawing.Size(721, 431);
            this.PanelDesktop.TabIndex = 3;
            // 
            // pictureBoxSiakad
            // 
            this.pictureBoxSiakad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxSiakad.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSiakad.Image")));
            this.pictureBoxSiakad.Location = new System.Drawing.Point(107, -52);
            this.pictureBoxSiakad.Name = "pictureBoxSiakad";
            this.pictureBoxSiakad.Size = new System.Drawing.Size(467, 389);
            this.pictureBoxSiakad.TabIndex = 1;
            this.pictureBoxSiakad.TabStop = false;
            // 
            // LABEL_SIAKAD
            // 
            this.LABEL_SIAKAD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LABEL_SIAKAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_SIAKAD.ForeColor = System.Drawing.Color.Gainsboro;
            this.LABEL_SIAKAD.Location = new System.Drawing.Point(57, 327);
            this.LABEL_SIAKAD.Name = "LABEL_SIAKAD";
            this.LABEL_SIAKAD.Size = new System.Drawing.Size(568, 73);
            this.LABEL_SIAKAD.TabIndex = 0;
            this.LABEL_SIAKAD.Text = "Sistem Informasi Akademik";
            this.LABEL_SIAKAD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(910, 491);
            this.Controls.Add(this.PanelDesktop);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SIAKAD LITE";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChild)).EndInit();
            this.PanelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSiakad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Nilai;
        private FontAwesome.Sharp.IconButton Semester;
        private FontAwesome.Sharp.IconButton MataKuliah;
        private FontAwesome.Sharp.IconButton Mahasiswa_Icon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel PanelDesktop;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton ButtonKeluar;
        private System.Windows.Forms.Label LABEL_SIAKAD;
        public System.Windows.Forms.PictureBox pictureBoxSiakad;
    }
}


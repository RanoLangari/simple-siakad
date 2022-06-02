
namespace SiakadSederhana
{
    partial class FormTambahSemester
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.buttonSimpan = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNIM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxIdSem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTop = new System.Windows.Forms.Label();
            this.textBoxNamaSem = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.buttonHapus);
            this.panel2.Controls.Add(this.buttonSimpan);
            this.panel2.Controls.Add(this.buttonClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 249);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 38);
            this.panel2.TabIndex = 14;
            // 
            // buttonHapus
            // 
            this.buttonHapus.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHapus.Location = new System.Drawing.Point(269, 0);
            this.buttonHapus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(92, 38);
            this.buttonHapus.TabIndex = 5;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // buttonSimpan
            // 
            this.buttonSimpan.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSimpan.Location = new System.Drawing.Point(361, 0);
            this.buttonSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSimpan.Name = "buttonSimpan";
            this.buttonSimpan.Size = new System.Drawing.Size(92, 38);
            this.buttonSimpan.TabIndex = 4;
            this.buttonSimpan.Text = "Simpan";
            this.buttonSimpan.UseVisualStyleBackColor = true;
            this.buttonSimpan.Click += new System.EventHandler(this.buttonSimpan_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.Location = new System.Drawing.Point(453, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(92, 38);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nama Semester";
            // 
            // textBoxNIM
            // 
            this.textBoxNIM.Location = new System.Drawing.Point(129, 65);
            this.textBoxNIM.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNIM.Name = "textBoxNIM";
            this.textBoxNIM.Size = new System.Drawing.Size(249, 20);
            this.textBoxNIM.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "NIM";
            // 
            // textBoxIdSem
            // 
            this.textBoxIdSem.Location = new System.Drawing.Point(129, 131);
            this.textBoxIdSem.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIdSem.Name = "textBoxIdSem";
            this.textBoxIdSem.Size = new System.Drawing.Size(249, 20);
            this.textBoxIdSem.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "IdSemester";
            // 
            // labelTop
            // 
            this.labelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTop.Location = new System.Drawing.Point(0, 0);
            this.labelTop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTop.Name = "labelTop";
            this.labelTop.Size = new System.Drawing.Size(545, 39);
            this.labelTop.TabIndex = 15;
            this.labelTop.Text = "Tambah Semester";
            this.labelTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNamaSem
            // 
            this.textBoxNamaSem.FormattingEnabled = true;
            this.textBoxNamaSem.Items.AddRange(new object[] {
            "Ganjil",
            "Genap"});
            this.textBoxNamaSem.Location = new System.Drawing.Point(129, 98);
            this.textBoxNamaSem.Name = "textBoxNamaSem";
            this.textBoxNamaSem.Size = new System.Drawing.Size(249, 21);
            this.textBoxNamaSem.TabIndex = 18;
            // 
            // FormTambahSemester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 287);
            this.Controls.Add(this.textBoxNamaSem);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNIM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdSem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelTop);
            this.Name = "FormTambahSemester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.FormTambahSemester_Shown);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNIM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIdSem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox textBoxNamaSem;
        public System.Windows.Forms.Button buttonSimpan;
        public System.Windows.Forms.Label labelTop;
        public System.Windows.Forms.Button buttonHapus;
    }
}
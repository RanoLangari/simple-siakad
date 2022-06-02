
namespace SiakadSederhana
{
    partial class FormMahasiswa
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRefresh = new FontAwesome.Sharp.IconButton();
            this.buttonHapus = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonUbah = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonTambah = new FontAwesome.Sharp.IconButton();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.buttonRefresh);
            this.panel1.Controls.Add(this.buttonHapus);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonUbah);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.buttonTambah);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 44);
            this.panel1.TabIndex = 6;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonRefresh.IconChar = FontAwesome.Sharp.IconChar.Retweet;
            this.buttonRefresh.IconColor = System.Drawing.Color.Black;
            this.buttonRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRefresh.IconSize = 27;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRefresh.Location = new System.Drawing.Point(674, 0);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(126, 44);
            this.buttonRefresh.TabIndex = 11;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonHapus.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonHapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonHapus.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.buttonHapus.IconColor = System.Drawing.Color.Black;
            this.buttonHapus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonHapus.IconSize = 27;
            this.buttonHapus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHapus.Location = new System.Drawing.Point(282, 0);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(126, 44);
            this.buttonHapus.TabIndex = 10;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = false;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(267, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 44);
            this.panel2.TabIndex = 12;
            // 
            // buttonUbah
            // 
            this.buttonUbah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonUbah.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonUbah.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.buttonUbah.IconColor = System.Drawing.Color.Black;
            this.buttonUbah.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonUbah.IconSize = 27;
            this.buttonUbah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUbah.Location = new System.Drawing.Point(141, 0);
            this.buttonUbah.Name = "buttonUbah";
            this.buttonUbah.Size = new System.Drawing.Size(126, 44);
            this.buttonUbah.TabIndex = 9;
            this.buttonUbah.Text = "Ubah";
            this.buttonUbah.UseVisualStyleBackColor = false;
            this.buttonUbah.Click += new System.EventHandler(this.buttonUbah_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(126, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 44);
            this.panel3.TabIndex = 13;
            // 
            // buttonTambah
            // 
            this.buttonTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonTambah.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonTambah.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.buttonTambah.IconColor = System.Drawing.Color.Black;
            this.buttonTambah.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonTambah.IconSize = 27;
            this.buttonTambah.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTambah.Location = new System.Drawing.Point(0, 0);
            this.buttonTambah.Name = "buttonTambah";
            this.buttonTambah.Size = new System.Drawing.Size(126, 44);
            this.buttonTambah.TabIndex = 8;
            this.buttonTambah.Text = "Tambah";
            this.buttonTambah.UseVisualStyleBackColor = false;
            this.buttonTambah.Click += new System.EventHandler(this.buttonTambah_Click);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewData.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewData.Location = new System.Drawing.Point(0, 44);
            this.dataGridViewData.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.RowHeadersWidth = 51;
            this.dataGridViewData.RowTemplate.Height = 24;
            this.dataGridViewData.Size = new System.Drawing.Size(800, 406);
            this.dataGridViewData.TabIndex = 7;
            this.dataGridViewData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewData_CellClick);
            // 
            // FormMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMahasiswa";
            this.Text = "FormMahasiswa";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton buttonRefresh;
        private FontAwesome.Sharp.IconButton buttonHapus;
        private FontAwesome.Sharp.IconButton buttonUbah;
        private FontAwesome.Sharp.IconButton buttonTambah;
        public System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}
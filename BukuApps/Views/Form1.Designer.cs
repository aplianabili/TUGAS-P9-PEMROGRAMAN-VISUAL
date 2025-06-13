namespace BukuApps
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtJudul;
        private System.Windows.Forms.TextBox txtPenulis;
        private System.Windows.Forms.TextBox txtPenerbit;
        private System.Windows.Forms.TextBox txtTahun;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label lblJudul;
        private System.Windows.Forms.Label lblPenulis;
        private System.Windows.Forms.Label lblPenerbit;
        private System.Windows.Forms.Label lblTahun;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtJudul = new System.Windows.Forms.TextBox();
            this.txtPenulis = new System.Windows.Forms.TextBox();
            this.txtPenerbit = new System.Windows.Forms.TextBox();
            this.txtTahun = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.lblJudul = new System.Windows.Forms.Label();
            this.lblPenulis = new System.Windows.Forms.Label();
            this.lblPenerbit = new System.Windows.Forms.Label();
            this.lblTahun = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(687, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtJudul
            // 
            this.txtJudul.Location = new System.Drawing.Point(120, 220);
            this.txtJudul.Name = "txtJudul";
            this.txtJudul.Size = new System.Drawing.Size(100, 26);
            this.txtJudul.TabIndex = 5;
            // 
            // txtPenulis
            // 
            this.txtPenulis.Location = new System.Drawing.Point(120, 250);
            this.txtPenulis.Name = "txtPenulis";
            this.txtPenulis.Size = new System.Drawing.Size(100, 26);
            this.txtPenulis.TabIndex = 6;
            // 
            // txtPenerbit
            // 
            this.txtPenerbit.Location = new System.Drawing.Point(120, 280);
            this.txtPenerbit.Name = "txtPenerbit";
            this.txtPenerbit.Size = new System.Drawing.Size(100, 26);
            this.txtPenerbit.TabIndex = 7;
            // 
            // txtTahun
            // 
            this.txtTahun.Location = new System.Drawing.Point(120, 310);
            this.txtTahun.Name = "txtTahun";
            this.txtTahun.Size = new System.Drawing.Size(100, 26);
            this.txtTahun.TabIndex = 8;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(250, 220);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 43);
            this.btnTambah.TabIndex = 9;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(250, 269);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 37);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(250, 310);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(100, 31);
            this.btnHapus.TabIndex = 11;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // lblJudul
            // 
            this.lblJudul.Location = new System.Drawing.Point(12, 220);
            this.lblJudul.Name = "lblJudul";
            this.lblJudul.Size = new System.Drawing.Size(100, 23);
            this.lblJudul.TabIndex = 1;
            this.lblJudul.Text = "Judul Buku:";
            // 
            // lblPenulis
            // 
            this.lblPenulis.Location = new System.Drawing.Point(12, 250);
            this.lblPenulis.Name = "lblPenulis";
            this.lblPenulis.Size = new System.Drawing.Size(100, 23);
            this.lblPenulis.TabIndex = 2;
            this.lblPenulis.Text = "Penulis:";
            // 
            // lblPenerbit
            // 
            this.lblPenerbit.Location = new System.Drawing.Point(12, 280);
            this.lblPenerbit.Name = "lblPenerbit";
            this.lblPenerbit.Size = new System.Drawing.Size(100, 23);
            this.lblPenerbit.TabIndex = 3;
            this.lblPenerbit.Text = "Penerbit:";
            // 
            // lblTahun
            // 
            this.lblTahun.Location = new System.Drawing.Point(12, 310);
            this.lblTahun.Name = "lblTahun";
            this.lblTahun.Size = new System.Drawing.Size(100, 23);
            this.lblTahun.TabIndex = 4;
            this.lblTahun.Text = "Tahun Terbit:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(815, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblJudul);
            this.Controls.Add(this.lblPenulis);
            this.Controls.Add(this.lblPenerbit);
            this.Controls.Add(this.lblTahun);
            this.Controls.Add(this.txtJudul);
            this.Controls.Add(this.txtPenulis);
            this.Controls.Add(this.txtPenerbit);
            this.Controls.Add(this.txtTahun);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnHapus);
            this.Name = "Form1";
            this.Text = "Aplikasi Data Buku";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

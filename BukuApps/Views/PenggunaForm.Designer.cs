namespace BukuApps
{
    partial class PenggunaForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewBuku; // Declare DataGridView
        private System.Windows.Forms.Button btnPinjam; // Button for borrowing books
        private System.Windows.Forms.Button btnKembalikan; // Button for returning books

        private void InitializeComponent()
        {
            this.dataGridViewBuku = new System.Windows.Forms.DataGridView(); // Initialize DataGridView
            this.btnPinjam = new System.Windows.Forms.Button();
            this.btnKembalikan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuku)).BeginInit();
            this.SuspendLayout();

            // 
            // dataGridViewBuku
            // 
            this.dataGridViewBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuku.Location = new System.Drawing.Point(12, 12); // Set location on the form
            this.dataGridViewBuku.Name = "dataGridViewBuku"; // Set the name
            this.dataGridViewBuku.Size = new System.Drawing.Size(776, 300); // Set the size
            this.dataGridViewBuku.TabIndex = 0;

            // 
            // btnPinjam
            // 
            this.btnPinjam.Location = new System.Drawing.Point(12, 330);
            this.btnPinjam.Name = "btnPinjam";
            this.btnPinjam.Size = new System.Drawing.Size(120, 40);
            this.btnPinjam.TabIndex = 1;
            this.btnPinjam.Text = "Pinjam Buku";
            this.btnPinjam.UseVisualStyleBackColor = true;
            this.btnPinjam.Click += new System.EventHandler(this.btnPinjam_Click);

            // 
            // btnKembalikan
            // 
            this.btnKembalikan.Location = new System.Drawing.Point(150, 330);
            this.btnKembalikan.Name = "btnKembalikan";
            this.btnKembalikan.Size = new System.Drawing.Size(120, 40);
            this.btnKembalikan.TabIndex = 2;
            this.btnKembalikan.Text = "Kembalikan Buku";
            this.btnKembalikan.UseVisualStyleBackColor = true;
            this.btnKembalikan.Click += new System.EventHandler(this.btnKembalikan_Click);

            // 
            // PenggunaForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPinjam);
            this.Controls.Add(this.btnKembalikan);
            this.Controls.Add(this.dataGridViewBuku);
            this.Name = "PenggunaForm";
            this.Text = "Pengguna Form";
            this.Load += new System.EventHandler(this.PenggunaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuku)).EndInit();
            this.ResumeLayout(false);
        }
    }
}

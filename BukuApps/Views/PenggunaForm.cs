using System;
using System.Windows.Forms;

namespace BukuApps
{
    public partial class PenggunaForm : Form
    {
        private BukuRepository repo = new BukuRepository();

        public PenggunaForm()
        {
            InitializeComponent();
        }

        private void PenggunaForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var bukuList = repo.GetAllBuku();
            dataGridViewBuku.DataSource = bukuList;
        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            if (dataGridViewBuku.SelectedRows.Count > 0)
            {
                int idBuku = Convert.ToInt32(dataGridViewBuku.SelectedRows[0].Cells["id"].Value);
                repo.PinjamBuku(idBuku);
                MessageBox.Show("Buku berhasil dipinjam.");
                LoadData(); // Refresh the grid
            }
            else
            {
                MessageBox.Show("Pilih buku yang ingin dipinjam.");
            }
        }

        private void btnKembalikan_Click(object sender, EventArgs e)
        {
            if (dataGridViewBuku.SelectedRows.Count > 0)
            {
                int idBuku = Convert.ToInt32(dataGridViewBuku.SelectedRows[0].Cells["id"].Value);
                repo.KembalikanBuku(idBuku);
                MessageBox.Show("Buku berhasil dikembalikan.");
                LoadData(); // Refresh the grid
            }
            else
            {
                MessageBox.Show("Pilih buku yang ingin dikembalikan.");
            }
        }
    }
}

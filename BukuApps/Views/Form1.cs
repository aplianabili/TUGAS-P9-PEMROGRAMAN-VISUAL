using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BukuApps
{
    public partial class Form1 : Form
    {
        private BindingList<Buku> daftarBuku = new BindingList<Buku>();
        private BukuRepository repo = new BukuRepository();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = daftarBuku;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.CellClick += dataGridView1_CellClick;
            LoadData();
        }

        private void LoadData()
        {
            daftarBuku.Clear();
            var list = repo.GetAllBuku();
            foreach (var buku in list)
            {
                daftarBuku.Add(buku);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtJudul.Text) &&
                !string.IsNullOrWhiteSpace(txtPenulis.Text) &&
                !string.IsNullOrWhiteSpace(txtPenerbit.Text) &&
                !string.IsNullOrWhiteSpace(txtTahun.Text))
            {
                // Menambahkan status "Tersedia" pada saat buku baru dibuat
                var buku = new Buku(txtJudul.Text, txtPenulis.Text, txtPenerbit.Text, txtTahun.Text, 0, "Tersedia");
                repo.InsertBuku(buku);
                LoadData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Harap isi semua kolom!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = daftarBuku[index].Id;

                // Mengambil status dari buku yang dipilih dan menggunakannya untuk update
                string status = daftarBuku[index].Status;

                var buku = new Buku(txtJudul.Text, txtPenulis.Text, txtPenerbit.Text, txtTahun.Text, id, status);
                repo.UpdateBuku(buku);
                LoadData();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Pilih data yang akan diedit!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;
                int id = daftarBuku[index].Id;
                repo.DeleteBuku(id);
                LoadData();
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < daftarBuku.Count)
            {
                txtJudul.Text = daftarBuku[e.RowIndex].Judul;
                txtPenulis.Text = daftarBuku[e.RowIndex].Penulis;
                txtPenerbit.Text = daftarBuku[e.RowIndex].Penerbit;
                txtTahun.Text = daftarBuku[e.RowIndex].Tahun;
            }
        }

        private void ClearFields()
        {
            txtJudul.Clear();
            txtPenulis.Clear();
            txtPenerbit.Clear();
            txtTahun.Clear();
        }
    }
}

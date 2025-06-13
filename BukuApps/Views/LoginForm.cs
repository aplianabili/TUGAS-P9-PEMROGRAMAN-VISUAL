using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BukuApps.Helpers;

namespace BukuApps
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Isi username dan password!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conn = DatabaseHelper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM users WHERE username = @username LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string hash = reader["password"].ToString();
                        string role = reader["role"].ToString();

                        if (BCrypt.Net.BCrypt.Verify(password, hash))
                        {
                            reader.Close();
                            conn.Close();

                            if (role == "admin")
                            {
                                this.Hide();
                                Form1 adminForm = new Form1();
                                adminForm.Show();
                            }
                            else
                            {
                                this.Hide();
                                PenggunaForm userForm = new PenggunaForm();
                                userForm.Show();
                            }

                            return;
                        }
                    }

                    MessageBox.Show("Login gagal. Cek username atau password!", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            reg.ShowDialog();
        }
    }
}

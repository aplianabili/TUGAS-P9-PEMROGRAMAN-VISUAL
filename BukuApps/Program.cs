using System;
using System.Windows.Forms;

namespace BukuApps
{
    static class Program
    { 
        [STAThread]  // Wajib untuk Windows Forms
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mulai aplikasi dengan LoginForm
            Application.Run(new LoginForm());
        }
    }
}

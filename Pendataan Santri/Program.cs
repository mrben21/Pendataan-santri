using System;
using System.Windows.Forms;

namespace Pendataan_Santri
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin()); // Buka form login terlebih dahulu
        }
    }
}

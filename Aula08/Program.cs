using Empresa.View;
using System;
using System.Windows.Forms;

namespace Empresa
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormDepartamentos());
        }
    }
}
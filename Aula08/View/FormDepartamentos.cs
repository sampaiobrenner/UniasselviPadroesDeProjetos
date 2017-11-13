using System.Windows.Forms;

namespace Empresa.View
{
    public partial class FormDepartamentos : Form
    {
        public FormDepartamentos()
        {
            var form = new FormSplashScreen();

            form.ShowDialog();
            form.Dispose();

            InitializeComponent();
        }
    }
}
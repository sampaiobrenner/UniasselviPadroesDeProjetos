using Empresa.Persistence;
using Npgsql;
using System;
using System.Windows.Forms;

namespace Empresa.View
{
    public partial class FormSplashScreen : Form
    {
        public FormSplashScreen()
        {
            InitializeComponent();
        }

        private void VerificarConexaoBanco()
        {
            NpgsqlConnection conexao = PostgreSQL.Conexao;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 1;
            }

            if (progressBar1.Value == 80)
            {
                label2.Text = "Conectando ao banco...";
                timer1.Interval = 5;
            }

            if (progressBar1.Value == 81)
            {
                VerificarConexaoBanco();
                label2.Text = "Carregamento completo...";
            }

            if (progressBar1.Value == 100)
            {
                Close();
            }
        }
    }
}
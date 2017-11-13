using Empresa.Model;
using Empresa.Presenter;
using System.Windows.Forms;

namespace Empresa.View
{
    public partial class FormNovoDepartamento : Form
    {
        private Departamento departamento;

        public FormNovoDepartamento()
        {
            InitializeComponent();
            departamento = new Departamento();
        }

        public FormNovoDepartamento(int id)
        {
            InitializeComponent();
            departamento = DepartamentoPresenter.Consultar(id);
            txtNomeDepartamento.Text = departamento.Descricao;
        }

        private void buttonSalvar_Click(object sender, System.EventArgs e)
        {
            departamento.Descricao = txtNomeDepartamento.Text;
            var presenter = new DepartamentoPresenter();

            if (presenter.Salvar(departamento))
            {
                MessageBox.Show("Salvo com sucesso...");
            }

            Close();
        }

        private void buttonCancelar_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
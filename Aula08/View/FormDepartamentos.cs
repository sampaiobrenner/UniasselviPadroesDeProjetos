using Empresa.Model;
using Empresa.Presenter;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Empresa.View
{
    public partial class FormDepartamentos : Form
    {
        public FormDepartamentos()
        {
            new FormSplashScreen().ShowDialog();
            InitializeComponent();
            CarregarLista();
        }

        private void btnNovoDepartamento_Click(object sender, System.EventArgs e)
        {
            FormNovoDepartamento departamento = new FormNovoDepartamento();
            departamento.ShowDialog();
            CarregarLista();
        }

        private void btnEditarDepartamento_Click(object sender, System.EventArgs e)
        {
            int id = int.Parse(listaDepartamentos.SelectedItems[0].SubItems[0].Text);

            FormNovoDepartamento departamento = new FormNovoDepartamento(id);
            departamento.ShowDialog();
            CarregarLista();
        }

        private void btnExcluirDepartamento_Click(object sender, System.EventArgs e)
        {
            int id = int.Parse(listaDepartamentos.SelectedItems[0].SubItems[0].Text);
            if (DepartamentoPresenter.Excluir(id))
            {
                MessageBox.Show("Excluído com sucesso!");
            }
            CarregarLista();
        }

        private void btnAtualizarDepartamento_Click(object sender, System.EventArgs e)
        {
            CarregarLista();
        }

        private void btnSair_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void menu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (listaDepartamentos.SelectedItems.Count == 0)
            {
                btnEditarDepartamento.Enabled = false;
                btnExcluirDepartamento.Enabled = false;
            }
            else
            {
                btnEditarDepartamento.Enabled = true;
                btnExcluirDepartamento.Enabled = true;
            }
        }

        public void CarregarLista ()
        {
            listaDepartamentos.Items.Clear();

            List<Departamento> departamentos = Departamento.Consultar();

            foreach (var departamento in departamentos)
            {
                string[] itemLista = { departamento.Id.ToString(),
                                       departamento.Descricao };

                listaDepartamentos.Items.Add(new ListViewItem(itemLista));
            }
        }
    }
}
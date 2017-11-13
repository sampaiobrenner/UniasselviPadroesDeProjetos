namespace Empresa.View
{
    partial class FormDepartamentos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listaDepartamentos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnNovoDepartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEditarDepartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcluirDepartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAtualizarDepartamento = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // listaDepartamentos
            // 
            this.listaDepartamentos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listaDepartamentos.ContextMenuStrip = this.menu;
            this.listaDepartamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaDepartamentos.FullRowSelect = true;
            this.listaDepartamentos.GridLines = true;
            this.listaDepartamentos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listaDepartamentos.Location = new System.Drawing.Point(0, 0);
            this.listaDepartamentos.MultiSelect = false;
            this.listaDepartamentos.Name = "listaDepartamentos";
            this.listaDepartamentos.Size = new System.Drawing.Size(505, 273);
            this.listaDepartamentos.TabIndex = 0;
            this.listaDepartamentos.TabStop = false;
            this.listaDepartamentos.UseCompatibleStateImageBehavior = false;
            this.listaDepartamentos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descricao";
            this.columnHeader2.Width = 360;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNovoDepartamento,
            this.btnEditarDepartamento,
            this.btnExcluirDepartamento,
            this.btnAtualizarDepartamento,
            this.btnSair});
            this.menu.Name = "contextMenuStrip1";
            this.menu.Size = new System.Drawing.Size(153, 136);
            this.menu.Opening += new System.ComponentModel.CancelEventHandler(this.menu_Opening);
            // 
            // btnNovoDepartamento
            // 
            this.btnNovoDepartamento.Image = global::Empresa.Properties.Resources.NovoP;
            this.btnNovoDepartamento.Name = "btnNovoDepartamento";
            this.btnNovoDepartamento.Size = new System.Drawing.Size(116, 22);
            this.btnNovoDepartamento.Text = "Novo";
            this.btnNovoDepartamento.Click += new System.EventHandler(this.btnNovoDepartamento_Click);
            // 
            // btnEditarDepartamento
            // 
            this.btnEditarDepartamento.Image = global::Empresa.Properties.Resources.EditarP;
            this.btnEditarDepartamento.Name = "btnEditarDepartamento";
            this.btnEditarDepartamento.Size = new System.Drawing.Size(116, 22);
            this.btnEditarDepartamento.Text = "Editar";
            this.btnEditarDepartamento.Click += new System.EventHandler(this.btnEditarDepartamento_Click);
            // 
            // btnExcluirDepartamento
            // 
            this.btnExcluirDepartamento.Image = global::Empresa.Properties.Resources.ExcluirP;
            this.btnExcluirDepartamento.Name = "btnExcluirDepartamento";
            this.btnExcluirDepartamento.Size = new System.Drawing.Size(116, 22);
            this.btnExcluirDepartamento.Text = "Excluir";
            this.btnExcluirDepartamento.Click += new System.EventHandler(this.btnExcluirDepartamento_Click);
            // 
            // btnAtualizarDepartamento
            // 
            this.btnAtualizarDepartamento.Image = global::Empresa.Properties.Resources.AtualizarP;
            this.btnAtualizarDepartamento.Name = "btnAtualizarDepartamento";
            this.btnAtualizarDepartamento.Size = new System.Drawing.Size(116, 22);
            this.btnAtualizarDepartamento.Text = "Atualizar";
            this.btnAtualizarDepartamento.Click += new System.EventHandler(this.btnAtualizarDepartamento_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::Empresa.Properties.Resources.SairP;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(116, 22);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FormDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 273);
            this.Controls.Add(this.listaDepartamentos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamentos";
            this.menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listaDepartamentos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ContextMenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem btnNovoDepartamento;
        private System.Windows.Forms.ToolStripMenuItem btnAtualizarDepartamento;
        private System.Windows.Forms.ToolStripMenuItem btnExcluirDepartamento;
        private System.Windows.Forms.ToolStripMenuItem btnEditarDepartamento;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
    }
}
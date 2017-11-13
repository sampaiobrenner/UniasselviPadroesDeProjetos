using Empresa.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa.Presenter
{
    public class DepartamentoPresenter
    {
        public bool Salvar(Departamento departamento)
        {
            // Se o id estiver zerado, será salvo o novo registro, caso contrário o registro será atualizado.
            return departamento.Id == 0 ?  departamento.Persistir() : departamento.Atualizar();          
        }

        public static bool Excluir (int id)
        {
            return Departamento.Excluir(id);
        }

        public static List<Departamento> Consultar()
        {
            return Departamento.Consultar();
        }

        public static Departamento Consultar (int id)
        {
            return Departamento.Consultar(id);
        }
    }
}

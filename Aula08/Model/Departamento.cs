using Empresa.Persistence;
using System.Collections.Generic;

namespace Empresa.Model
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public bool Persistir()
        {
            var dao = new DepartamentoDAO();

            return dao.Persistir(this);
        }

        public bool Atualizar()
        {
            return new DepartamentoDAO().Persistir(this);
        }

        public static bool Excluir(int id)
        {
            return DepartamentoDAO.Excluir(id);
        }

        public static List<Departamento> Consultar()
        {
            return DepartamentoDAO.Consultar();
        }

        public static Departamento Consultar(int id)
        {
            return DepartamentoDAO.Consultar(id);
        }
    }
}

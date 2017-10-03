using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    public class SalaAula
    {
        private static List<Aluno> alunos = new List<Aluno>();
        private static int qntAlunos = 0;

        public SalaAula()
        {

        }

        public int AlunosEmSala()
        {
            return qntAlunos;
        }

        public string AdicionarAluno (Aluno aluno)
        {
            if (qntAlunos < 25)
            {
                alunos.Add(aluno);
                qntAlunos++;
                return "Adicionado com sucesso!";
            }
            else
            {
                return "Ocoreu um erro!";
            }   
        }

        public string RemoveAluno (int matricula)
        {
            foreach(var aluno in alunos)
            {
                if (aluno.Matricula == matricula)
                {
                    alunos.Remove(aluno);
                    qntAlunos--;
                    return "Removido com sucesso!";
                }
            }

            return "Aluno não localizado";
        }

        public string RemoveAulo(string nome)
        {

            foreach (var aluno in alunos)
            {
                if (aluno.Nome == nome)
                {
                    alunos.Remove(aluno);
                    qntAlunos--;
                    return "Removido com sucesso!";
                }
            }

            return "Aluno não localizado";
        }

        public List<Aluno> RetornarListaAlunos ()
        {
            return alunos;
        }
    }
}

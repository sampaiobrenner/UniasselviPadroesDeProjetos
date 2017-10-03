using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07
{
    public class Aluno : Pessoa
    {
        public int Matricula { get; set; }
        public string Curso { get; set; }

        public Aluno(string nome, int idade, string cpf, int matricula, string curso) : base(nome, idade, cpf) // base se refere ao construtur da classe pai
        {
            Matricula = matricula;
            Curso = curso;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    public class Aluno : Pessoa
    {
        private string curso;

        public Aluno(string nome, DateTime nascimento, 
            string matricula, string curso) : base(nome, nascimento, matricula)
        {
            this.curso = curso;
        }

        public static List<Aluno> listAluno = new List<Aluno>();
        public void Cadastrar(Aluno a) { listAluno.Add(a); }
        public static Aluno[] ListarAlunos() { return listAluno.ToArray<Aluno>();}
        public override string ToString()
        {
            return $"{GetNome()} {GetNascimento()} {GetMatricula()} {curso}";
        }
    }
}

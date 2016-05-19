using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    public class Professor : Pessoa
    {
        private string diretoria;

        public Professor(string nome, DateTime nascimento, 
            string matricula, string diretoria) : base(nome, nascimento, matricula)
        {
            this.diretoria = diretoria;
        }

        public static List<Professor> listProf = new List<Professor>();
        public void Cadastrar(Professor p) { listProf.Add(p); }
        public static Professor[] ListarProfs() { return listProf.ToArray<Professor>(); }
        public override string ToString()
        {
            return $"{GetNome()} {GetNascimento()} {GetMatricula()} {diretoria}";
        }
    }
}

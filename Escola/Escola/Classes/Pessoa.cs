using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    public class Pessoa : IPessoa
    {
        private string nome;
        private DateTime nascimento;
        private string matricula;

        public Pessoa(string nome, DateTime nascimento, string matricula)
        {
            this.nome = nome;
            this.nascimento = nascimento;
            this.matricula = matricula;
        }

        public string GetNome() { return nome; }
        public DateTime GetNascimento() { return nascimento;}
        public string GetMatricula() { return matricula; }

        public static List<IPessoa> Aniversariantes(IPessoa[] aluno, IPessoa[] professor, int mes)
        {
            List<IPessoa> pessoas = new List<IPessoa>();
            foreach (IPessoa a in aluno) if (a.GetNascimento().Month == mes) pessoas.Add(a);
            foreach (IPessoa p in professor) if (p.GetNascimento().Month == mes) pessoas.Add(p);
            return pessoas;
        }
    }
}

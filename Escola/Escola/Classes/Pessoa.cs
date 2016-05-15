using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    class Pessoa : IPessoa
    {
        private string nome;
        private DateTime nascimento;
        private string matricula;
        private List<Pessoa> lp = new List<Pessoa>();

        public Pessoa(string nome, DateTime nascimento, string matricula)
        {
            this.nome = nome;
            this.nascimento = nascimento;
            this.matricula = matricula;
            lp.Add(this);
        }

        public string GetNome() { return nome; }
        public string GetMatricula() { return matricula; }
        public DateTime GetNascimento() { return nascimento; }
        public List<Pessoa> ExibirPessoas(string mes)
        {
            List<Pessoa> listaTemp = new List<Pessoa>();
            foreach (Pessoa p in lp)
                if (p.GetNascimento().Month.ToString() == mes) listaTemp.Add(p);
            return listaTemp;
        }

    }
}

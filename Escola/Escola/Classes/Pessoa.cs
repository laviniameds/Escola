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

        public List<Pessoa> lp = new List<Pessoa>();

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
        public DateTime Nascimento
        {
            get
            {
                return nascimento;
            }

            set
            {
                nascimento = value;
            }
        }
        public string Matricula
        {
            get
            {
                return matricula;
            }

            set
            {
                matricula = value;
            }
        }

        public string GetNome() { return Nome; }
        public string GetMatricula() { return Matricula; }
        public DateTime GetNascimento() { return Nascimento; }
        public List<Pessoa> ExibirPessoas(int mes)
        {
            List<Pessoa> listaTemp = new List<Pessoa>();
            foreach (Pessoa p in lp)
                if (p.GetNascimento().Month == mes) listaTemp.Add(p);
            return listaTemp;
        }

    }
}

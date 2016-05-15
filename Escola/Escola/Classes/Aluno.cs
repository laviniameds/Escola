using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    class Aluno : Pessoa
    {
        private string curso;

        public string Curso
        {
            get {return curso;}
            set {curso = value;}
        }
    }
}

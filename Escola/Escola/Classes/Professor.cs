using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escola
{
    class Professor : Pessoa
    {
        private string diretoria;

        public string Diretoria
        {
            get {return diretoria;}
            set {diretoria = value;}
        }
    }
}

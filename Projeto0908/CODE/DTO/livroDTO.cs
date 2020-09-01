using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto0908.CODE.DTO
{
    class livroDTO
    {
        private string codLivro;
        private string nomeLivro;
        private string codGenero;
        private string codAutor;

        public string CodLivro
        {
            get
            {
                return codLivro;
            }

            set
            {
                codLivro = value;
            }
        }

        public string NomeLivro
        {
            get
            {
                return nomeLivro;
            }

            set
            {
                nomeLivro = value;
            }
        }

        public string CodGenero
        {
            get
            {
                return codGenero;
            }

            set
            {
                codGenero = value;
            }
        }

        public string CodAutor
        {
            get
            {
                return codAutor;
            }

            set
            {
                codAutor = value;
            }
        }
    }
}

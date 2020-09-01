using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto0908.CODE.DTO
{
    class autorDTO
    {
        private string codAutor;
        private string autor;

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

        public string Autor
        {
            get
            {
                return autor;
            }

            set
            {
                autor = value;
            }
        }
    }
}

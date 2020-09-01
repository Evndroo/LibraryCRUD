using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto0908.CODE.DTO
{
    class generoDTO
    {
        private string codGenero;
        private string genero;

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

        public string Genero
        {
            get
            {
                return genero;
            }

            set
            {
                genero = value;
            }
        }
    }
}

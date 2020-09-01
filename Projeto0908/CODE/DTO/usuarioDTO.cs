using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto0908.CODE.DTO
{
    class usuarioDTO
    {
        private string codUsuario;
        private string nomeUsuario;
        private string endUsuario;
        private string telUsuario;



        public string NomeUsuario
        {
            get
            {
                return nomeUsuario;
            }

            set
            {
                nomeUsuario = value;
            }
        }

        public string EndUsuario
        {
            get
            {
                return endUsuario;
            }

            set
            {
                endUsuario = value;
            }
        }

        public string TelUsuario
        {
            get
            {
                return telUsuario;
            }

            set
            {
                telUsuario = value;
            }
        }

        public string CodUsuario
        {
            get
            {
                return codUsuario;
            }

            set
            {
                codUsuario = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Projeto0908.CODE.DAL
{
    class conexaoUsuario
    {
        SqlConnection con = new SqlConnection(@"Persist Security Info=False;User ID=sa;password=1234567;Initial Catalog=DB0908;Data Source=Localhost");

        public SqlConnection conectarBD()
        {
            try
            {
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na Conexão");
            }
            return con;
        }

        public SqlConnection desconectarBD()
        {
            try
            {
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro na Conexão");
            }
            return con;
        }
    }
}

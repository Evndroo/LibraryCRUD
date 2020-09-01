using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto0908.CODE.DTO;
using Projeto0908.CODE.DAL;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Projeto0908.CODE.BLL
{
    class usuarioBLL
    {
        conexaoUsuario con = new conexaoUsuario();

        public void Inserir(usuarioDTO dto)
        {
            SqlCommand cmd = new SqlCommand("insert into tbUsuario values(@codUsuario,@nomeUsuario,@endUsuario,@telUsuario)", con.conectarBD());

            cmd.Parameters.Add("@codUsuario", SqlDbType.VarChar).Value = dto.CodUsuario;
            cmd.Parameters.Add("@nomeUsuario", SqlDbType.VarChar).Value = dto.NomeUsuario;
            cmd.Parameters.Add("@endUsuario", SqlDbType.VarChar).Value = dto.EndUsuario;
            cmd.Parameters.Add("@telUsuario", SqlDbType.VarChar).Value = dto.TelUsuario;

            cmd.ExecuteNonQuery();
            con.desconectarBD();
        }

        public void excluir(usuarioDTO dto)
        {

            SqlCommand cmd = new SqlCommand("delete from tbUsuario where codUsuario=@cod", con.conectarBD());

            cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = dto.CodUsuario;
            cmd.ExecuteNonQuery();
            con.desconectarBD();
        }

        public void atualizar(usuarioDTO dto)
        {

            SqlCommand cmd = new SqlCommand("update tbUsuario set nomeUsuario=@nome,endUsuario=@end,telUsuario=@tel where codUsuario=@cod", con.conectarBD());

            cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = dto.CodUsuario;
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = dto.NomeUsuario;
            cmd.Parameters.Add("@end", SqlDbType.VarChar).Value = dto.EndUsuario;
            cmd.Parameters.Add("@tel", SqlDbType.VarChar).Value = dto.TelUsuario;
            cmd.ExecuteNonQuery();
            con.desconectarBD();
        }

        SqlDataReader dr;
        public void BuscarUsuario(usuarioDTO dto, string txt)
        {

            SqlCommand cmd = new SqlCommand("Select * from tbUsuario where codUsuario=@cod", con.conectarBD());
            cmd.Parameters.AddWithValue("@cod", dto.CodUsuario);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dto.CodUsuario = dr[0].ToString();
                dto.NomeUsuario = dr[1].ToString();
                dto.EndUsuario = dr[2].ToString();
                dto.TelUsuario = dr[3].ToString();
            }
            con.desconectarBD();
        }


    }
}

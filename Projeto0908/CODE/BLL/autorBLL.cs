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
    class autorBLL
    {
        conexaoUsuario con = new conexaoUsuario();

        public void Inserir(autorDTO dto)
        {
            SqlCommand cmd = new SqlCommand("insert into tbAutor values(@codAutor,@autor)", con.conectarBD());

            cmd.Parameters.Add("@codAutor", SqlDbType.VarChar).Value = dto.CodAutor;
            cmd.Parameters.Add("@autor", SqlDbType.VarChar).Value = dto.Autor;

            cmd.ExecuteNonQuery();
            con.desconectarBD();
        }

        public void excluir(autorDTO dto)
        {

            SqlCommand cmd = new SqlCommand("delete from tbAutor where codAutor=@cod", con.conectarBD());

            cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = dto.CodAutor;
            cmd.ExecuteNonQuery();
            con.desconectarBD();
        }

        public void atualizar(autorDTO dto)
        {

            SqlCommand cmd = new SqlCommand("update tbAutor set autor=@autor where codAutor=@cod", con.conectarBD());

            cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = dto.CodAutor;
            cmd.Parameters.Add("@autor", SqlDbType.VarChar).Value = dto.Autor;
            cmd.ExecuteNonQuery();
            con.desconectarBD();
        }

        SqlDataReader dr;
        public void BuscarUsuario(autorDTO dto, string txt)
        {

            SqlCommand cmd = new SqlCommand("Select * from tbAutor where codAutor=@cod", con.conectarBD());
            cmd.Parameters.AddWithValue("@cod", dto.CodAutor);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dto.CodAutor = dr[0].ToString();
                dto.Autor = dr[1].ToString();
            }
            con.desconectarBD();
        }



    }
}

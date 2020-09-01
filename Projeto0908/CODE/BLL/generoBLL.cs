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
    class generoBLL
    {
        conexaoUsuario con = new conexaoUsuario();

        public void Inserir(generoDTO dto)
        {
            SqlCommand cmd = new SqlCommand("insert into tbGenero values(@codGenero,@genero)", con.conectarBD());

            cmd.Parameters.Add("@codGenero", SqlDbType.VarChar).Value = dto.CodGenero;
            cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = dto.Genero;

            cmd.ExecuteNonQuery();
            con.desconectarBD();
        }

        public void excluir(generoDTO dto)
        {

            SqlCommand cmd = new SqlCommand("delete from tbGenero where codGenero=@cod", con.conectarBD());

            cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = dto.CodGenero;
            cmd.ExecuteNonQuery();
            con.desconectarBD();
        }

        public void atualizar(generoDTO dto)
        {

            SqlCommand cmd = new SqlCommand("update tbGenero set genero=@genero where codGenero=@cod", con.conectarBD());

            cmd.Parameters.Add("@cod", SqlDbType.VarChar).Value = dto.CodGenero;
            cmd.Parameters.Add("@genero", SqlDbType.VarChar).Value = dto.Genero;
            cmd.ExecuteNonQuery();
            con.desconectarBD();
        }

        SqlDataReader dr;
        public void BuscarUsuario(generoDTO dto, string txt)
        {

            SqlCommand cmd = new SqlCommand("Select * from tbGenero where codGenero=@cod", con.conectarBD());
            cmd.Parameters.AddWithValue("@cod", dto.CodGenero);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dto.CodGenero = dr[0].ToString();
                dto.Genero = dr[1].ToString();
            }
            con.desconectarBD();
        }

        public void selecionaGenero(ComboBox cbo)
        {
            SqlDataAdapter da = new SqlDataAdapter("select*from tbGenero", con.conectarBD());
            DataSet ds = new DataSet();
            da.Fill(ds);
            cbo.DataSource = ds.Tables[0];
            cbo.DisplayMember = "genero";
            cbo.ValueMember = "codGenero";
            cbo.DataSource = ds.Tables[0];
            con.desconectarBD();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto0908.CODE.BLL;
using Projeto0908.CODE.DTO;


namespace Projeto0908.Forms
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        usuarioDTO dto = new usuarioDTO();
        usuarioBLL bll = new usuarioBLL();


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dto.CodUsuario = txtCodigo.Text;
            bll.BuscarUsuario(dto, txtCodigo.Text);

            txtCodigo.Text = dto.CodUsuario;
            txtNome.Text = dto.NomeUsuario;
            txtEnd.Text = dto.EndUsuario;
            txtTel.Text = dto.TelUsuario;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "QUIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dto.CodUsuario = txtCodigo.Text;
                dto.NomeUsuario = txtNome.Text;
                dto.EndUsuario = txtEnd.Text;
                dto.TelUsuario = txtTel.Text;


                try
                {
                    bll.Inserir(dto);
                    MessageBox.Show("DEU CERTO! IHI");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DEU XABU" + ex);
                }
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja atualizar?", "QUIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dto.NomeUsuario = txtNome.Text;
                dto.EndUsuario = txtEnd.Text;
                dto.TelUsuario = txtTel.Text;

                try
                {
                    bll.atualizar(dto);
                    MessageBox.Show("DEU CERTO! IHI");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("DEU XABU" + ex);
                }
                


            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir?", "QUIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dto.CodUsuario = txtCodigo.Text;
                try
                {
                    bll.excluir(dto);
                    MessageBox.Show("DEU CERTO! IHI");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DEU XABU" + ex);
                }

            }

        }
    }
}

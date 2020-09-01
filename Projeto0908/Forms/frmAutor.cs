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
    public partial class frmAutor : Form
    {
        public frmAutor()
        {
            InitializeComponent();
        }

        autorBLL bll = new autorBLL();
        autorDTO dto = new autorDTO();

        private void btnCadastrarAut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "QUIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dto.CodAutor = txtCodAut.Text;
                dto.Autor = txtNomeAut.Text;


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

        private void btnBuscarAut_Click(object sender, EventArgs e)
        {
            dto.CodAutor = txtCodAut.Text;
            bll.BuscarUsuario(dto, txtCodAut.Text);

            txtCodAut.Text = dto.CodAutor;
            txtNomeAut.Text = dto.Autor;
        }

        private void btnAtualizarAut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja atualizar?", "QUIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dto.Autor = txtNomeAut.Text;
                txtCodAut.Text = "";
                txtNomeAut.Text = "";

                try
                {
                    bll.atualizar(dto);
                    MessageBox.Show("DEU CERTO! IHI");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DEU XABU" + ex);
                }



            }
        }

        private void btnExcluirAut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir?", "QUIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dto.CodAutor = txtCodAut.Text;

            
                try
                {
                    bll.excluir(dto);
                    MessageBox.Show("DEU CERTO! IHI");
                    dto.Autor = "";
                    dto.CodAutor = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DEU XABU" + ex);
                }

            }
        }
    }
}

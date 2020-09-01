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
    public partial class frmGenero : Form
    {
        public frmGenero()
        {
            InitializeComponent();
        }

        generoBLL bll = new generoBLL();
        generoDTO dto = new generoDTO();

        private void btnCadGen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Cadastrar?", "QUIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dto.CodGenero = txtCodGen.Text;
                dto.Genero = txtGenero.Text;


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

        private void btnBuscaGen_Click(object sender, EventArgs e)
        {
            dto.CodGenero = txtCodGen.Text;
            bll.BuscarUsuario(dto, txtCodGen.Text);

            txtCodGen.Text = dto.CodGenero;
            txtGenero.Text = dto.Genero;
        }

        private void btnAtualGen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja atualizar?", "QUIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dto.Genero = txtGenero.Text;
                txtCodGen.Text = "";
                txtGenero.Text = "";

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

        private void btnExcluirGen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir?", "QUIZ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dto.CodGenero = txtCodGen.Text;


                try
                {
                    bll.excluir(dto);
                    MessageBox.Show("DEU CERTO! IHI");
                    dto.CodGenero = "";
                    dto.Genero = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DEU XABU" + ex);
                }

            }
        }
    }
}

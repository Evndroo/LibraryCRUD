using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto0908.Forms;

namespace Projeto0908
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuario frmU = new frmUsuario();

            frmU.MdiParent = this;
            frmU.Show();
        }

        private void gêneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGenero frmG = new frmGenero();
            frmG.Show();
        }

        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAutor frmA = new frmAutor();
            frmA.Show();
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLivro frmL = new frmLivro();
            frmL.Show();
        }
    }
}

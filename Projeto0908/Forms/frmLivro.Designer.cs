namespace Projeto0908.Forms
{
    partial class frmLivro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodLivro = new System.Windows.Forms.TextBox();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.btnCadLivro = new System.Windows.Forms.Button();
            this.btnBuscarLivro = new System.Windows.Forms.Button();
            this.txtAtualizarLivro = new System.Windows.Forms.Button();
            this.btnExcluirLivro = new System.Windows.Forms.Button();
            this.cboGenero = new System.Windows.Forms.ComboBox();
            this.cboAutor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Livro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Livro:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código do Gênero:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Código do Autor:";
            // 
            // txtCodLivro
            // 
            this.txtCodLivro.Location = new System.Drawing.Point(336, 68);
            this.txtCodLivro.Name = "txtCodLivro";
            this.txtCodLivro.Size = new System.Drawing.Size(100, 20);
            this.txtCodLivro.TabIndex = 4;
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.Location = new System.Drawing.Point(336, 110);
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(100, 20);
            this.txtNomeLivro.TabIndex = 5;
            // 
            // btnCadLivro
            // 
            this.btnCadLivro.Location = new System.Drawing.Point(200, 239);
            this.btnCadLivro.Name = "btnCadLivro";
            this.btnCadLivro.Size = new System.Drawing.Size(75, 23);
            this.btnCadLivro.TabIndex = 8;
            this.btnCadLivro.Text = "Cadastrar";
            this.btnCadLivro.UseVisualStyleBackColor = true;
            // 
            // btnBuscarLivro
            // 
            this.btnBuscarLivro.Location = new System.Drawing.Point(281, 239);
            this.btnBuscarLivro.Name = "btnBuscarLivro";
            this.btnBuscarLivro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarLivro.TabIndex = 9;
            this.btnBuscarLivro.Text = "Buscar";
            this.btnBuscarLivro.UseVisualStyleBackColor = true;
            // 
            // txtAtualizarLivro
            // 
            this.txtAtualizarLivro.Location = new System.Drawing.Point(362, 239);
            this.txtAtualizarLivro.Name = "txtAtualizarLivro";
            this.txtAtualizarLivro.Size = new System.Drawing.Size(75, 23);
            this.txtAtualizarLivro.TabIndex = 10;
            this.txtAtualizarLivro.Text = "Atualizar";
            this.txtAtualizarLivro.UseVisualStyleBackColor = true;
            // 
            // btnExcluirLivro
            // 
            this.btnExcluirLivro.Location = new System.Drawing.Point(443, 239);
            this.btnExcluirLivro.Name = "btnExcluirLivro";
            this.btnExcluirLivro.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirLivro.TabIndex = 11;
            this.btnExcluirLivro.Text = "Excluir";
            this.btnExcluirLivro.UseVisualStyleBackColor = true;
            // 
            // cboGenero
            // 
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.Location = new System.Drawing.Point(336, 157);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(101, 21);
            this.cboGenero.TabIndex = 12;
            // 
            // cboAutor
            // 
            this.cboAutor.FormattingEnabled = true;
            this.cboAutor.Location = new System.Drawing.Point(336, 194);
            this.cboAutor.Name = "cboAutor";
            this.cboAutor.Size = new System.Drawing.Size(101, 21);
            this.cboAutor.TabIndex = 13;
            // 
            // frmLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 351);
            this.Controls.Add(this.cboAutor);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.btnExcluirLivro);
            this.Controls.Add(this.txtAtualizarLivro);
            this.Controls.Add(this.btnBuscarLivro);
            this.Controls.Add(this.btnCadLivro);
            this.Controls.Add(this.txtNomeLivro);
            this.Controls.Add(this.txtCodLivro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLivro";
            this.Text = "frmLivro";
            this.Load += new System.EventHandler(this.frmLivro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodLivro;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Button btnCadLivro;
        private System.Windows.Forms.Button btnBuscarLivro;
        private System.Windows.Forms.Button txtAtualizarLivro;
        private System.Windows.Forms.Button btnExcluirLivro;
        private System.Windows.Forms.ComboBox cboGenero;
        private System.Windows.Forms.ComboBox cboAutor;
    }
}
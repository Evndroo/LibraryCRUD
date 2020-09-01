namespace Projeto0908.Forms
{
    partial class frmAutor
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
            this.txtCodAut = new System.Windows.Forms.TextBox();
            this.txtNomeAut = new System.Windows.Forms.TextBox();
            this.btnCadastrarAut = new System.Windows.Forms.Button();
            this.btnBuscarAut = new System.Windows.Forms.Button();
            this.btnAtualizarAut = new System.Windows.Forms.Button();
            this.btnExcluirAut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Autor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor:";
            // 
            // txtCodAut
            // 
            this.txtCodAut.Location = new System.Drawing.Point(316, 86);
            this.txtCodAut.Name = "txtCodAut";
            this.txtCodAut.Size = new System.Drawing.Size(100, 20);
            this.txtCodAut.TabIndex = 2;
            // 
            // txtNomeAut
            // 
            this.txtNomeAut.Location = new System.Drawing.Point(316, 135);
            this.txtNomeAut.Name = "txtNomeAut";
            this.txtNomeAut.Size = new System.Drawing.Size(100, 20);
            this.txtNomeAut.TabIndex = 3;
            // 
            // btnCadastrarAut
            // 
            this.btnCadastrarAut.Location = new System.Drawing.Point(203, 232);
            this.btnCadastrarAut.Name = "btnCadastrarAut";
            this.btnCadastrarAut.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrarAut.TabIndex = 4;
            this.btnCadastrarAut.Text = "Cadastrar";
            this.btnCadastrarAut.UseVisualStyleBackColor = true;
            this.btnCadastrarAut.Click += new System.EventHandler(this.btnCadastrarAut_Click);
            // 
            // btnBuscarAut
            // 
            this.btnBuscarAut.Location = new System.Drawing.Point(284, 232);
            this.btnBuscarAut.Name = "btnBuscarAut";
            this.btnBuscarAut.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarAut.TabIndex = 5;
            this.btnBuscarAut.Text = "Buscar";
            this.btnBuscarAut.UseVisualStyleBackColor = true;
            this.btnBuscarAut.Click += new System.EventHandler(this.btnBuscarAut_Click);
            // 
            // btnAtualizarAut
            // 
            this.btnAtualizarAut.Location = new System.Drawing.Point(365, 232);
            this.btnAtualizarAut.Name = "btnAtualizarAut";
            this.btnAtualizarAut.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarAut.TabIndex = 6;
            this.btnAtualizarAut.Text = "Atualizar";
            this.btnAtualizarAut.UseVisualStyleBackColor = true;
            this.btnAtualizarAut.Click += new System.EventHandler(this.btnAtualizarAut_Click);
            // 
            // btnExcluirAut
            // 
            this.btnExcluirAut.Location = new System.Drawing.Point(446, 232);
            this.btnExcluirAut.Name = "btnExcluirAut";
            this.btnExcluirAut.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirAut.TabIndex = 7;
            this.btnExcluirAut.Text = "Excluir";
            this.btnExcluirAut.UseVisualStyleBackColor = true;
            this.btnExcluirAut.Click += new System.EventHandler(this.btnExcluirAut_Click);
            // 
            // frmAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 368);
            this.Controls.Add(this.btnExcluirAut);
            this.Controls.Add(this.btnAtualizarAut);
            this.Controls.Add(this.btnBuscarAut);
            this.Controls.Add(this.btnCadastrarAut);
            this.Controls.Add(this.txtNomeAut);
            this.Controls.Add(this.txtCodAut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAutor";
            this.Text = "frmAutor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodAut;
        private System.Windows.Forms.TextBox txtNomeAut;
        private System.Windows.Forms.Button btnCadastrarAut;
        private System.Windows.Forms.Button btnBuscarAut;
        private System.Windows.Forms.Button btnAtualizarAut;
        private System.Windows.Forms.Button btnExcluirAut;
    }
}
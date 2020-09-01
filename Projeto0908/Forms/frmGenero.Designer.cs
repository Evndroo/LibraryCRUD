namespace Projeto0908.Forms
{
    partial class frmGenero
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
            this.txtCodGen = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.btnCadGen = new System.Windows.Forms.Button();
            this.btnBuscaGen = new System.Windows.Forms.Button();
            this.btnAtualGen = new System.Windows.Forms.Button();
            this.btnExcluirGen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Gênero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Gênero:";
            // 
            // txtCodGen
            // 
            this.txtCodGen.Location = new System.Drawing.Point(358, 91);
            this.txtCodGen.Name = "txtCodGen";
            this.txtCodGen.Size = new System.Drawing.Size(100, 20);
            this.txtCodGen.TabIndex = 2;
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(358, 133);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(100, 20);
            this.txtGenero.TabIndex = 3;
            // 
            // btnCadGen
            // 
            this.btnCadGen.Location = new System.Drawing.Point(185, 219);
            this.btnCadGen.Name = "btnCadGen";
            this.btnCadGen.Size = new System.Drawing.Size(75, 23);
            this.btnCadGen.TabIndex = 4;
            this.btnCadGen.Text = "Cadastrar";
            this.btnCadGen.UseVisualStyleBackColor = true;
            this.btnCadGen.Click += new System.EventHandler(this.btnCadGen_Click);
            // 
            // btnBuscaGen
            // 
            this.btnBuscaGen.Location = new System.Drawing.Point(266, 219);
            this.btnBuscaGen.Name = "btnBuscaGen";
            this.btnBuscaGen.Size = new System.Drawing.Size(75, 23);
            this.btnBuscaGen.TabIndex = 5;
            this.btnBuscaGen.Text = "Buscar";
            this.btnBuscaGen.UseVisualStyleBackColor = true;
            this.btnBuscaGen.Click += new System.EventHandler(this.btnBuscaGen_Click);
            // 
            // btnAtualGen
            // 
            this.btnAtualGen.Location = new System.Drawing.Point(347, 219);
            this.btnAtualGen.Name = "btnAtualGen";
            this.btnAtualGen.Size = new System.Drawing.Size(75, 23);
            this.btnAtualGen.TabIndex = 6;
            this.btnAtualGen.Text = "Atualizar";
            this.btnAtualGen.UseVisualStyleBackColor = true;
            this.btnAtualGen.Click += new System.EventHandler(this.btnAtualGen_Click);
            // 
            // btnExcluirGen
            // 
            this.btnExcluirGen.Location = new System.Drawing.Point(428, 219);
            this.btnExcluirGen.Name = "btnExcluirGen";
            this.btnExcluirGen.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirGen.TabIndex = 7;
            this.btnExcluirGen.Text = "Excluir";
            this.btnExcluirGen.UseVisualStyleBackColor = true;
            this.btnExcluirGen.Click += new System.EventHandler(this.btnExcluirGen_Click);
            // 
            // frmGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 391);
            this.Controls.Add(this.btnExcluirGen);
            this.Controls.Add(this.btnAtualGen);
            this.Controls.Add(this.btnBuscaGen);
            this.Controls.Add(this.btnCadGen);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.txtCodGen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmGenero";
            this.Text = "frmGenero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodGen;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Button btnCadGen;
        private System.Windows.Forms.Button btnBuscaGen;
        private System.Windows.Forms.Button btnAtualGen;
        private System.Windows.Forms.Button btnExcluirGen;
    }
}
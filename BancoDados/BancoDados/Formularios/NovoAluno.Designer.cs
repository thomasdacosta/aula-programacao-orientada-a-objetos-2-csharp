namespace BancoDados
{
    partial class NovoAluno
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblRA = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(101, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(269, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(101, 49);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(269, 20);
            this.txtRA.TabIndex = 1;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(12, 26);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(83, 13);
            this.lblAluno.TabIndex = 2;
            this.lblAluno.Text = "Nome do Aluno:";
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(70, 52);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(25, 13);
            this.lblRA.TabIndex = 3;
            this.lblRA.Text = "RA:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "&Sair";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(164, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Incluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // NovoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 129);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblRA);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NovoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}


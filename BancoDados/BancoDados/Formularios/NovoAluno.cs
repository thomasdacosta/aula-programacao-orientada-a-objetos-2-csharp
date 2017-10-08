using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BancoDados
{
    public partial class NovoAluno : Form
    {
        private AlunoFacade alunoFacade = new AlunoFacade();

        public NovoAluno()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                alunoFacade.IncluirAluno(txtNome.Text, txtRA.Text);
                MessageBox.Show(this, "Aluno incluído com sucesso.", "Novo Aluno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Text = "";
                txtRA.Text = "";
            } 
            catch (Exception ex)
            {
                MessageBox.Show(this, "ERRO AO INCLUIR: " + ex.Message, "Novo Aluno", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtRA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(this, "Deseja realmente fechar esta tela.", "Novo Aluno", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}

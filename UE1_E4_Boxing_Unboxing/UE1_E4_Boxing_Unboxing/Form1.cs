using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UE1_E4_Boxing_Unboxing
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Clicou !!!", "Título da Mensagem", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                MessageBox.Show("Clicou em OK");
            }
            else
            {
                MessageBox.Show("Clicou em Cancel");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmSecundario form2 = new FrmSecundario();
            form2.ShowDialog();
        }
    }
}

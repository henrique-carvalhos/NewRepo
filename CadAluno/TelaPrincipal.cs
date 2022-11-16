using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadAluno
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaDeCadastro cadastroAluno = new TelaDeCadastro(); //Instância do objeto editor - Form2
            cadastroAluno.MdiParent = this;    //Define o pai do filho, editor(filho) e pai(Form1)
            cadastroAluno.Text = "Cadastro de Aluno";
            cadastroAluno.Show();
            cadastroAluno.WindowState = FormWindowState.Maximized;
        }
    }
}

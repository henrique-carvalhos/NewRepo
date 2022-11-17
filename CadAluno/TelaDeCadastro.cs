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
    public partial class TelaDeCadastro : Form
    {
        Aluno cadAluno = new Aluno();

        public TelaDeCadastro()
        {
            InitializeComponent();

            txtNomeUsuarioCad.Text = "Henrique de Carvalho";
            txtAno.Text = DateTime.Now.ToString("yyyy");
            txtDataMatricula.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Pesquisar número da matrícula
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //mostrar usuário que cadastrou o aluno
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //exibir numero da matrícula
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //salvar no banco
            cadAluno.setMatricula(int.Parse(txtMatricula.Text));
            cadAluno.setNomeUsuario(txtNomeUsuarioCad.Text);
            cadAluno.setEstadoAluno(cbEstadoAuno.Text);
            cadAluno.setContrato(txtContrato.Text);
            cadAluno.setDataNascimento(Convert.ToDateTime(txtNascimento.Text));
            cadAluno.setRg(txtRg.Text);
            cadAluno.setCpf(txtCpf.Text);
            cadAluno.setTurma(txtTurma.Text);
            cadAluno.setCurso(txtCurso.Text);
            cadAluno.setAno(Convert.ToInt16(txtAno.Text));
            cadAluno.setTurno(txtTurno.Text);
            cadAluno.setDataMatricula(Convert.ToDateTime(txtDataMatricula.Text));
            cadAluno.setDataValidade(Convert.ToDateTime(txtValidade.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //fazer update no banco
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //excluir usuário
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //limpar informações
            txtMatricula.Clear();
            cbEstadoAuno.SelectedIndex = 0;
            txtContrato.Clear();
            txtNascimento.Clear();
            txtRg.Clear();
            txtCpf.Clear();
            txtTurma.Clear();
            txtCurso.Clear();
            txtTurno.Clear();
            txtValidade.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //listar usuários cadastrados
        }

        private void checkedListBox1_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index == 0) e.NewValue = e.CurrentValue;

            /*if (e.NewValue == CheckState.Unchecked)
            {
                if (checkedListBox1.CheckedItems.Count == 1)
                {
                    //button2.Enabled = false;
                    checkedListBox1.Items.IndexOf(0);
                }
            }
            else
            {
                //button2.Enabled = true;
                checkedListBox1.CheckOnClick = true;
            }*/
        }
    }
}

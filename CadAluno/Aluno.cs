using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadAluno
{
    public class Aluno
    {
        //Atributos
        private int Matricula;
        private string NomeUsuario;
        private string EstadoAluno;
        private string Contrato;
        private string NomeAluno;
        private DateTime DataNascimento;
        private string Rg;
        private string Cpf;
        private string Turma;
        private string Curso;
        private int Ano;
        private string Turno;
        private DateTime DataMatricula;
        private DateTime DataValidade;

        //Método Construtor
        public Aluno()
        {
        }

        public Aluno(int matricula, string nomeUsuario, string estadoAluno, string nomeAluno, DateTime dataNascimento, string rg, string cpf, string turma, string curso, int ano, string turno, DateTime dataValidade)
        {
            Matricula = matricula;
            NomeUsuario = nomeUsuario;
            EstadoAluno = estadoAluno;
            NomeAluno = nomeAluno;
            DataNascimento = dataNascimento;
            Rg = rg;
            Cpf = cpf;
            Turma = turma;
            Curso = curso;
            Ano = ano;
            Turno = turno;
            DataMatricula = DateTime.Now;
            DataValidade = dataValidade;
        }

        //Métodos Get e Set
        public int getMatricula()
        {
            return this.Matricula;
        }
        public void setMatricula(int matricula)
        {
            this.Matricula = matricula++;
        }

        public string getNomeUsuario()
        {
            return this.NomeUsuario;
        }
        public void setNomeUsuario(string nomeUsuario)
        {
            this.NomeUsuario = nomeUsuario;
        }

        public string getEstadoAluno()
        {
            return this.EstadoAluno;
        }
        public void setEstadoAluno(string estadoAluno)
        {
            this.EstadoAluno = estadoAluno;
        }

        public string getContrato()
        {
            return this.Contrato;
        }
        public void setContrato(string contrato)
        {
            this.Contrato = contrato;
        }

        public string getNomeAluno()
        {
            return this.NomeAluno;
        }
        public void setNomeAluno(string nomeAluno)
        {
            this.NomeAluno = nomeAluno;
        }

        public DateTime getDataNascimento()
        {
            return this.DataNascimento;
        }
        public void setDataNascimento(DateTime dataNascimento)
        {
            this.DataNascimento = dataNascimento;
        }

        public string getRg()
        {
            return this.Rg;
        }
        public void setRg(string rg)
        {
            this.Rg = rg;
        }

        public string getCpf()
        {
            return this.Cpf;
        }
        public void setCpf(string cpf)
        {
            this.Cpf = cpf;
        }

        public string getTurma()
        {
            return this.Turma;
        }
        public void setTurma(string turma)
        {
            this.Turma = turma;
        }

        public string getCurso()
        {
            return this.Curso;
        }
        public void setCurso(string curso)
        {
            this.Curso = curso;
        }

        public int getAno()
        {
            return this.Ano;
        }
        public void setAno(int ano)
        {
            this.Ano = ano;
        }

        public string getTurno()
        {
            return this.Turno;
        }
        public void setTurno(string turno)
        {
            this.Turno = turno;
        }

        public DateTime getDataMatricula()
        {
            return this.DataMatricula;
        }
        public void setDataMatricula(DateTime dataMatricula)
        {
            this.DataMatricula = dataMatricula;
        }

        public DateTime getDataValidade()
        {
            return this.DataValidade;
        }
        public void setDataValidade(DateTime dataValidade)
        {
            this.DataValidade = dataValidade;
        }
    }
}

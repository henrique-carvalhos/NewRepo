using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadAluno
{
    public class LoginProgram
    {
        //Atributos
        private string Email;
        private string ConfirmarEmail;
        private string Senha;
        private string ConfirmarSenha;

        //Método construtor
        public LoginProgram()
        {
        }

        public LoginProgram(string email, string confirmarEmail, string senha, string confirmarSenha)
        {
            Email = email;
            ConfirmarEmail = confirmarEmail;
            Senha = senha;
            ConfirmarSenha = confirmarSenha;
        }

        //Métodos Get e Set
        public string getEmail()
        {
            return this.Email;
        }
        public void setEmail(string email)
        {
            this.Email = email;
        }

        public string getConfirmarEmail()
        {
            return this.ConfirmarEmail;
        }
        public void setConfirmarEmail(string confirmarEmail)
        {
            this.ConfirmarEmail = confirmarEmail;
        }
    }
}

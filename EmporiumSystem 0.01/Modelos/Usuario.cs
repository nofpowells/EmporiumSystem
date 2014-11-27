using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Usuario
    {
        private string nome;
        private string senha;

        public Usuario ()
        { }

        public string getNome()
        {
            return nome;
        }

        public string getSenha()
        {
            return senha;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setSenha(string senha)
        {
            this.senha = senha;
        }

        public bool VerificarLogin(string nome, string senha)
        {
            if (nome == "admin" && senha == "admin")
            {
                return true;
            }
            return false;
        }
    }
}

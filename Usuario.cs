using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1{
    internal class Usuario{ 
        //os atributos: nome, login e senha
        //cadeia = string
        public string nome;
        public string login;
        public string senha;
        public int qtdlogin;
        public float peso;
        public bool esSolteiro;
        public char abvNomeMeio;

        public bool Logar(string _login, string _senha){
            if(_login == login) {
                if (_senha == senha) {
                    return true;
                }
            }
            return false;
        }
    }
}

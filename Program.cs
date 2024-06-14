using System.Numerics;
using System.Reflection.Metadata;
using System.Xml;

namespace console1 {
    internal class Program {
        static void Main(string[] args) {
            Usuario usuario = new Usuario();
            usuario.nome = "Clark";
            usuario.login = "root";
            usuario.senha = "qwe123";

            string login;
            string senha;

            do {
                Console.WriteLine("Digite seu login");
                login = Console.ReadLine();

                Console.WriteLine("Digite sua senha");
                senha = Console.ReadLine();

            } while(!usuario.Logar(login, senha));

        }
    }
}
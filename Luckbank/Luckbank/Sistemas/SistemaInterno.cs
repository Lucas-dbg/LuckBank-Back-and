using Luckbank.funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luckbank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(FuncionarioAutenticavel funcionarioAutenticavel, string senha)
        {
            bool resultado = funcionarioAutenticavel.Autenticar(senha);
            if (resultado)
            {
                Console.WriteLine("Você está logado no sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha Inválida");
                return false;
            }
        }
    }
}

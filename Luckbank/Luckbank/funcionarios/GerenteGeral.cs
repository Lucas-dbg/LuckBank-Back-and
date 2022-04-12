using Luckbank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luckbank.funcionarios
{
    public class GerenteGeral : FuncionarioAutenticavel
    {
        public GerenteGeral(int salario, string nome, string cpf, string senha) : base(salario, nome, cpf, senha)
        {
            
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }
    }
}

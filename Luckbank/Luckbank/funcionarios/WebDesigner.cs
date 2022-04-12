using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luckbank.funcionarios
{
    public  class WebDesigner : Funcionario
    {

        public WebDesigner(double salario, string nome, string cpf) : base(salario, nome, cpf)
        {
            
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17; 
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}

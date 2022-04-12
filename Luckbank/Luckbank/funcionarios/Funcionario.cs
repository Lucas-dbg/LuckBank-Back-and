using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luckbank.funcionarios
{
    public abstract class Funcionario
    {
        public Funcionario(double salario, string nome, string cpf)
        {
            TotalFuncionarios++;
            CPF = cpf;
            Salario = salario;
            Nome = nome;
        }

        public static int TotalFuncionarios { get; private set; }

       
        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }

        
        public abstract double GetBonificacao();

        public abstract void AumentarSalario();
        
    }
}

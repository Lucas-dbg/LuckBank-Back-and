using Luckbank.funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luckbank
{
    internal class GerenciadorBonificacao
    {
        private static double _totalBonificação;

        public void SomarBonificacao(Funcionario funcionario)
        {
            _totalBonificação += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificação;
        }
    }
}

using Luckbank.funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luckbank.Sistemas
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}

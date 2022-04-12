using System;

namespace Luckbank
{

    public class Cliente
    {
        public Cliente(string profissao, string nome, string cpf)
        {
            Profissao = profissao;
            Nome = nome;
            CPF = cpf;
        }

        public string Profissao { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
    }
}



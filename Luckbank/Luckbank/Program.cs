using Luckbank.funcionarios;
using Luckbank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Luckbank
{
    class Program
    {
        static void Main(string[] args)
        {
            TestandoOperacoesBanco();
            Console.ReadLine();
        }

        public static void TestandoOperacoesBanco()
        {
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("Numero de contas do Luckbank até o momento " + ContaCorrente.TotalContasCriadas);
            Console.WriteLine("****************************************************************************************");

            Cliente rodrigo = new Cliente("Encanador", "Rodrigo Ferreira Mota", "147.554.749-32");
            Cliente sabrina = new Cliente("Estilista", "Sabrina Marone Ferdnanda", "787.121.888-44");
            ContaCorrente contaRodrigo = new ContaCorrente(896, 595959, rodrigo);
            ContaCorrente contaSabrina = new ContaCorrente(359, 151515, sabrina);

            Console.WriteLine("Saldo Rodrigo antes da transferência " + contaRodrigo.Saldo);
            Console.WriteLine("Saldo Sabrina antes da transferência " + contaSabrina.Saldo);

            contaRodrigo.Transferir(30, contaSabrina);

            Console.WriteLine("Saldo Rodrigo depois da transferência " + contaRodrigo.Saldo);
            Console.WriteLine("Saldo Sabrina depois da transferência " + contaSabrina.Saldo);

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("Numero de contas do Luckbank até o momento " + ContaCorrente.TotalContasCriadas);
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("---------------------------------------------------------------------------");

            Cliente veronica = new Cliente("Advogada", "Verônica Romero Carvalho", "467.594.349-66");
            ContaCorrente contaVeronica = new ContaCorrente(599, 78787878, veronica);
            Console.WriteLine("Valor do saldo da veronica antes do saque " + contaVeronica.Saldo);
            contaVeronica.Sacar(15);
            Console.WriteLine("Valor do saldo da veronica depois do saque " + contaVeronica.Saldo);

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("Numero de contas do Luckbank até o momento " + ContaCorrente.TotalContasCriadas);
            Console.WriteLine("****************************************************************************************");

            Console.WriteLine("---------------------------------------------------------------------------");

            Cliente renan = new Cliente("Desenhista", "Renan dos Anjos Calisto", "123.456.789-00");
            ContaCorrente contaRenan = new ContaCorrente(144, 5656565, renan);
            Console.WriteLine("Valor do saldo da Renan antes do Deposito " + contaRenan.Saldo);
            contaRenan.Depositar(350);
            Console.WriteLine("Valor do saldo da Renan depois do Deposito " + contaRenan.Saldo);

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("Numero de contas do Luckbank até o momento " + ContaCorrente.TotalContasCriadas);
            Console.WriteLine("****************************************************************************************");
       
            
            contaRenan.Titular = new Cliente("Engenheiro", "Reeena", "111.111.111-88");
            contaRenan.Titular.Nome = "Renan Peixoto Cathula";
            contaRenan.Titular.Profissao = "Massagista";
            contaRenan.Titular.CPF = "784.964.396-55";
            Console.WriteLine("Nome completo do Renan {0}", contaRenan.Titular.Nome);
            Console.WriteLine("CPF do Renan {0}", contaRenan.Titular.CPF);
            Console.WriteLine("Profissão do Renan {0}", contaRenan.Titular.Profissao);
        }

        public static void TestandoFuncaoAumentarSalario()
        {
            WebDesigner Reinaldo = new WebDesigner(2300, "Reinaldo Janequine Pascoal", "898.222.369.51");

            Console.WriteLine("Nome completo do Reinaldo: " + Reinaldo.Nome);
            Console.WriteLine("CPF do Reinaldo: " + Reinaldo.CPF);
            Console.WriteLine("Salário do Reinaldo: " + Reinaldo.Salario);
            Console.WriteLine("Bonificação do Reinaldo: " + Reinaldo.GetBonificacao());

            Console.WriteLine("-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/");

            Diretor Joelmma = new Diretor(5000, "Joelmma Marivith Josecovith", "189.374.965.13", "339");
            Console.WriteLine("Nome completo da Joelmma: " + Joelmma.Nome);
            Console.WriteLine("CPF da Joelmma: " + Joelmma.CPF);
            Console.WriteLine("Salario da Joelmma: " + Joelmma.Salario);
            Console.WriteLine("Bonificação da Joelmma: " + Joelmma.GetBonificacao());
            Console.WriteLine(Joelmma.Salario);

            Console.WriteLine("-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/");

            GerenciadorBonificacao totalBonificacao = new GerenciadorBonificacao();
            totalBonificacao.SomarBonificacao(Reinaldo);
            totalBonificacao.SomarBonificacao(Joelmma);
            Console.WriteLine("TOTAL DE BONIFICAÇÕES: " + totalBonificacao.GetTotalBonificacao());

            Console.WriteLine("-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/");

            Console.WriteLine("Testando nova funcionalidade do sistema: AUMENTAR SALÁRIO DOS FUNCIONÁRIOS");
            Console.WriteLine("Salário do Reinaldo antes do aumento: " + Reinaldo.Salario);
            Console.WriteLine("Aumentando o Salário do Reinaldo...");
            Reinaldo.AumentarSalario();
            Console.WriteLine("Salário do Reinaldo depois do aumento: " + Reinaldo.Salario);
            Console.WriteLine(" ");
            Console.WriteLine("Salário da Joelmma antes do aumento: " + Joelmma.Salario);
            Console.WriteLine("Aumentando o Salário da Joelmma...");
            Joelmma.AumentarSalario();
            Console.WriteLine("Salário da Joelmma depois do aumento: " + Joelmma.Salario);

            Console.WriteLine("-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/-/");
        }

        public static void Sistema()
        {
            Diretor aufredo = new Diretor(6000, "Aufredo Rodrigues da Mata", "477.166.324-25", "123");
            SistemaInterno sistemaInterno = new SistemaInterno();

            Console.WriteLine("AUTENTICAÇÃO DO DIRETOR ALFREDO... " + sistemaInterno.Logar(aufredo, "25526556"));
            
            Console.WriteLine("++++++++++-----------++++++++++-----------++++++++++-----------++++++++++-----------");

            GerenteGeral gustavo = new GerenteGeral(4700, "Gustavo Gimenez Gusmão Girth", "123.321.123.12", "321");

            Console.WriteLine("AUTENTICAÇÃO... " + sistemaInterno.Logar(gustavo, "321"));
        }

        public static void Bonificacao()
        {

            Diretor leandro = new Diretor(10000, "Leandro Filisteu", "155.968.712-37", "741");

            Console.WriteLine("Bonificação do Leandro neste mês: " + leandro.GetBonificacao());

            GerenteGeral francisca = new GerenteGeral(7000, "Francisca da Cunha Reinsth", "114.845.678-11", "874");

            Console.WriteLine("Bonificação da Francisca neste mês: " + francisca.GetBonificacao());

            AnalistaCredito jhonson = new AnalistaCredito(3000, "Jhonson Figueredo Pascolito", "123.696.852-72");

            Console.WriteLine("Bonificação do Jhonson neste mês: " + jhonson.GetBonificacao());

            WebDesigner karina = new WebDesigner(3000, "Karina dos Anjos Peixoto", "581.591.773-76");

            Console.WriteLine("Bonificação da Karina neste mês: " + karina.GetBonificacao());

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            gerenciador.SomarBonificacao(leandro);
            gerenciador.SomarBonificacao(francisca);
            gerenciador.SomarBonificacao(jhonson);
            gerenciador.SomarBonificacao(karina);

            Console.WriteLine("A empresa gastou um total de R${0} em bonificação", gerenciador.GetTotalBonificacao());

        }
    }
}

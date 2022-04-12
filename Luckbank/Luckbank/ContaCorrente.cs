using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luckbank
{
    public class ContaCorrente
    {
        
        public ContaCorrente(int agencia, int conta, Cliente titular)
        {
            Agencia = agencia;
            NumeroConta = conta;
            Titular = titular;

            TotalContasCriadas++;
        }

        private int _agencia;
        public int Agencia {
            get
            {
                return _agencia;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                _agencia = value;
            } 
        }

        private int _numeroConta;
        public int NumeroConta {
            get
            {
                return _numeroConta;
            }
            set
            {
                if(value <= 0)
                {
                    return;
                }
                _numeroConta = value;   
            } 
        }

        private double _saldo = 100;
        public double Saldo 
        {
            get
            {
                return _saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                _saldo += value;
            }
        }


        public Cliente Titular { get; set; }

        public static int TotalContasCriadas { get; private set; }

        public bool Sacar(double valor)
        {
            if( _saldo < valor )
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente destinatario)
        {
            if(_saldo >= valor)
            {
                _saldo -= valor;
                destinatario.Depositar(valor);
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}




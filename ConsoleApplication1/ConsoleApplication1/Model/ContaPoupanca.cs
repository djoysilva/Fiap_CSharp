using ConsoleApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        public decimal Taxa { get; set; }
        public readonly decimal _rendimento;

        public ContaPoupanca(decimal valor)
        {
            this._rendimento = valor;
        }

        public ContaPoupanca()
        {
        }

        public decimal CalcularRetornoInvestimento()
        {
            return Saldo * _rendimento;
        }

        public override void Retirar(decimal valor)
        {
            if (Saldo < valor + Taxa)
            {
                throw new Exception("Saldo insuficiente");
            }
            else
            {
                Saldo -= valor + Taxa;
            }
        }
    }
}

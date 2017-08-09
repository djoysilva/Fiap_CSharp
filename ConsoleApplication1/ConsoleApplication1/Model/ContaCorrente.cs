using ConsoleApplication1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    sealed class ContaCorrente : Conta
    {
        public TipoConta tipo { get; set; } 
           
        public override void Retirar(decimal valor)
        {
            if (tipo == TipoConta.Comum && Saldo < valor)
            {
                throw new Exception("Saldo insuficiente");
            }else
            {
                Saldo -= valor;
            }
        }
    }
}

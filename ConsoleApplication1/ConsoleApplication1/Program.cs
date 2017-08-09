using ConsoleApplication1.Model;
using Fiap.Banco.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente();
            ContaPoupanca cp = new ContaPoupanca(10);
            decimal valor = 0;

            cc.Agencia = 10;
            cc.DataAbertura = DateTime.Now;
            cc.Numero = 1;
            // cc.Saldo = 10;
            cc.tipo = TipoConta.Comum;

            cc.Depositar(10);
            Console.WriteLine("Saldo CC: " + cc.Saldo);
            Console.ReadLine();

            cc.Retirar(10);
            Console.WriteLine("Saldo CC: " + cc.Saldo);
            Console.ReadLine();



            cp.Agencia = 20;
            cp.DataAbertura = DateTime.Now;
            cp.Numero = 2;
            //cp.Saldo = 10;
            cp.Taxa = 0.06m;//decimal

            valor = cp.CalcularRetornoInvestimento();
            Console.WriteLine("Rendimento CP: " + valor);
            Console.ReadLine();

            cp.Depositar(20);
            Console.WriteLine("Saldo CP: " + cp.Saldo);
            Console.ReadLine();

            cp.Retirar(10);
            Console.WriteLine("Saldo CP: " + cp.Saldo);
            Console.ReadLine();


        }
    }
}

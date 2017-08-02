using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fiap.HelloWorld.UI.Model;
using System.Collections.Generic;


namespace Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciar um carro
            Carro carro = new Carro();
            carro.Modelo = "Fusca";
            carro.Placa = "JOY-9000";

            //imprime o modelo
            Console.WriteLine("Carro: " + carro.Modelo +  "\nPlaca: " + carro.Placa);
            Console.ReadLine();
        }
    }
}

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
            Carro carro = new Carro("Fusca");
            carro.Placa = "JOY-9000";

            //instanciar onibus
            Onibus onibus = new Onibus("modelo")
            {
                //_modelo = "Oi",
                _linha = "Barra Funda"
            };

            //Criar uma lista de aviao
            var lista = new List<Aviao>();
            lista.Add(new Aviao("A380"));
            lista.Add(new Aviao("14 BIS"));
            lista.Add(new Aviao("F18"));
            //Exibir os modelos de avioes

            foreach(var modelo in lista)
            {
                Console.WriteLine(modelo.Modelo);
            }
            //imprime o modelo
            Console.WriteLine("Carro: " + carro.Modelo +  "\nPlaca: " + carro.Placa);
            Console.ReadLine();
        }
    }
}

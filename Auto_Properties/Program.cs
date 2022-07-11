using System;
using System.Globalization;

namespace Auto_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Testes para entender o Encapsulamento

            Produto p = new Produto("Tv", 500.00, 10);

            p.Nome = "T";
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);


            Console.ReadKey();
        }
    }
}

using System;
using System.Globalization;

namespace Encapsulamento_pt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Testes para entender o Encapsulamento

            Produto p = new Produto("Tv", 500.00, 10);

            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome());
            Console.WriteLine(p.GetPreco());
            

            Console.ReadKey();
        }
    }
}

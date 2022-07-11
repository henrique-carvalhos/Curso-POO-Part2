using System;
using System.Globalization;

namespace Sobrecarga
{
    internal class Produto
    {
        //Atributos
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Sobrecarga com o Construtor padrão
        public Produto(){
        }

        //Construtor
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Contrutor recebendo apenas dois parâmetros de entrada.(Sobrecarga)
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)//recebe um dado de entrada (qtd declarado no programa principal).
        {
            Quantidade += quantidade;// Quantidade  = Quantidade + quantidade.
        }

        public void RemoverProdutos(int quantidade)//recebe um dado de entrada (qtd declarado no programa principal).
        {
            Quantidade -= quantidade;// Quantidade  = Quantidade - quantidade.
        }

        //Método para tranformar um produto na forma de String.
        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

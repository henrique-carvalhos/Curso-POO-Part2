using System;
using System.Globalization;

namespace Properties
{
    internal class Produto
    {
        //Encapsulamento com Properties

        //Atributos
        private string _nome;//private não pode ser acessado por outra classe, por convensão atributos privativos são escritos com "_" seguido de letras minúsculas.
        private double _preco;
        private int _quantidade;

        //Construtor padrão
        public Produto()
        {
        }

        //Construtor com três argumentos
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Properties
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)//recebe um dado de entrada (qtd declarado no programa principal).
        {
            _quantidade += quantidade;// Quantidade  = Quantidade + quantidade.
        }

        public void RemoverProdutos(int quantidade)//recebe um dado de entrada (qtd declarado no programa principal).
        {
            _quantidade -= quantidade;// Quantidade  = Quantidade - quantidade.
        }

        //Método para tranformar um produto na forma de String.
        public override string ToString()
        {
            return _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

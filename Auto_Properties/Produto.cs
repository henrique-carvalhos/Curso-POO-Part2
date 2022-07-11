using System;
using System.Globalization;

namespace Auto_Properties
{
    internal class Produto
    {
        //Encapsulamento com Auto Properties

        //Atributos
        private string _nome;//private não pode ser acessado por outra classe, por convensão atributos privativos são escritos com "_" seguido de letras minúsculas.
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }


        //Construtor padrão
        public Produto()
        {
        }

        //Construtor com três argumentos
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
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
            return _nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

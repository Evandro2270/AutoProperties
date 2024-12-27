using System.Globalization;

namespace VendasPodutos
{
    internal class Produto
    {
        CultureInfo CI = CultureInfo.InvariantCulture;

        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        public Produto()
        {
        }

        public string Nome
        {
            get { return _nome; } // Properties
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public double ValorTotalemEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
                + ", $ "
                + Preco.ToString("F2", CI)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalemEstoque().ToString("F2", CI);

        }

    }
}

using System;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploProduto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public void RemoverProdutos(int retirar)
        {
            Quantidade -= retirar;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public double ValorTotalEstoque() {
            return Preco * Quantidade;    
        }

        public override string ToString()
        {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidade(s), Total: $" + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

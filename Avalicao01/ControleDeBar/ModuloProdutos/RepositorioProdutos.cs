using ControleDeBar.ConsoleApp.Compartilhado;
using System.Collections.Generic;

namespace ControleDeBar.ConsoleApp.ModuloProdutos
{
    public class RepositorioProdutos : EntidadeBase
    {
        private List<Produtos> produtos;

        public RepositorioProdutos()
        {
            produtos = new List<Produtos>();
        }

        public void AdicionarProduto(Produtos produto)
        {
            produtos.Add(produto);
        }

        public List<Produtos> ObterProdutos()
        {
            return produtos;
        }
    }
}

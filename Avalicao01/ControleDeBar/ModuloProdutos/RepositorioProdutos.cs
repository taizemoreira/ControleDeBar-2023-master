using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcons;
using System.Collections.Generic;

namespace ControleDeBars.ConsoleApp.ModuloProdutos
{
    public class Produtos : EntidadeBase
    {
        Mesa = mesa;
        Garcom = garcom;
        Itens = new List<ItemPedido>();

        public Produtos(Mesa mesa, Garcom garcom, Itens itens <ItemPedido> )
        {
            this.mesa = mesa;
            this.garcom = garcom;

            this.itens.< ItemPedido > ();
        }

        public class Produtos
        {
            private List<Produto> produtos;

            public Produtos()
            {
                produtos = new List<Produto>();
            }

            public void AdicionarProduto(Produto produto)
            {
                produtos.Add(produto);
            }

            public void RemoverProduto(Produto produto)
            {
                produtos.Remove(produto);
            }

            public List<Produto> ObterProdutos()
            {
                return produtos;
            }
        }
    }

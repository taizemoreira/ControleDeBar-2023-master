using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcons;
using System.Collections;

namespace ControleDeBars.ConsoleApp.ModuloPedidos
{
    public class Pedidos : EntidadeBase
    {
        Mesa = mesa;
        Garcom = garcom;
        Itens = new List<ItemPedido>();

        public Pedidos(Mesa mesa, Garcom garcom, Itens itens <ItemPedido> )
        {
            this.mesa = mesa;
            this.garcom = garcom;

            this.itens.< ItemPedido > ();
        }

        public void AdicionarItem(ItemPedido item)
        {
            Itens.Add(item);
        }

        public void RemoverItem(ItemPedido item)
        {
            Itens.Remove(item);
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var item in Itens)
            {
                total += item.Subtotal;
            }
            return total;
        }
    }

    public class ItemPedido
    {
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }

        public decimal Subtotal => Produto.Preco * Quantidade;
    }
}

using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcons;
using ControleDeBar.ConsoleApp.ModuloPedidos;
using System.Collections;

namespace ControleDeBar.ModuloPedidos
{
    public class RepositorioPedidos : EntidadeBase
    {
        private List<Pedidos> pedidos;

        public RepositorioPedidos()
        {
            pedidos = new List<Pedidos>();
        }

        public void AdicionarPedido(Pedidos pedidos)
        {
            pedidos.Add(pedidos);
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public List<Pedidos> ObterPedidos()
        {
            return pedidos;
        }

        public List<Pedidos> ObterPedidosPorMesa(int numeroMesa)
        {
            List<Pedidos> pedidosPorMesa = new List<Pedidos>();
            foreach (Pedidos pedidos in pedidos)
            {
                if (pedidos.Mesa == numeroMesa)
                {
                    pedidosPorMesa.Add(pedidos);
                }
            }
            return pedidosPorMesa;
        }

        public override ArrayList Validar()
        {
            throw new NotImplementedException();
        }
    }
}
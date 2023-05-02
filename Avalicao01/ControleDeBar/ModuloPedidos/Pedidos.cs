using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcons;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloPedidos
{
    public class Pedidos : EntidadeBase
    {
        public Pedidos(ArrayList pedidos)
        {
            this.listaRegistros = pedidos;
        }

        public int Mesa { get; internal set; }

        public override pedidos SelecionarPorId(int id)
        {
            return (pedidos)base.SelecionarPorId(id);
        }

        internal void Add(Pedidos pedidos)
        {
            throw new NotImplementedException();
        }
    }

    public class pedidos
    {
        public static explicit operator pedidos(EntidadeBase v)
        {
            throw new NotImplementedException();
        }
    }
}
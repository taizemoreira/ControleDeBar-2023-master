using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcons;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloPedidos
{
    public class Pedidos : RepositorioBase
    {
        public Pedidos(ArrayList pedidos)
        {
            this.listaRegistros = pedidos;
        }

        public override pedidos SelecionarPorId(int id)
        {
            return (pedidos)base.SelecionarPorId(id);
        }
    }
}
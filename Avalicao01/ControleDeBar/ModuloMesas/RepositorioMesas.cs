using ControleDeBar.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloMesas
{
    public class RepositorioMesas : EntidadeBase
    {
        public RepositorioMesas()
        {
        }

        public ControleDeBar(ArrayList listaMesas)
        {
            this.listaRegistros = listaMesas;
        }

        public override Mesas SelecionarPorId(int id)
        {
            return (Mesas)base.SelecionarPorId(id);
        }

        internal void AdicionarMesa(Mesa mesa1)
        {
            throw new NotImplementedException();
        }
    }
}

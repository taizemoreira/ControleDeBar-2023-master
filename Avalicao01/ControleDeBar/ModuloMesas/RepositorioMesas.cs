using ControleDeBar.Compartilhado;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloMesas
{
    public class ControleDeBar : RepositorioBase
    {
        public ControleDeBar(ArrayList listaMesas)
        {
            this.listaRegistros = listaMesas;
        }

        public override Mesas SelecionarPorId(int id)
        {
            return (Mesas)base.SelecionarPorId(id);
        }
    }
}

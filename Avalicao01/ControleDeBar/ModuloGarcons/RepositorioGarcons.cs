using ControleDeBar.Compartilhado;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloGarcons
{
    public class ControleDeBar : RepositorioBase
    {
        public ControleDeBar(ArrayList listaGarcons)
        {
            this.listaRegistros = listaGarcons;
        }

        public override Garcons SelecionarPorId(int id)
        {
            return (Garcons)base.SelecionarPorId(id);
        }
    }
}

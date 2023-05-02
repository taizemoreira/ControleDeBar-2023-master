using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcons;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloProdutos
{
    public class Produtos : RepositorioBase
    {
        public Produtos(ArrayList produtos)
        {
            this.listaRegistros = produtos;
        }

        public override produtos SelecionarPorId(int id)
        {
            return (produtos)base.SelecionarPorId(id);
        }
    }
}
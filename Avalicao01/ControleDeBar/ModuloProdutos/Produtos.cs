using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcons;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloProdutos
{
    public class Produtos : EntidadeBase
    {
        public Produtos(int idProduto, ArrayList produtos)
        {
            this.listaRegistros = produtos;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            throw new NotImplementedException();
        }

        public override produtos SelecionarPorId(int id)
        {
            return (produtos)base.SelecionarPorId(id);
        }

        public override ArrayList Validar()
        {
            throw new NotImplementedException();
        }
    }

    public class produtos
    {
        public static explicit operator produtos(EntidadeBase v)
        {
            throw new NotImplementedException();
        }
    }
}
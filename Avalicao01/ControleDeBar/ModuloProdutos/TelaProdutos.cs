using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloProdutos;
using System.Collections;

namespace ControleDeBar.ModuloProdutos
{
    public class TelaProdutos : TelaBase
    {
        public TelaProdutos(RepositorioProdutos repositorioProdutos)
        {
            repositorioBase = repositorioProdutos;
            nomeEntidade = "Produtos";
            sufixo = "os";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Mesa", "Garçom", "Itens do pedido");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Produtos produtos in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", produtos.id, produtos.nome);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("código do produto: ");
            int idProduto = Convert.ToInt32(Console.ReadLine());

            Console.Write("nome do produto: ");
            string produtoNome= Console.ReadLine();

            return new Produtos(idProduto, produtoNome);
        }
    }
}

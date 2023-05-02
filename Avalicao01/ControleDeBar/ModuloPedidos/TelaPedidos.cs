using ControleDeBar.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloPedidos
{
    public class TelaPedidos : TelaBase
    {

        public TelaPedidos(RepositorioPedidos repositorioPedidos)
        {
            repositorioBase = repositorioPedidos;
            nomeEntidade = "Pedidos";
            sufixo = "os";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Mesa", "Garçom", "Itens do pedido");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Pedidos pedidos in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", numeroMesa.id, nomeGarcom.nome);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Numero da mesa: ");
            string numeroMesa = Console.ReadLine();

            Console.Write("Quantidade de lugares: ");
            string quantidadeLugares = Console.ReadLine();

            return new Mesa(numeroMesa, quantidadeLugares);
        }
    }
}

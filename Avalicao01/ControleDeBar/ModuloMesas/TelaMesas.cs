using ControleDeBar.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloMesas
{
    public class TelaMesas : TelaBase
    {

        public TelaMesas(RepositorioMesas repositorioMesas)
        {
            repositorioBase = repositorioMesas;
            nomeEntidade = "Mesas";
            sufixo = "as";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Nome", "CPF");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Mesas mesas in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", numeroMesa.id, numeroMesa.numero);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Numero da mesa: ");
            string numeroMesa = Console.ReadLine();

            Console.Write("Quantidade de lugares: ");
            string quantidadeLugares = Console.ReadLine();
         
            return new Garcom(numeroMesa, quantidadeLugares);
        }
    }
}

using ControleDeBar.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloGarcons
{
    public class TelaGarcons : TelaBase
    {

        public TelaGarcons(RepositorioGarcons repositorioGarcons)
        {
            repositorioBase = repositorioGarcons;
            nomeEntidade = "Garçom";
            sufixo = "ns";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", "Id", "Nome", "CPF");

            Console.WriteLine("--------------------------------------------------------------------");

            foreach (Garcons garcons in registros)
            {
                Console.WriteLine("{0, -10} | {1, -20} | {2, -20}", garcons.id, garcons.nome, garcons.telefone);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o cpf: ");
            string cpf = Console.ReadLine();

            Console.Write("Digite o endereço: ");
            string endereco = Console.ReadLine();

            Console.Write("Digite o telefone: ");
            string telefone = Console.ReadLine();

            return new Garcom(nome, cpf, endereco, telefone);
        }
    }
}

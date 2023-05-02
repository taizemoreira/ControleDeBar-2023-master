using ControleDeBar.ConsoleApp.ModuloGarcons;
using ControleDeBar.ConsoleApp.ModuloMesas;
using ControleDeBar.ConsoleApp.ModuloProdutos;
using System;
using System.Collections.Generic;

namespace ControleDeBar.ConsoleApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Produtos
            RepositorioProdutos repositorioProdutos = new RepositorioProdutos();
            repositorioProdutos.AdicionarProduto(new Produto("Cerveja", 5.50m));
      
            Produto hamburguer = new Produto("Hambúrguer", 12.90m);
            Produto cerveja = new Produto("Cerveja", 5.00m);
            Produto caipirinha = new Produto("Caipirinha", 10.00m);
            Produto batataFrita = new Produto("Batata frita", 7.90m);

            //Garçons
            RepositorioGarcons repositorioGarcons = new RepositorioGarcons();
            
            Garcom joaoAmorim = new Garcom("João Amorim");
            Garcom benedito = new Garcom("Benedito Pão de Mel");
            Garcom herculano = new Garcom("Herculano Pão de Queijo");
            Garcom dolores = new Garcom("Dolores Fuertes de Barriga");            
            repositorioGarcons.AdicionarGarcom(joaoAmorim);
            repositorioGarcons.AdicionarGarcom(benedito);
            repositorioGarcons.AdicionarGarcom(herculano);
            repositorioGarcons.AdicionarGarcom(dolores);

            //Mesas
            RepositorioMesas repositorioMesas = new RepositorioMesas();

            Mesa mesa1 = new Mesa(1);
            Mesa mesa2 = new Mesa(2);
            Mesa mesa3 = new Mesa(3);
            Mesa mesa4 = new Mesa(4);
            repositorioMesas.AdicionarMesa(mesa1);
            repositorioMesas.AdicionarMesa(mesa2);
            repositorioMesas.AdicionarMesa(mesa3);
            repositorioMesas.AdicionarMesa(mesa4);

            //Pedidos
            ControladorPedidos controladorPedidos = new ControladorPedidos(repositorioProdutos, repositorioGarcons, repositorioMesas);

            controladorPedidos.RegistrarPedido(joaoAmorim, mesa2, cerveja);
            controladorPedidos.RegistrarPedido(dolores, mesa1, caipirinha);
            controladorPedidos.RegistrarPedido(herculano, mesa3, hamburguer);
            controladorPedidos.RegistrarPedido(benedito, mesa4, batataFrita);

            //Faturamento
            decimal faturamento = controladorPedidos.FaturamentoDiario();
            Console.WriteLine($"Faturamento do dia: R$ {faturamento}");
            
            Console.ReadLine();
        }
    }

    internal class Mesa
    {
        private int v;

        public Mesa(int v)
        {
            this.v = v;
        }
    }

    internal class Garcom
    {
        private string v;

        public Garcom(string v)
        {
            this.v = v;
        }
    }

    internal class Produto : Produtos
    {
        private string v1;
        private decimal v2;

        public Produtos(string v1, decimal v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }

    internal class ControladorPedidos
    {
        private RepositorioProdutos repositorioProdutos;
        private RepositorioGarcons repositorioGarcons;
        private RepositorioMesas repositorioMesas;

        public ControladorPedidos(RepositorioProdutos repositorioProdutos, RepositorioGarcons repositorioGarcons, RepositorioMesas repositorioMesas)
        {
            this.repositorioProdutos = repositorioProdutos;
            this.repositorioGarcons = repositorioGarcons;
            this.repositorioMesas = repositorioMesas;
        }

        internal decimal FaturamentoDiario()
        {
            throw new NotImplementedException();
        }

        internal void RegistrarPedido(Garcom joaoAmorim, Mesa mesa2, Produto cerveja)
        {
            throw new NotImplementedException();
        }
    }
}

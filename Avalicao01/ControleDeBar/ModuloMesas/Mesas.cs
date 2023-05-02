using ControleDeBar.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloMesas
{
    public class Mesas : EntidadeBase
    {
        public string numeroMesa;
        public int quantidadeLugares;
        public int mesa;
        

        public Mesas(string numeroMesa, int quantidadeLugares)
        {
            this.numeroMesa = numeroMesa;
            this.quantidadeLugares = quantidadeLugares;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesas mesaAtualizada = (Mesas)registroAtualizado;

            this.numeroMesa = numeroMesa;
            this.quantidadeLugares = quantidadeLugares;
        }
        public override ArrayList Validar()
        {
            throw new NotImplementedException();
        }
    }
}
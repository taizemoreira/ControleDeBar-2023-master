using ControleDeBar.ConsoleApp.Compartilhado;
using System.Collections;

namespace ControleDeBar.ConsoleApp.ModuloGarcons
{
    public class Garcons : EntidadeBase
    {
        public string nome;
        public int cpf;
        public string endereco;
        public int telefone;

        public Garcons(string nome, int cpf, string endereco, int telefone)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.telefone = telefone;           
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcons garconAtualizado = (Garcons)registroAtualizado;

            this.nome = garconAtualizado.nome;
            this.cpf = garconAtualizado.cpf;
            this.endereco = garconAtualizado.endereco;
            this.telefone = garconAtualizado.telefone;           
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(nome.Trim()))
                erros.Add("O campo \"nome\" é obrigatório");

            if (nome.Length <= 3)
                erros.Add("O campo \"nome\" precisa ter mais que 3 letras");

            if (string.IsNullOrEmpty(cpf.Trim()))
                erros.Add("O campo \"CPF\" é obrigatório");            

            return erros;
        }
    }
}
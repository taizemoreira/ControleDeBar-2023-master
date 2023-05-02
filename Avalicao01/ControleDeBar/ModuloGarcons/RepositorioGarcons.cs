using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections.Generic;

namespace ControleDeBar.ConsoleApp.ModuloGarcons
{
    public class RepositorioGarcons : EntidadeBase
    {
        public RepositorioGarcons repositorioGarcons = null;

        private List<Garcom> garcons;

        public RepositorioGarcons()
        {
            garcons = new List<Garcom>();
        }

        public void AdicionarGarcon(Garcons garcons)
        {
            garcons.Add(garcons);
        }

        public List<Garcom> ObterGarcons()
        {
            return garcons;
        }

        public Garcom ObterGarconPorId(int id)
        {
            foreach (Garcom garcons in garcons)
            {
                if (garcons.Id == id)
                {
                    return garcons;
                }
            }
            return null;
        }

        internal void AdicionarGarcom(Garcom joaoAmorim)
        {
            throw new NotImplementedException();
        }
    }
}

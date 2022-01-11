using System;
using System.Collections.Generic;
using Desafio.Decola.Tech.interfaces;

namespace Desafio.Decola.Tech
{
    public class RepositorioSeries : IRepositorio<Series>
    {
        private Dictionary <int , Series> DicionarioDeSeries = new Dictionary<int, Series>(); 
        public void Excluir(int chave)
        {
            DicionarioDeSeries.Remove(chave);
        }

        public void Inserir(int chave, Series entidade)
        {
            DicionarioDeSeries.Add(chave, entidade);
        }

        public Dictionary<int, Series> Lista()
        {
            return DicionarioDeSeries;
        }

        public int NextID(Dictionary <int, string> U)
        {
            int i=0;
            bool x=true;
            while (!x)
            {
                 x = U.ContainsKey(i);
                 if(x == false)
                    break;
                 i++;
            }
            return i;
        }

            public void Update(int chave, Series entidade)
        {
            DicionarioDeSeries[chave] = entidade;
        }
    }
}
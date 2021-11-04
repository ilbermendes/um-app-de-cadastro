using System.Collections.Generic;
using RegSeries.Interfaces;

namespace RegSeries
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        private List<Filme> listaSerie = new List<Filme>();

        public void Atualiza(int id, Filme obj)
        {
             listaSerie[id] = obj;
        }

        public void Exclui(int id)
        {
             listaSerie[id].Excluir();
        }

        public void Insere(Filme obj)
        {
            listaSerie.Add(obj);
        }

        public List<Filme> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
             return listaSerie.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
using System.Collections.Generic;
using RegSeries.Interfaces;

namespace RegSeries
{
    public class FilmeRepositorio : IRepositorio<Filme>
    {
        private List<Filme> listaFilme = new List<Filme>();

        public void Atualiza(int id, string titulo, int ano, string pais)
        {
             listaFilme[id].AtualizaFilme(titulo, ano, pais);
        }

        public void Exclui(int id)
        {
             listaFilme[id].Excluir();
        }

        public void Insere(Filme obj)
        {
            listaFilme.Add(obj);
        }

        public List<Filme> Lista()
        {
            return listaFilme;
        }

        public int ProximoId()
        {
             return listaFilme.Count;
        }

        public Filme RetornaPorId(int id)
        {
            return listaFilme[id];
        }
    }
}
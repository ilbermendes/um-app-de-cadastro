using System;
using System.Collections.Generic;
using RegSeries.Interfaces;

namespace RegSeries
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void Atualiza(int id, string titulo, int ano, string pais)
        {
            listaSerie[id].AtualizaSerie(titulo, ano, pais);
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie obj)
        {
            listaSerie.Add(obj);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
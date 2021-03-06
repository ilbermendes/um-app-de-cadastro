using System.Collections.Generic;

namespace RegSeries.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int id);
        void Insere(T obj);
        void Exclui(int id);
        void Atualiza(int id, string titulo, int ano, string pais);
        int ProximoId();

    }
}
using System.Collections.Generic;

namespace Series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> lista();
         T retornaPorId(int id);
         void insere(T objeto);
         void exclui(int id);
         void atualiza(int id, T objeto);
         int proximoId();
    }
}
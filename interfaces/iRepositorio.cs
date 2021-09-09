using System.Collections.Generic;

namespace DIO.series.interfaces
{
    public interface iRepositorio<t>
    {
         List<t> lista();
         t retornaPorId(int id);
         void insere (t entidade);
         void exclui (int id);
         void atualiza (int id, t entidade);
         int proximoId();



    }
}
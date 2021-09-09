using System;
using System.Collections.Generic;
using DIO.series.interfaces;

namespace DIO.series
{
    public class filmeRepositorio : iRepositorio<filme>
    {
        public filmeRepositorio()
        {
        }

        public void atualiza(int id, filme entidade)
        {
            throw new NotImplementedException();
        }

        public void exclui(int id)
        {
            throw new NotImplementedException();
        }

        public void insere(filme entidade)
        {
            throw new NotImplementedException();
        }

        public List<filme> lista()
        {
            throw new NotImplementedException();
        }

        public int proximoId()
        {
            throw new NotImplementedException();
        }

        public filme retornaPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using DIO.series.interfaces;

namespace DIO.series
{
    public class serieRepositorio : iRepositorio<Serie>
    {
        private List<Serie> listaserie = new List <Serie>(); 
        public void atualiza(int id, Serie objeto)
        {
            listaserie [id] = objeto;  
        }

        public void exclui(int id)
        {
            listaserie[id].Excluir();
        }

        public void insere(Serie objeto)
        {
            listaserie.Add(objeto);
        }

        public List<Serie> lista()
        {
            return listaserie;
        }

        public int proximoId()
        {
            return listaserie.Count;
        }

        public Serie retornaPorId(int id)
        {
            return listaserie [id];
        }
    }


}
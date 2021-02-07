using System;
using System.Collections.Generic;
using Series.Interfaces;

namespace Series.Classes
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();

        public void atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void exclui(int id)
        {
            listaSerie[id].excluir();       // Marcado como excluído
        }

        public void insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> lista()
        {
            return listaSerie;
        }

        public int proximoId()
        {
            return listaSerie.Count;
        }

        public Serie retornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}
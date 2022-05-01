using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_3.Entidades
{
    public class Partidos
    {
        private static List<PartidoEntity> _partidos = new List<PartidoEntity>()
        {
            new PartidoEntity() {Id= 1, Fecha = new System.DateTime(2022,4,12), Lugar = "La bombonera"} ,
            new PartidoEntity() {Id= 2, Fecha = new System.DateTime(2022,4,13), Lugar = "El monumental"},
            new PartidoEntity() {Id= 3, Fecha = new System.DateTime(2022,4,12), Lugar = "Tu vieja"}
        };

        public void addPartido(PartidoEntity partido)
        {
            _partidos.Add(partido);
        }

        public void removePartido(int partidoId)
        {
            _partidos.RemoveAll(x => x.Id == partidoId);
        }

        public List<PartidoEntity> GetPartidos()
        {
            return _partidos;
        }

        public List<PartidoEntity> GetPartidosPorFecha(int dia, int mes, int anio)
        {
           return _partidos.FindAll(x => x.Fecha.Day == dia && x.Fecha.Month == mes && x.Fecha.Year == anio);
        }

        public List<PartidoEntity> GetPartidosPorFechaDate(DateTime fecha)
        {
            return _partidos.FindAll(x => x.Fecha == fecha);
        }

    }
}

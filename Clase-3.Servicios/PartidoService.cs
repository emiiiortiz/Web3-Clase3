using Clase_3.Servicios.Interfaces;
using System;
using Clase_3.Entidades;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace Clase_3.Servicios
{
    public class PartidoService : IPartidoService
    {
       
        Partidos partidos = new Partidos();

        public void AgregarPartido(PartidoEntity partido)
        {
            partidos.addPartido(partido);
        }

        public List<PartidoEntity> ObtenerPartidos()
        {
            return partidos.GetPartidos();
        }

        public void EliminarPartidoSinfirmacion(int partidoId)
        {
            partidos.removePartido(partidoId);
        }

        public List<PartidoEntity> ObtenerPartidosDelDia(int dia, int mes, int anio)
        {
            return partidos.GetPartidosPorFecha(dia, mes, anio);
        }

        public List<PartidoEntity> ObtenerPartidosDelDiaConFecha(IFormCollection colection)
        {
            DateTime fechaElegida = Convert.ToDateTime(colection["Fecha"]);

            return partidos.GetPartidosPorFechaDate(fechaElegida);
        }


    }
}

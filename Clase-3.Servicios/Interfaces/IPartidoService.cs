using Clase_3.Entidades;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace Clase_3.Servicios.Interfaces
{
    public interface IPartidoService
    {
        void AgregarPartido(PartidoEntity partido);

        public List<PartidoEntity> ObtenerPartidos();

        //public PartidoEntity EliminarPartidoConfirmacion(int PartidoId);

        public void EliminarPartidoSinfirmacion(int PartidoId);

        public List<PartidoEntity> ObtenerPartidosDelDia(int dia, int mes, int anio);

        public List<PartidoEntity> ObtenerPartidosDelDiaConFecha(IFormCollection colection);
    }
}
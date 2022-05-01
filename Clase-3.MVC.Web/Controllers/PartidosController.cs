using Clase_3.Entidades;
using Clase_3.MVC.Web.Models;
using Clase_3.Servicios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase_3.MVC.Web.Controllers
{
    public class PartidosController : Controller
    {
        private readonly IPartidoService _partidoService;

        public PartidosController(IPartidoService partidosService)
        {
            _partidoService = partidosService;
        }

        // GET: PartidosController
        public ActionResult Lista()
        {
            return View(_partidoService.ObtenerPartidos());
        }
        #region
        // GET: PartidosController/NuevoBindingManual
        //public ActionResult NuevoBindingManual()
        //{
        //    return View();
        //}

        //// POST: PartidosController/Nuevo
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult NuevoBindingManual(IFormCollection collection)
        //{
        //    try
        //    {
        //        PartidosViewModel nuevoPartido = new PartidosViewModel()
        //        {
        //            Id = __partidos.Max(o => o.Id) + 1,
        //            Fecha = Convert.ToDateTime(collection["Fecha"]),
        //            Lugar = collection["Lugar"]
        //        };
        //        __partidos.Add(nuevoPartido);
        //        return RedirectToAction(nameof(Lista));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        #endregion

        // GET: PartidosController/Nuevo
        public ActionResult Nuevo()
        {
            return View();
        }

        // POST: PartidosController/Nuevo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Nuevo(PartidoEntity partido)
        {
            try
            {
                _partidoService.AgregarPartido(partido);
                return RedirectToAction(nameof(Lista));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult EliminarSinConfirmacion(int id)
        {

            _partidoService.EliminarPartidoSinfirmacion(id);

            return RedirectToAction(nameof(Lista));

        }

    

        [Route("Partidos/DelDia/{dia?}/{mes?}/{anio?}")]
        public ActionResult DelDia(int dia, int mes, int anio)
        {   
            return View(_partidoService.ObtenerPartidosDelDia(dia, mes, anio));
        }

        public ActionResult DelDiaConFecha()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DelDiaConFecha(IFormCollection colection)
        {
            try
            {
                //_partidoService.ObtenerPartidosDelDiaConFecha(colection);
                return View("DelDia", _partidoService.ObtenerPartidosDelDiaConFecha(colection));
            }
            catch
            {
                return View();
            }
            
        }


    }
}

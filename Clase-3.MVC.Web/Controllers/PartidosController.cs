using Clase_3.MVC.Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Clase_3.MVC.Web.Controllers
{
    public class PartidosController : Controller
    {
        public static List<PartidosViewModel> __partidos = new List<PartidosViewModel>()
            {
                new PartidosViewModel() {Id= 1, Fecha = new System.DateTime(2022,4,12), Lugar = "La bombonera"} ,
                new PartidosViewModel() {Id= 2, Fecha = new System.DateTime(2022,4,13), Lugar = "El monumental"} ,

            };

        // GET: PartidosController
        public ActionResult Lista()
        {


            return View(__partidos);
        }

        // GET: PartidosController/NuevoBindingManual
        public ActionResult NuevoBindingManual()
        {
            return View();
        }

        // POST: PartidosController/Nuevo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NuevoBindingManual(IFormCollection collection)
        {
            try
            {
                PartidosViewModel nuevoPartido = new PartidosViewModel()
                {
                    Id = __partidos.Max(o => o.Id) + 1,
                    Fecha = Convert.ToDateTime(collection["Fecha"]),
                    Lugar = collection["Lugar"]
                };
                __partidos.Add(nuevoPartido);
                return RedirectToAction(nameof(Lista));
            }
            catch
            {
                return View();
            }
        }

        // GET: PartidosController/Nuevo
        public ActionResult Nuevo()
        {
            return View();
        }

        // POST: PartidosController/Nuevo
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Nuevo(PartidosViewModel partido)
        {
            try
            {
                __partidos.Add(partido);
                return RedirectToAction(nameof(Lista));
            }
            catch
            {
                return View();
            }
        }

        // GET: PartidosController/Eliminar/5
        public ActionResult Eliminar(int id)
        {
            if (Request.Form["Confirmar"] == "Cancelar")
            {
                return RedirectToAction(nameof(Lista));
            }
            __partidos.RemoveAll(x => x.Id == id);
            return RedirectToAction(nameof(Lista));

        }

        public ActionResult EliminarConfirmacion(int id)
        {
            PartidosViewModel partido = __partidos.Find(x => x.Id == id);
            return View(partido);

        }


    }
}

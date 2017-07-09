using LibraryDA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Reportes.Areas.Reportes.Controllers
{
    public class MainController : Controller
    {
        // GET: Reportes/Main
        public ActionResult Index()
        { 
            return View();
        }
        public ActionResult Empresa() {

  //ViewBag.ListadoEspecialidad = DAempresa.ListadoEmpresa();
                ViewBag.ListadoEmpresa = DAempresa.ListadoEmpresa();
            return View();
        }
        public ActionResult Alumno()
        {
            //ViewBag.ListadoEspecialidad = DAempresa.ListadoEmpresa();
            
            ViewBag.ListadoAlumno = DAalumno.ListadoAlumno();
            return View();
        }
        public ActionResult Invitado()
        {
            ViewBag.ListadoInvitado = DAinvitado.ListadoInvitado();
            return View();
        }
        public ActionResult Evento()
        {
            ViewBag.ListadoEvento = DAevento.ListadoEvento();
            return View();
        }
        public ActionResult ArchivoInvestigacion()
        {
            ViewBag.ListadoArchivoInvestigacion = DAarchivo.ListaArchivo();
            return View();
        }
    }
}
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

            //return PartialView(DAalumno.ListadoAlumno());
            ViewBag.ListadoAlumno = DAalumno.ListadoAlumno();
            ViewBag.ListadoParticipante = DAdet_Partic_Proyecto.ListaDet_participante();
            ViewBag.ListadoProyecto = DAproyecto.ListadoProyecto();
            ViewBag.ListadoParticipanteEvento = DAparticipante.ListadoParticipante();
            ViewBag.ListadoEvento = DAevento.ListadoEvento();

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
            ViewBag.ListadoUsuario = DAusuario.ListadoUsuario();
            ViewBag.ListadoParticipante = DAparticipante.ListadoParticipante();


            return View();
        }
        public ActionResult ArchivoInvestigacion()
        {
            ViewBag.ListadoArchivoInvestigacion = DAarchivo.ListaArchivo();
            ViewBag.ListadoProyecto = DAproyecto.ListadoProyecto();
            return View();
        }
        public ActionResult Proyecto()
        {
            ViewBag.ListadoProyecto = DAproyecto.ListadoProyecto();
            return View();
        }


        public ActionResult Modulo() {

            return View();
        }
    }
}
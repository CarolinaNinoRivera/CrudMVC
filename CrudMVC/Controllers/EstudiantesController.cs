using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrudMVC.Models;
using CrudMVC.ViewModels;

namespace CrudMVC.Controllers
{
    public class EstudiantesController : Controller
    {
        public ActionResult Index()
        {
            EstudianteServiceClient esc = new EstudianteServiceClient();
            ViewBag.listEstudiantes = esc.findAll();
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(EstudianteViewModel evm)
        {
            EstudianteServiceClient esc = new EstudianteServiceClient();
            esc.create(evm.Estudiantes);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(string Id_Usuario)
        {
            EstudianteServiceClient esc = new EstudianteServiceClient();
            esc.delete(esc.find(Id_Usuario));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(string Id_Usuario)
        {
            EstudianteServiceClient esc = new EstudianteServiceClient();
            EstudianteViewModel evm = new EstudianteViewModel();
            evm.Estudiantes = esc.find(Id_Usuario);
            return View("Edit", evm);
        }

        [HttpPost]
        public ActionResult Edit(EstudianteViewModel evm)
        {
            EstudianteServiceClient esc = new EstudianteServiceClient();
            esc.edit(evm.Estudiantes);
            return RedirectToAction("Index");
        }
    }
}
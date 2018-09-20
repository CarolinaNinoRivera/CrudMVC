using CrudMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CrudMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autherize(CrudMVC.Models.UsuariosEntity userModel)
        {
            using (BDProyectoIEntities db = new BDProyectoIEntities())
            {
                var userDetails = db.Usuarios.Where(x => x.Usuario == userModel.Usuario && x.Contrasena == userModel.Contrasena).FirstOrDefault();
                if (userDetails == null)
                {
                    userModel.LoginErrorMenssage = "Usuario o Contraseña errados";
                    return View("Index", userModel);
                }
                else
                {
                    Session["Id_Usuario"] = userDetails.Id_Usuario;
                    Session["Nombre"] = userDetails.Nombre;
                    return RedirectToAction("Home", "Home");
                }
            }
        }

        public ActionResult LogOut()
        {
            int IdUsuario = Convert.ToInt32(Session["Id_Usuario"]);
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}
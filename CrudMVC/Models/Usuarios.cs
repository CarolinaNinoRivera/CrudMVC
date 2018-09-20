using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CrudMVC.Models
{
    public class Usuarios
    {
        [Display(Name = "Cédula")]
        public string Id_Usuario { get; set; }
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }
        [Display(Name = "Teléfono")]
        public string Telefono { get; set; }
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Usuario")]
        public string Usuario { get; set; }
        [Display(Name = "Contraseña")]
        public string Contrasena { get; set; }
        [Display(Name = "Perfil")]
        public string Perfil { get; set; }
    }
}
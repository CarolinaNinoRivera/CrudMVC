using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CrudMVC.Models
{
    public class Estudiantes: Usuarios
    {
        [Display(Name = "Título")]
        public string Titulo { get; set; }
    }
}
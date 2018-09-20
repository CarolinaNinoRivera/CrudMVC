using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrudMVCServidor
{
    public class Usuarios
    {
        public string Id_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Perfil { get; set; }
    }
}
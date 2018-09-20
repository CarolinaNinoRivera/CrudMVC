using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CrudMVC.Models
{
    public class Conexion
    {
        //singleton
        private static Conexion objConexion = null;
        private SqlConnection con;

        //constructor privado
        private Conexion()
        {
            //Agregar cadena de conexión
            con = new SqlConnection("Data Source=LAPTOP-UDLS0LPK\\PROYECTOI;Initial Catalog=BDProyectoI;User ID=sa;Password=Niko25Kami27");
        }

        public static Conexion saberEstado()
        {
            if (objConexion == null)
            {
                objConexion = new Conexion();
            }
            return objConexion;
        }

        public SqlConnection getCon()
        {
            return con;
        }

        public void cerrarConexion()
        {
            objConexion = null;
        }
    }
}
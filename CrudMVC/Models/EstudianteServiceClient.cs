using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Script.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using System.Data.SqlClient;

namespace CrudMVC.Models
{
    public class EstudianteServiceClient 
    {
        private Conexion objConexion;
        private SqlCommand comando;
        private string BASE_URL = "http://localhost:52860/ServiceEstudiante.svc/";
        public List<Estudiantes> findAll()
        {
            try
            {
                var webclient = new WebClient();
                var json = webclient.DownloadString(BASE_URL + "findall");
                var js = new JavaScriptSerializer();
                return js.Deserialize<List<Estudiantes>>(json);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Source);
                return null;
            }
        }

        public Estudiantes find(string Id_Usuario)
        {
            try
            {
                var webclient = new WebClient();
                string url = string.Format(BASE_URL + "find/{0}", Id_Usuario);
                var json = webclient.DownloadString(url);
                var js = new JavaScriptSerializer();
                return js.Deserialize<Estudiantes>(json);
            }
            catch
            {
                return null;
            }
        }

        public bool create(Estudiantes estudiantes)
        {
            try
            {
                objConexion = Conexion.saberEstado();
                string create = "insert into Usuarios (Id_Usuario, Nombre, Apellido, Telefono, Direccion, Email, Usuario, Contrasena, Perfil) " +
                            "values ('" + estudiantes.Id_Usuario + "', '" + estudiantes.Nombre + "', '" + estudiantes.Apellido +
                            "','" + estudiantes.Telefono + "', '" + estudiantes.Direccion + "', '" + estudiantes.Email +
                            "', '" + estudiantes.Usuario + "','" + estudiantes.Contrasena + "', 'Estudiante') " +
                            " insert into Estudiantes (Id_Estudiante, Titulo) values ('" + estudiantes.Id_Usuario +
                            "', '" + estudiantes.Titulo + "')";
                try
                {
                    comando = new SqlCommand(create, objConexion.getCon());
                    objConexion.getCon().Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Source);
                    throw;
                }
                finally
                {
                    objConexion.getCon().Close();
                    objConexion.cerrarConexion();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Source);
                return false;
            }
        }

        public bool edit(Estudiantes estudiantes)
        {
            objConexion = Conexion.saberEstado();
            string update = "update Usuarios set Nombre = '" + estudiantes.Nombre + "', Apellido = '" + estudiantes.Apellido +
                            "', Telefono = '" + estudiantes.Telefono + "', Direccion = '" + estudiantes.Direccion + "', Email = '" +
                            estudiantes.Email + "', Usuario = '" + estudiantes.Usuario + "', Contrasena = '" + estudiantes.Contrasena +
                            "', Perfil = 'Estudiante' where Id_Usuario = '" + estudiantes.Id_Usuario + "' " +
                            " update Estudiantes set Titulo = '" + estudiantes.Titulo + "' where Id_Estudiante = '" + estudiantes.Id_Usuario + "'";
            try
            {
                comando = new SqlCommand(update, objConexion.getCon());
                objConexion.getCon().Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Source);
                return false;
                throw;
            }
            finally
            {
                objConexion.getCon().Close();
                objConexion.cerrarConexion();
            }
        }

        public bool delete(Estudiantes estudiantes)
        {
            objConexion = Conexion.saberEstado();
            string delete = "delete from Estudiantes where Id_Estudiante = '" + estudiantes.Id_Usuario + "' " +
                            "delete from Usuarios where Id_Usuario = '" + estudiantes.Id_Usuario + "' ";
            try
            {
                comando = new SqlCommand(delete, objConexion.getCon());
                objConexion.getCon().Open();
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Source);
                return false;
                throw;
            }
            finally
            {
                objConexion.getCon().Close();
                objConexion.cerrarConexion();
            }
        }
    }
}
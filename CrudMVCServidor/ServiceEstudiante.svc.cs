using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CrudMVCServidor
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServiceEstudiante" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServiceEstudiante.svc o ServiceEstudiante.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServiceEstudiante : IServiceEstudiante
    {
        public bool create(Estudiantes Estudiante)
        {
            using (BDProyectoIEntities mde = new BDProyectoIEntities())
            {
                try
                {
                    EstudiantesEntity ee = new EstudiantesEntity();
                    ee.Usuarios.Id_Usuario = Estudiante.Id_Usuario;
                    ee.Usuarios.Nombre = Estudiante.Nombre;
                    ee.Usuarios.Apellido = Estudiante.Apellido;
                    ee.Usuarios.Telefono = Estudiante.Telefono;
                    ee.Usuarios.Direccion = Estudiante.Direccion;
                    ee.Usuarios.Email = Estudiante.Email;
                    ee.Usuarios.Usuario = Estudiante.Usuario;
                    ee.Usuarios.Contrasena = Estudiante.Contrasena;
                    ee.Usuarios.Perfil = Estudiante.Perfil;
                    ee.Titulo = Estudiante.Titulo;
                    mde.EstudiantesEntities.Add(ee);
                    mde.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool delete(Estudiantes Estudiante)
        {
            using (BDProyectoIEntities mde = new BDProyectoIEntities())
            {
                try
                {
                    EstudiantesEntity ee = mde.EstudiantesEntities.Single(e => e.Usuarios.Id_Usuario == Estudiante.Id_Usuario);
                    mde.EstudiantesEntities.Remove(ee);
                    mde.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool edit(Estudiantes Estudiante)
        {
            using (BDProyectoIEntities mde = new BDProyectoIEntities())
            {
                try
                {
                    EstudiantesEntity ee = mde.EstudiantesEntities.Single(e => e.Usuarios.Id_Usuario == Estudiante.Id_Usuario);
                    ee.Usuarios.Id_Usuario = Estudiante.Id_Usuario;
                    ee.Usuarios.Nombre = Estudiante.Nombre;
                    ee.Usuarios.Apellido = Estudiante.Apellido;
                    ee.Usuarios.Telefono = Estudiante.Telefono;
                    ee.Usuarios.Direccion = Estudiante.Direccion;
                    ee.Usuarios.Email = Estudiante.Email;
                    ee.Usuarios.Usuario = Estudiante.Usuario;
                    ee.Usuarios.Contrasena = Estudiante.Contrasena;
                    ee.Usuarios.Perfil = Estudiante.Perfil;
                    ee.Titulo = Estudiante.Titulo;
                    mde.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public Estudiantes find(string Id_Usuario)
        {
            using (BDProyectoIEntities mde = new BDProyectoIEntities())
            {
                return mde.EstudiantesEntities.Where(es => es.Usuarios.Id_Usuario == Id_Usuario).Select(es => new Estudiantes
                {
                    Id_Usuario = es.Usuarios.Id_Usuario,
                    Nombre = es.Usuarios.Nombre,
                    Apellido = es.Usuarios.Apellido,
                    Telefono = es.Usuarios.Telefono,
                    Direccion = es.Usuarios.Direccion,
                    Email = es.Usuarios.Email,
                    Usuario = es.Usuarios.Usuario,
                    Contrasena = es.Usuarios.Contrasena,
                    Perfil = es.Usuarios.Perfil,
                    Titulo = es.Titulo
                }).First();
            }
        }

        public List<Estudiantes> findAll()
        {
            using (BDProyectoIEntities mde = new BDProyectoIEntities())
            {
                return mde.EstudiantesEntities.Select(es => new Estudiantes
                {
                    Id_Usuario = es.Usuarios.Id_Usuario,
                    Nombre = es.Usuarios.Nombre,
                    Apellido = es.Usuarios.Apellido,
                    Telefono = es.Usuarios.Telefono,
                    Direccion = es.Usuarios.Direccion,
                    Email = es.Usuarios.Email,
                    Usuario = es.Usuarios.Usuario,
                    Contrasena = es.Usuarios.Contrasena,
                    Perfil = es.Usuarios.Perfil,
                    Titulo = es.Titulo
                }).ToList();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CrudMVCServidor
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServiceEstudiante" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServiceEstudiante
    {
        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "findall", ResponseFormat = WebMessageFormat.Json)]
        List<Estudiantes> findAll();

        [OperationContract]
        [WebInvoke(Method = "GET", UriTemplate = "find/{Id_Usuario}", ResponseFormat = WebMessageFormat.Json)]
        Estudiantes find(string Id_Usuario);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "create", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool create(Estudiantes Estudiante);

        [OperationContract]
        [WebInvoke(Method = "PUT", UriTemplate = "edit", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool edit(Estudiantes Estudiante);

        [OperationContract]
        [WebInvoke(Method = "DELETE", UriTemplate = "delete", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json)]
        bool delete(Estudiantes Estudiante);
    }
}

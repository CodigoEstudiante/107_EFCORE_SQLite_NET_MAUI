
using System.ComponentModel.DataAnnotations;

namespace MauiAppSQlite.Modelos
{
    public class Empleado
    {
        [Key] 
        public string IdEmpleado { get; set; }

        public string Nombre { get; set; }

        public string Correo { get; set; }
    }
}

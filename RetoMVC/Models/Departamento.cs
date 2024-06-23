

using Microsoft.Extensions.Hosting;
using System.Reflection.Metadata;

namespace RetoMVC.Models
{

    public class Departamento
    {
        // Propiedades
        public int Id { get; set; }
        public string DepartamentoCodigo { get; set; } = "";
        public string DepartamentoNombre { get; set; } = "";
        public DateTime FechaHoraCrea { get; set; }
        public DateTime FechaHoraModifica { get; set; }

        public ICollection<Empleado> Empleados { get; } = new List<Empleado>();

        // Constructor
        public Departamento()
        {
            this.FechaHoraCrea = DateTime.Now;
            this.FechaHoraModifica = DateTime.Now;
        }
    }
}
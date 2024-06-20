

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

        public Empleado? EmpleadoRef { get; set; } // Reference navigation to dependent

        // Constructor
        public Departamento()
        {
            this.FechaHoraCrea = DateTime.Now;
            this.FechaHoraModifica = DateTime.Now;
        }
    }
}
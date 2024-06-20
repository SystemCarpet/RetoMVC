
using System.Reflection.Metadata;

namespace RetoMVC.Models
{

    public class Empleado
    {
        // Propiedades
        public int Id { get; set; }
        public string DocumentoTipo { get; set; } = null!;  // RC, TI, CC, CE
        public string DocumentoNumero { get; set; } = null!;
        public string Nombres { get; set; } = null!;
        public string Apellidos { get; set; } = null!;
        public string? Ciudad { get; set; }
        public string? Direccion { get; set; } 
        public string? CorreoElectronico { get; set; }
        public string? Telefono { get; set; }
        public DateTime FechaHoraCrea { get; set; } 
        public DateTime FechaHoraModifica { get; set; }

        public int DepartamentoId { get; set; } // Required foreign key property
        public Departamento Departamento { get; set; } = null!; // Required reference navigation to principal
        public String DiasTrabajados
        {
            get
            {
                TimeSpan tiempoTrabajado = DateTime.Now - FechaHoraCrea;
                return $"{tiempoTrabajado.Days} días, {tiempoTrabajado.Hours} horas, {tiempoTrabajado.Minutes} minutos, {tiempoTrabajado.Seconds} segundos";
            }
        }


        public Empleado()
        {
            FechaHoraCrea = DateTime.Now;
            FechaHoraModifica = DateTime.Now;
        }
    }
}
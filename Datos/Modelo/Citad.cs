using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Modelo
{
    public class Citad
    {
        //cambios
        [Key]
        public int CitaId { get; set; }
        public Medicod MedicoID { get; set; }
        public int Medicosd {get; set; }
        public Paciented PacienteId { get; set; }
        public int Pacientesd { get; set; }
        public DateTime FechaCita { get; set; }
        public bool Estado { get; set; }
    }
}

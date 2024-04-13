using Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.BaseDatos
{
    public class Connection: DbContext
    {
        public Connection():base("name=Consultorio")
        {

        }
        public DbSet<Cita> Citas { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciented> Pacientes { get; set;}
    }
}

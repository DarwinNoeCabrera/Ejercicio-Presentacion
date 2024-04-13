using Datos.Core;
using Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Npaciented_
    {
        Repository<Paciented> _repository;
        public List<Paciented> TodasLosClientes()
        {
            return _repository.Consulta().Include(c => c.PacienteId).ToList();
        }

        public int Agregar(Paciented paciented)
        {
            paciented.FechaIngreso = DateTime.Now;
            paciented.FechaModificacion = DateTime.Now;
            _repository.Agregar(paciented);

            return 1;
        }

        public int Editar(Paciented paciented)
        {
            //var clienteInDb = context.Clientes.Find(cliente.ClienteId);
            var pace = _repository.Consulta().FirstOrDefault(C => C.PacienteId == paciented.PacienteId);

            if (pace != null)
            {
                pace.FechaModificacion = DateTime.Now;
                pace.Nombres = paciented.Nombres;
                pace.Apellidos = paciented.Apellidos;
                pace.FechaIngreso = paciented.FechaIngreso;
                pace.Estado = paciented.Estado;
                _repository.Editar(pace);
                return 1;

            }
            return 0;
        }

        public int Eliminar(int paciented)
        {
            //var clienteInDb = context.Clientes.Find(clienteId);
            var pace= _repository.Consulta().FirstOrDefault(C => C.PacienteId == paciented);
            if (pace != null)
            {   
                _repository.Eliminar(pace);
                return 1;
            }
            return 0;
        }
    }
}

using Datos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class Dpaciented
    {
        Npaciented_ npaciented;
        public Dpaciented()
        {
            npaciented = new Npaciented_();
        }

        public List<Paciented> obtenerCliente()
        {
            return npaciented.TodasLosClientes();
        }

        public List<Paciented> obtenerClientesGrid()
        {
            var pace = npaciented.TodasLosClientes().ToList().Select(c => new { c.PacienteId, c.Nombres, c.Apellidos });
            return npaciented.TodasLosClientes();
        }

        public List<Paciented> obtenerClientesInactivos()
        {
            var clientes = npaciented.TodasLosClientes();
            return clientes.Where(c => c.Estado == true).ToList();
        }

        public int Guardar(Paciented pace)
        {
            if (pace.PacienteId == 0)
            {
                return npaciented.Agregar(pace);
            }
            else
            {
                return npaciented.Editar(pace);
            }

        }

        public int Eliminar(int clienteId)
        {
            return npaciented.Eliminar(clienteId);
        }
    }
}

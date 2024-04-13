using Datos.Modelo;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Dcita
    {
        Ncita ncita;
        public Dcita()
        {
            ncita = new Ncita();
        }

        public List<Citad> obtenerCliente()
        {
            return ncita.TodasLosClientes();
        }

        public List<Citad> obtenerClientesGrid()
        {
            var pace = ncita.TodasLosClientes().ToList().Select(c => new { c.PacienteId, c.MedicoID, c.CitaId });
            return ncita.TodasLosClientes();
        }

        public List<Citad> obtenerClientesInactivos()
        {
            var clientes = ncita.TodasLosClientes();
            return clientes.Where(c => c.Estado == true).ToList();
        }

        public int Guardar(Citad pace)
        {
            if (pace.CitaId == 0)
            {
                return ncita.Agregar(pace);
            }
            else
            {
                return ncita.Editar(pace);
            }

        }

        public int Eliminar(int clienteId)
        {
            return ncita.Eliminar(clienteId);
        }
    }
}

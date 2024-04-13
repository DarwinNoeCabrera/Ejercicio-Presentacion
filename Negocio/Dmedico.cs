using Datos.Modelo;
using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Dmedico
    {
        Nmedico nmedico;
        public Dmedico()
        {
            nmedico = new Nmedico();
        }

        public List<Medicod> obtenerCliente()
        {
            return nmedico.TodasLosClientes();
        }

        public List<Medicod> obtenerClientesGrid()
        {
            var pace = nmedico.TodasLosClientes().ToList().Select(c => new { c.MedicoId, c.Nombres, c.Apellidos });
            return nmedico.TodasLosClientes();
        }

        public List<Medicod> obtenerClientesInactivos()
        {
            var clientes = nmedico.TodasLosClientes();
            return clientes.Where(c => c.Estado == true).ToList();
        }

        public int Guardar(Medicod pace)
        {
            if (pace.MedicoId == 0)
            {
                return nmedico.Agregar(pace);
            }
            else
            {
                return nmedico.Editar(pace);
            }

        }

        public int Eliminar(int clienteId)
        {
            return nmedico.Eliminar(clienteId);
        }
    }
}

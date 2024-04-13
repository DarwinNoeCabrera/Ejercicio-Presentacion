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
    public class Nmedico
    {
        Repository<Medicod> _repository;
        public List<Medicod> TodasLosClientes()
        {
            return _repository.Consulta().Include(c => c.MedicoId).ToList();
        }

        public int Agregar(Medicod medi)
        {
            medi.FechaIngreso = DateTime.Now;
            _repository.Agregar(medi);
            return 1;
        }

        public int Editar(Medicod medi)
        {

            var pace = _repository.Consulta().FirstOrDefault(C => C.MedicoId == medi.MedicoId);

            if (pace != null)
            {
                pace.FechaIngreso = DateTime.Now;
                pace.Nombres = medi.Nombres;
                pace.Apellidos = medi.Apellidos;
                pace.Estado = medi.Estado;
                _repository.Editar(pace);
                return 1;

            }
            return 0;
        }

        public int Eliminar(int medis)
        {

            var pace = _repository.Consulta().FirstOrDefault(C => C.MedicoId == medis);
            if (pace != null)
            {
                _repository.Eliminar(pace);
                return 1;
            }
            return 0;
        }
    }
}

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
    public class Ncita
    {
        Repository<Citad> _repository;
        public List<Citad> TodasLosClientes()
        {
            return _repository.Consulta().Include(c => c.CitaId).ToList();
        }

        public int Agregar(Citad medi)
        {
            medi.FechaCita = DateTime.Now;
            _repository.Agregar(medi);
            return 1;
        }

        public int Editar(Citad medi)
        {

            var pace = _repository.Consulta().FirstOrDefault(C => C.CitaId == medi.CitaId);

            if (pace != null)
            {
                pace.FechaCita = DateTime.Now;
                pace.PacienteId = medi.PacienteId;
                pace.MedicoID = medi.MedicoID;
                pace.FechaCita = medi.FechaCita;
                pace.Estado = medi.Estado;
                _repository.Editar(pace);
                return 1;

            }
            return 0;
        }

        public int Eliminar(int medis)
        {

            var pace = _repository.Consulta().FirstOrDefault(C => C.CitaId == medis);
            if (pace != null)
            {
                _repository.Eliminar(pace);
                return 1;
            }
            return 0;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Core
{
    public interface IunitOfWork
    {
        Irepository<T> Repository<T>() where T : class;
        int Guardar();
        void ComenzandoTransaccion();
        void ReversarTransaccion();
        void ConfirmarTransaccion();

    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Datos.BaseDatos;

namespace Datos.Core
{
    public class Repository<T> : Irepository<T> where T : class
    {
        public Connection dbcontext;

        public Repository()
        {
            this.dbcontext = new Connection();
        }

        public void Agregar(T entidad)
        {
            dbcontext.Set<T>().Add(entidad);
        }

        public void Agregar(IEnumerable<T> entidades)
        {
            foreach (var entidad in entidades)
            {
                Agregar(entidad);
            }
        }

        public T Buscar(int id)
        {
            return dbcontext.Set<T>().Find(id);
        }

        public IEnumerable<T> Buscar(Expression<Func<T, bool>> predicado)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Consulta()
        {
            return dbcontext.Set<T>().AsQueryable();
        }

        public void Editar(T entidad)
        {
            dbcontext.Entry(entidad).State = EntityState.Modified;
        }

        public void Eliminar(T entidad)
        {
            dbcontext.Set<T>().Remove(entidad);
        }

        public T ObtenerPorId(int id)
        {
            return dbcontext.Set<T>().Find(id);
        }

        public IEnumerable<T> ObtenerTodos()
        {
            return dbcontext.Set<T>().ToList();
        }
    }
}

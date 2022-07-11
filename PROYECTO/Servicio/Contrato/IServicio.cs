using System.Collections.Generic;
using PROYECTO.Models;
namespace PROYECTO.Servicio
{
    public interface IServicio<T>
    {
        public IList<T> GetAll();
        public T Get(int id);
        public void Create(T obj);
        public void Update(T obj);
        public void Delete(int id);

    }
}

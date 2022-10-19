using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class BaseModel<T>
    {
        protected List<T> data;

        public BaseModel()
        {
            data = new List<T>();
        }

        public void Create(T t)
        {
            if (t == null)
            {
                throw new ArgumentException("El valor es nulo.");
            }

            data.Add(t);
        }

        public void Delete(T t)
        {
            if (t == null)
            {
                throw new ArgumentException("El valor es nulo.");
            }

            data.Remove(t);
        }

        public List<T> GetAll()
        {
            if (data == null)
            {
                throw new ArgumentException("No se han agregado valores.");
            }

            return data;
        }

        public void Update(int index, T t)
        {
            if (t == null || index < 0)
            {
                throw new ArgumentException("El valor es nulo.");
            }

            data.Insert(index, t);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.dalApi
{
    public interface Icrud<T>
    {
        void Create(T item);
        public List<T> Read();

        void Update(T item);

        void Delete(T item);

    }
}

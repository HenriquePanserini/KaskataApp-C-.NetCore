using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaskataDDD.Domain.Interface.Generics
{
    public interface IGenerics<T> where T : class
    {
        Task Create(T objeto);
        Task Upgrade(T objeto);
        Task Delete(T objeto);
        Task<T> GetById(int id);
        Task<List<T>> GetAll();

    }
}

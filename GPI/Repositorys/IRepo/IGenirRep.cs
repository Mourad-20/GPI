using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GPI.Repositorys.IRepo
{
        public interface IGenirRep<T> where T : class
    {
        IQueryable<T> GetAll();
        T GetById(object id);
       
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void DeleteObject(object _obj);
        void Save();
    }
}

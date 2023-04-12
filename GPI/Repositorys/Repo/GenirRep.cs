using GPI.models;
using GPI.Repositorys.IRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GPI.Repositorys.Repo
{
   
    public class GenirRep<T> : IGenirRep<T> where T : class
    {
        private MyCtxDB _myCtxDB = null;

        private DbSet<T> table = null;

        public GenirRep(MyCtxDB _myCtxDB)
        {
            this._myCtxDB = _myCtxDB;
            table = _myCtxDB.Set<T>();
        }
        public IQueryable<T> GetAll()
        {
            return table.AsQueryable<T>();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
       
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _myCtxDB.Entry(obj).State = EntityState.Modified;
        }
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _myCtxDB.SaveChanges();
        }

        public void DeleteObject(object _obj)
        {
            _myCtxDB.Entry(_obj).State = EntityState.Deleted;
        }
    }
}

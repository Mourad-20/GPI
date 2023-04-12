using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GPI.Repositorys.IRepo
{
    public interface IRepo<Entity>
    {
        ICollection<Entity> getAll();

        Entity getbyId(int id);

        void add(Entity entity); 

        void update(Entity entity);

        void delet(int id);
        //void Save();

    }
}

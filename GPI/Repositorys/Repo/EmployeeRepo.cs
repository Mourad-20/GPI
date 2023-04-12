using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GPI.models;
using GPI.models.DM;
using GPI.Repositorys.IRepo;

namespace GPI.Repositorys.Repo
{
    public class EmployeeRepo : IRepo<EmployeeDM>
    {
        public  IGenirRep<EmployeeDM> EmployeRepoGen;


        public EmployeeRepo(IGenirRep<EmployeeDM> EmployeRepo)
        {
            this.EmployeRepoGen = EmployeRepo;
             }
        public void add(EmployeeDM employee)
        {
            EmployeRepoGen.Insert(employee);
            EmployeRepoGen.Save();
        }

        public void delet(int id)
        {
            EmployeeDM emp = EmployeRepoGen.GetById(id);
            if(emp!=null)
                EmployeRepoGen.DeleteObject(emp);
            EmployeRepoGen.Save();
        }

        public ICollection<EmployeeDM> getAll()
        {

            return EmployeRepoGen.GetAll().ToList() ;
        }

        public ICollection<EmployeeDM> getbyname(string name)
        {

            return EmployeRepoGen.GetAll().Where(x=>x.nom==name).ToList() ;
        }

        public EmployeeDM getbyId(int id)
        {
            EmployeeDM employeeDM= EmployeRepoGen.GetById(id);
            return employeeDM;
        }

        public void update(EmployeeDM employee)
        {
            EmployeRepoGen.Update(employee);
            EmployeRepoGen.Save();
           
             }
    }
}

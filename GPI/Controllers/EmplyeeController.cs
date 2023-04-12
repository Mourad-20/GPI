using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GPI.Mapper;
using GPI.models.DM;
using GPI.models.VM;
using GPI.Repositorys.IRepo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GPI.Controllers
{
    [Route("api/[controller]")]
    public class EmplyeeController : Controller
    {
        public readonly IRepo<EmployeeDM> EmployeRepo;
        public EmplyeeController(IRepo<EmployeeDM> EmployeRepo)
        {
            this.EmployeRepo = EmployeRepo;
        }
        // GET: api/Emplyee
        [HttpGet("[action]")]
        public IEnumerable<EmployeeVM> getAll()
        {

            IEnumerable<EmployeeDM> EmployeeDMs = EmployeRepo.getAll();
            ICollection<EmployeeVM> EmployeeVMs = new List<EmployeeVM>();
            foreach (EmployeeDM employeeDM in EmployeeDMs) {
                EmployeeVMs.Add(EmployeeMapper.EmployeeDMtoVM(employeeDM));
            }
           // IEnumerable <EmployeeVM> EmployeeVMs = EmployeRepo.getAll();
            return EmployeeVMs;
        }

        // GET: api/Emplyee/5
        [HttpGet("{id}")]
        public string getbyId(int id)
        {
            return "value";
        }

        // POST: api/Emplyee
        [HttpPost]
        public void add([FromBody] string value)
        {
        }

        // PUT: api/Emplyee/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

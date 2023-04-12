using GPI.models.DM;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GPI.models
{
    public class MyCtxDB:DbContext
    {
        public MyCtxDB(DbContextOptions<MyCtxDB>option):base(option)
        { 

        }
        public DbSet<EmployeeDM> EmployeeDM { get; set; }
        

    }
}

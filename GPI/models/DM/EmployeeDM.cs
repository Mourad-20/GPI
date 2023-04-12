using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GPI.models.DM
{
    [Table("Employee")]
    public class EmployeeDM
    {
        [Key]
        public int id_emp { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string mail { get; set; }
        public string role { get; set; }
        //public DateTime dateN { get; set; }

    }
}

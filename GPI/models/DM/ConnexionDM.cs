using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace GPI.models.DM
{
    [Table("Connexion")]
    public class ConnexionDM
    {
        [Key]
        public int id_cnx { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string idemployee { get; set; }

    }
}

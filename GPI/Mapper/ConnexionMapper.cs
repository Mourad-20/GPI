using GPI.models.DM;
using GPI.models.VM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GPI.Mapper
{
    public class ConnexionMapper
    {
        public static ConnexionVM connexionDMtoVM(ConnexionDM connexionDM) {

            ConnexionVM connexionVM = new ConnexionVM
            {
                login = connexionDM.login,
                password = connexionDM.password,
                idemployee = connexionDM.idemployee,
               
            };
            return connexionVM;
        }

        public static ConnexionDM connexionVMtoDM(ConnexionVM connexionVM)
        {

            ConnexionDM connexionDM = new ConnexionDM
            {
                login = connexionVM.login,
                password = connexionVM.password,
                idemployee = connexionVM.idemployee,

            };
            return connexionDM;
        }
    }
}

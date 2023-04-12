using GPI.models.VM;
using GPI.models.DM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GPI.Mapper
{
    public class EmployeeMapper
    {
        public static EmployeeVM EmployeeDMtoVM(EmployeeDM employeeDM) {

            EmployeeVM emlpyeeVM = new EmployeeVM
            {
                nom = employeeDM.nom,
                prenom = employeeDM.prenom,
                mail = employeeDM.mail,
                role = employeeDM.role,
               // Age = (DateTime.Now - employeeDM.dateN).Days

            };
            return emlpyeeVM;
        }

        public static EmployeeDM EmployeeVMtoDM(EmployeeVM employeeVM)
        {

            EmployeeDM emlpyeeDM = new EmployeeDM
            {
                nom = employeeVM.nom,
                prenom = employeeVM.prenom,
                mail = employeeVM.mail,
                role = employeeVM.role
            };
            return emlpyeeDM;
        }
    }
}

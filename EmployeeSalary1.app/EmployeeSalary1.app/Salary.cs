using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeSalary1.app
{
    class Salary
    {
        public string name;
        public double basic;
        public double housePersent;
        public double medicalAllowance;

        public double GetHouseRent()
        {
            return (basic*housePersent)/100;
        }

        public double GetMedicalAllowance()
        {
            return (basic*medicalAllowance)/100;
        }


        public double GetTotalSalary()
        {
            return basic + GetHouseRent() + GetMedicalAllowance();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeApplication2;

namespace EmployeeApplication2
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        double RatePerHour { get; set; }
        int TotalHoursWorked { get; set; }

        double ComputeSalary();
    }
    public class PartTimeEmployee : EmployeeApplication2.IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double RatePerHour { get; set; }
        public int TotalHoursWorked { get; set; }

       
        public double ComputeSalary()
        {
            return RatePerHour * TotalHoursWorked;
        }

        
        public string GetEmployeeDetails()
        {
            return $" { FirstName }\n \n { LastName }\n \n  {ComputeSalary()}";
        }
    }
}

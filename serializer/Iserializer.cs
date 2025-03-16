using EmployeesSalary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesSalary.serializer
{
   public interface Iserializer
    {
        public List<EmployeesData> DEserialize(string File);
        public bool serialize(List<EmployeesData> e);
    }
}

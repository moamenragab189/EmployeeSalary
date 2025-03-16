using EmployeesSalary.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EmployeesSalary.serializer
{
    class Jsonserializer:Iserializer
    {
        public List<EmployeesData> DEserialize(string File)
        {
            //deserilize json to opjects
            List<EmployeesData> EmployeesList = JsonConvert.DeserializeObject<List<EmployeesData>>(File);
            return EmployeesList;
        }

        public bool serialize(List<EmployeesData> e)
        {
            throw new NotImplementedException();
        }
    }
}

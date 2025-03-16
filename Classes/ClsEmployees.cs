using EmployeesSalary.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using EmployeesSalary.DataAcces;
using EmployeesSalary.serializer;
namespace EmployeesSalary.Classes
{
    class ClsEmployees
    {

       
        public List<EmployeesData> ShowEmployeesData(out string message) 
        {
            IrReadEmployees readEmplyees = new JsonFile();
            string smessage = "";
            string File = readEmplyees.ReadEmployees(out smessage);
            if (String.IsNullOrEmpty(File))
            {
                message = smessage;
                //return empty list
                return new List<EmployeesData>();
            }

            Iserializer oDeserilize = new Jsonserializer();
            List<EmployeesData>  EmployeesList =  oDeserilize.DEserialize(File) ;
           smessage=ValidatList(EmployeesList);
            if (!string.IsNullOrEmpty(smessage))
            {
                message = smessage;
                return new List<EmployeesData>();
            }
            //loop employees
            for (int i = 0; i < EmployeesList.Count; i++)
            {
                //calculate salary acording to job
                CalculateSalary(EmployeesList[i]); 
            }
            message = "";
            return EmployeesList;
        }

        public void CalculateSalary(EmployeesData emp)
        {
            if (emp == null)
            {
                throw new OutOfMemoryException();
            }
            switch (emp.Job)
            {
                case "Engineer":
                    emp.Salary = (emp.BasicSalary + emp.Bouns) - (emp.ToatalPinalites + (emp.DaysAbsence * (emp.BasicSalary / 30)));
                    break;
                case "sales":
                    emp.Salary = (emp.BasicSalary + emp.CommstionPercent * emp.TotalSales) - (emp.ToatalPinalites + (emp.DaysAbsence * (emp.BasicSalary / 30)) + (emp.DaysLate * (emp.BasicSalary / 30)));
                    break;
                case "Admin":
                    emp.Salary = (emp.BasicSalary) - (emp.ToatalPinalites + (emp.DaysAbsence * (emp.BasicSalary / 30)) + (emp.DaysLate * (emp.BasicSalary / 30)));
                    break;
            }
        }
        public string ValidatList(List<EmployeesData> EmployeesList)
        {
            if (EmployeesList == null)
            {
                return "List is Empty";
            }
            return "";
        }

    }
}

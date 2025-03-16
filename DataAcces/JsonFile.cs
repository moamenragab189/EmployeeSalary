using EmployeesSalary.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
namespace EmployeesSalary.DataAcces
{
    class JsonFile:IrReadEmployees
    {
        public string  ReadEmployees(out string message) 
        {
            //open json file
            string JsonString = File.ReadAllText("Employees.json");
            //validation
            if (!File.Exists("Employees.json"))
            {
                message = "file is not exist";
                return" ";
            }
            if (string.IsNullOrEmpty(JsonString))
            {
                message = "file is empty";
                return " ";
            }
            message = "";
            return JsonString;
        }
    }
}

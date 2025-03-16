using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeesSalary.Classes
{
   public class EmployeesData
    {
    public string Name { set; get; }
    public string Job { set; get; }
    public decimal BasicSalary { set; get; }
    public int DaysLate { set; get; }
    public int DaysAbsence { set; get; }
    public decimal ToatalPinalites { set; get; }
    public decimal? Bouns { set; get; }
    public decimal? CommstionPercent{set;get;}
    public decimal? TotalSales{ set; get; }
    public decimal? Salary { set; get; }
    }
}

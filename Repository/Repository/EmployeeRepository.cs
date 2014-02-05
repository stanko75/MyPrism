using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Model;
using Repository.Repository.Interfaces;

namespace Repository.Repository
{
  [Export(typeof(IEmployeeRepository))]
  public class EmployeeRepository : IEmployeeRepository
  {
    public List<Employee> GetAllEmployees()
    {
      return new List<Employee>()
      {
        new Employee(){ID=1, FirstName = "ABC", LastName = "FGH", Email="abc@gmail.com", Mobile = "123456789"},
        new Employee(){ID=2, FirstName = "DEF", LastName = "GHI", Email="def@gmail.com", Mobile = "987654321"}
      };
    }
  }
}
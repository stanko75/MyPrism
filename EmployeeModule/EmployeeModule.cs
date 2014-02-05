using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;

namespace EmployeeModule
{
  [ModuleExport(typeof(EmployeeModule))]
  public class EmployeeModule: IModule
  {
    public void Initialize()
    {
      
    }
  }
}
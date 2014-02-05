using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace EmployeeModule
{
  [ModuleExport(typeof(EmployeeModule))]
  public class EmployeeModule: IModule
  {
    [Import]
    public IRegionManager Region { get; set; }
    public void Initialize()
    {
      Region.RequestNavigate("EmployeeRegion", "EmployeeView");
      
    }
  }
}
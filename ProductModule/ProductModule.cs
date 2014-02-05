using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;

namespace ProductModule
{
  [ModuleExport(typeof(ProductModule))]
  public class ProductModule: IModule
  {
    public void Initialize()
    {
      
    }
  }
}
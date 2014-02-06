using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.MefExtensions.Modularity;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace ProductModule
{
  [ModuleExport(typeof(ProductModule))]
  public class ProductModule: IModule
  {
    [Import]
    public IRegionManager Region { get; set; }
    public void Initialize()
    {
      Region.RequestNavigate("ProductRegion", "ProductView");
    }
  }
}
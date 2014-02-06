using System.ComponentModel.Composition;
using System.Windows.Controls;
using Microsoft.Practices.Prism.Regions;
using ProductModule.ViewModel;

namespace ProductModule.View
{
  [Export("ProductView")]
  [PartCreationPolicy(CreationPolicy.NonShared)]
  [RegionMemberLifetime(KeepAlive = false)]
  public partial class ProductView : UserControl
  {
    [ImportingConstructor]
    public ProductView(ProductViewModel vm)
    {
      InitializeComponent();
      this.DataContext = vm;
    }
  }
}
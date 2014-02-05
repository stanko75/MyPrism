using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EmployeeModule.ViewModel;
using Microsoft.Practices.Prism.Regions;

namespace EmployeeModule.View
{
  [Export("EmployeeView")]
  [PartCreationPolicy(CreationPolicy.NonShared)]
  [RegionMemberLifetime(KeepAlive = false)]
  public partial class EmployeeView : UserControl
  {
    [ImportingConstructor]
    public EmployeeView(EmployeeViewModel vm)
    {
      InitializeComponent();
      this.DataContext = vm;
    }
  }
}

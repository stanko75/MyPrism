using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Prism.ViewModel;
using Repository.Model;
using Repository.Repository.Interfaces;

namespace EmployeeModule.ViewModel
{
  [Export]
  public class EmployeeViewModel : NotificationObject
  {
    private IEmployeeRepository employeeRepository;
    private ObservableCollection<Employee> employeeList;

    private void Init()
    {
      var emps = employeeRepository.GetAllEmployees();
      foreach (var item in emps)
      {
        employeeList.Add(item);
      }
    }

    [ImportingConstructor]
    public EmployeeViewModel(IEmployeeRepository employeeRepository)
    {
      this.employeeRepository = employeeRepository;
      employeeList = new ObservableCollection<Employee>();
      Init();
    }

    public ObservableCollection<Employee> EmployeeList
    {
      get { return employeeList; }
      set
      {
        employeeList = value;
        RaisePropertyChanged("EmployeeList");
      }
    }
  }
}

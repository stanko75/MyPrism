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

namespace ProductModule.ViewModel
{
  [Export]
  public class ProductViewModel: NotificationObject
  {
    private IProductRepository productRepository;
    private ObservableCollection<Product> productList;

    private void Init()
    {
      var emps = productRepository.GetAllProducts();
      foreach (var item in emps)
      {
        productList.Add(item);
      }
    }

    public ProductViewModel(IProductRepository productRepository)
    {
      this.productRepository = productRepository;
      productList = new ObservableCollection<Product>();
      Init();
    }

    public ObservableCollection<Product> ProductList
    {
      get { return productList; }
      set
      {
        productList = value;
        RaisePropertyChanged("ProductList");
      }
    }
  }
}
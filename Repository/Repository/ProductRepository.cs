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
  [Export(typeof(IProductRepository))]
  public class ProductRepository: IProductRepository
  {
    public List<Product> GetAllProducts()
    {
      return new List<Product>()
      {
        new Product(){ID=1, ProductCode="A0001", ProductName = "ABCDEF", ManufactureName = "Microsoft"},
        new Product(){ID=2, ProductCode="B0002", ProductName = "BCEDDD", ManufactureName = "Google"}
      };
    }
  }
}
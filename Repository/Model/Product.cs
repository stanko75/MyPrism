﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Model
{
  public class Product
  {
    public int ID { get; set; }
    public string ProductCode { get; set; }
    public string ProductName { get; set; }
    public string ManufactureName { get; set; }
  }
}
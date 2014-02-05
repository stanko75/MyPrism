﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Model;

namespace Repository.Repository.Interfaces
{
  public interface IEmployeeRepository
  {
    List<Employee> GetAllEmployees();
  }
}

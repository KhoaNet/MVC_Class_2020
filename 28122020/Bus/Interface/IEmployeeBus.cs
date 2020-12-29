using Dao.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bus.Interface
{
    interface IEmployeeBus
    {
        public List<EmployeeModel> GetEmployees();
    }
}

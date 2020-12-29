using Bus.Interface;
using Dao;
using Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bus.Controller
{
    public class EmployeeBus : IEmployeeBus
    {
        private DataContext _db = new DataContext();
        public List<EmployeeModel> GetEmployees()
        {
            return _db.EmployeeModel.ToList();
        }
    }
}

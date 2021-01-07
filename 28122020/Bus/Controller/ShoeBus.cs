using Bus.Interface;
using Dao;
using Dao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bus.Controller
{
    public class ShoeBus : IShoeBus
    {
        private DataContext _db = new DataContext();
        public List<ShoeModel> GetList()
        {
            return _db.ShoeModel.ToList();
        }
    }
}

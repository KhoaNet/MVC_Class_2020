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

        public ActionRequest Add(ShoeModel shoeReq)
        {

            var req = new ActionRequest();
            try
            {
                //Check thêm valid
                _db.ShoeModel.Add(new ShoeModel
                {
                    ShoeName = shoeReq.ShoeName,
                    ShoeImg = shoeReq.ShoeImg
                });
                _db.SaveChanges();
                req.stt = 1;
                req.msg = "Scuess";
            }
            catch (Exception ex)
            {
                req.stt = -1;
                req.msg = ex.ToString();
            }
            
            return req;
        }

        public List<ShoeModel> GetShoes()
        {
            return _db.ShoeModel.ToList();
        }
    }
}

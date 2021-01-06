﻿using Dao.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bus.Interface
{
    interface IShoeBus
    {
        public List<ShoeModel> GetShoes();
        public ActionRequest Add(ShoeModel shorReq);
    }
}

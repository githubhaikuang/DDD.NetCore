﻿using System.Collections.Generic;
using DDD.NetCore.Domain.Entities;

namespace DDD.NetCore.Domain.Goods
{
    /// <summary>
    /// 商品类别
    /// </summary>
    public class GoodsCategory : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Goods> GoodsList { get; set; }
    }
}

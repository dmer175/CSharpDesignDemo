using Demo.Design.工厂模式.store;
using System;
using System.Collections.Generic;
using System.Text;
using Demo.Design.工厂模式.store.impl;

namespace Demo.Design.工厂模式
{
    public class StoreFactory
    {
        public ICommodity GetCommodityService(int commdityType)
        {
            if(commdityType==1) return new CouponCommodityService();
            if (commdityType == 2) return new GoodsCommodityService();
            if (commdityType == 3) return new CardCommodityService();
            throw new ArgumentException("不存在的商品服务类型");
            
        }
    }
}

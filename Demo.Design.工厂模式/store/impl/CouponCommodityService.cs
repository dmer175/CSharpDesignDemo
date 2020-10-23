using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Demo.Design.工厂模式.store.impl
{
    /// <summary>
    /// 优惠券
    /// </summary>
    public class CouponCommodityService : ICommodity
    {
        private CouponService couponService = new CouponService();
        public void sendCommodity(string uId, string commodityId, string bizId, Dictionary<string, string> extDic)
        {
            CouponResult couponResult = couponService.sendCoupon(uId, commodityId, bizId);
            WriteLine($"请求参数[优惠券]=》uid:{uId},commodityId:{commodityId},bizId:{bizId},extDic:{extDic}");
            if (!"0000".Equals(couponResult.getCode())) throw new ArgumentException();
        }
    }

    internal class CouponService
    {
        internal CouponResult sendCoupon(string uId, string commodityId, string bizId)
        {
            return new CouponResult();
        }
    }

    internal class CouponResult
    {
        internal object getCode()
        {
            return "1234";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Demo.Design.工厂模式.store.impl
{
    //把其他实现包装到自己类中，各自不影响其他
    /// <summary>
    /// 第三方兑换卡
    /// </summary>
    public class CardCommodityService : ICommodity
    {
        private IQiYiCardService iqiYiCardService = new IQiYiCardService();

        public void sendCommodity(string uId, string commodityId, string bizId, Dictionary<string, string> extDic)
        {
            string mobile = QueryUserMobile(uId);
            iqiYiCardService.GrantToken(mobile, bizId);

            WriteLine($"请求参数[兑换卡]=》uid:{uId},commodityId:{commodityId},bizId:{bizId},extDic:{extDic}");
            WriteLine($"测试结果[兑换卡]：Suc");
        }

        private string QueryUserMobile(object uid)
        {
            return "18890168523";
        }
    }

    internal class IQiYiCardService
    {
        internal void GrantToken(string mobile, string bizId)
        {
            
        }
    }
}

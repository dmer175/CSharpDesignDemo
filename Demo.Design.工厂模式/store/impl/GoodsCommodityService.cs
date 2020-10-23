using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Demo.Design.工厂模式.store.impl
{
    /// <summary>
    /// 实物商品
    /// </summary>
    public class GoodsCommodityService:ICommodity
    {
        private GoodsService goodsService = new GoodsService();

        public void sendCommodity(string uId, string commodityId, string bizId, Dictionary<string, string> extDic)
        {
            DeliverReq deliverReq = new DeliverReq();
            deliverReq.UserName = QueryUserName(uId);
            deliverReq.UserPhone = QueryUserPhoneNum(uId);
            deliverReq.Sku = commodityId;
            deliverReq.OrderId = bizId;
            deliverReq.ConsigneeUserName = extDic["consigneeUserName"];
            deliverReq.ConsigneeUserPhone=(extDic["consigneeUserPhone"]);
            deliverReq.ConsigneeUserAddress=(extDic["consigneeUserAddress"]);

            bool isSuc = goodsService.deliverGoods(deliverReq);

            WriteLine($"请求参数[实物]=》uid:{uId},commodityId:{commodityId},bizId:{bizId},extDic:{extDic}");
            WriteLine($"测试结果[实物]：{isSuc}");

            if (!isSuc) throw new ArgumentException("实物商品发放失败");
        }

        private object QueryUserPhoneNum(string uId)
        {
            return "东方前沄";
        }

        private object QueryUserName(string uId)
        {
            return "18892150147";
        }
    }

    internal class DeliverReq
    {
        public object UserName { get; internal set; }
        public object UserPhone { get; internal set; }
        public string Sku { get; internal set; }
        public string OrderId { get; internal set; }
        public string ConsigneeUserName { get; internal set; }
        public string ConsigneeUserPhone { get; internal set; }
        public string ConsigneeUserAddress { get; internal set; }
    }

    internal class GoodsService
    {
        internal bool deliverGoods(DeliverReq deliverReq)
        {
            return true;
        }
    }
}

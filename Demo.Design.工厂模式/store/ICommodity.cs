using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Design.工厂模式.store
{
    /// <summary>
    /// 发奖接口
    /// </summary>
    public interface ICommodity
    {
        /// <summary>
        /// 发奖
        /// </summary>
        /// <param name="uId"></param>
        /// <param name="commodityId"></param>
        /// <param name="bizId"></param>
        /// <param name="extDic"></param>
        void sendCommodity(string uId, string commodityId, string bizId, Dictionary<string, string> extDic);
    }
}

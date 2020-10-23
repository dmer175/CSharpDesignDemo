using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Design.适配器模式
{
    public class MQAdapter
    {
        public static RebateInfo filter(string strJson,Dictionary<string,string> link)
        {
            return filter(JsonConvert.DeserializeObject(strJson), link);
        }

        private static RebateInfo filter(object obj, Dictionary<string, string> link)
        {
            RebateInfo rebateInfo = new RebateInfo();
            foreach (var item in link)
            {
                object va = obj.GetType(item.Value);
            }
        }
    }
}

using Demo.Design.桥接模式.mode;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Demo.Design.桥接模式.channel
{
    public class ZfbPay : Pay
    {
        public ZfbPay(IPayMode payMode) : base(payMode)
        {
        }

        public override string Transfer(string uid, string tradeId, double amount)
        {
            WriteLine($"模拟支付宝渠道支付划账开始。uid:{uid},tradeId:{tradeId},amount:{amount}");
            bool security = payMode.security(uid);
            WriteLine($"模拟支付宝渠道支付风控校验。uid:{uid},tradeId:{tradeId},security:{security}");
            if (!security)
            {
                WriteLine($"模拟支付宝渠道支付划账拦截。uid:{uid},tradeId:{tradeId},amount:{amount}");
                return "0001";
            }
            WriteLine($"模拟支付宝渠道支付划账成功。uid:{uid},tradeId:{tradeId},amount:{amount}");
            return "0000";
        }
    }
}

using System.Collections.Generic;
using System;
using System.Text;
using Demo.Design.桥接模式.mode;

namespace Demo.Design.桥接模式.channel
{
    public abstract class Pay
    {
        protected IPayMode payMode;

        public Pay(IPayMode payMode)
        {
            this.payMode = payMode;
        }

        public abstract string Transfer(string uid, string tradeId, double amount);
    }
}

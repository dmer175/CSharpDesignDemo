using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Demo.Design.桥接模式.mode
{
    public class PayFingerprintMode : IPayMode
    {
        public bool security(string uid)
        {
            WriteLine("指纹支付，风控校验指纹识别");
            return true;
        }
    }
}

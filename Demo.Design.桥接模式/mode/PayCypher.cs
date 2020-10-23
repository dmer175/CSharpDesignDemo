using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Demo.Design.桥接模式.mode
{
    public class PayCypher : IPayMode
    {
        public bool security(string uid)
        {
            WriteLine("密码支付，风控校验环境安全");
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Demo.Design.桥接模式.mode
{
    public class PayFaceMode : IPayMode
    {
        public bool security(string uid)
        {
            WriteLine("人脸支付，风控校验人脸识别");
            return true;
        }
    }
}

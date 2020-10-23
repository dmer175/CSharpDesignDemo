using Demo.Design.桥接模式.channel;
using Demo.Design.桥接模式.mode;
using System;
using static System.Console;

namespace Demo.Design.桥接模式
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("模拟测试场景：微信支付，人脸方式");
            Pay wxpay = new WxPay(new PayFaceMode());
            wxpay.Transfer("wx_1234", "10000109", 100.00);

            WriteLine("模拟测试场景：支付宝支付，指纹方式");
            Pay zfbpay = new ZfbPay(new PayFingerprintMode());
            zfbpay.Transfer("wx_1233", "10000108", 200.00);

            ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Design.桥接模式.mode
{
    public interface IPayMode
    {
        bool security(string uid);
    }
}

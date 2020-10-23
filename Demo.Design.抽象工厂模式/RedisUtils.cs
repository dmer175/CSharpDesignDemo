using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Demo.Design.抽象工厂模式
{
    public class RedisUtils
    {
        private Dictionary<string, string> dataMap = new Dictionary<string, string>();

        public string get(string key)
        {
            WriteLine($"Redis获取数据key:{key}");
            return dataMap[key];
        }

        public void set(string key ,string value)
        {
            WriteLine($"Redis写入数据 key: {key}, value: {value}");
            dataMap.Add(key, value);
        }

        public void set(string key,string value,long timeout, TimeEnum timeEnum)
        {
            
        }
    }
}

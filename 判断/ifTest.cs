//if判断
using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            //局部变量定义
            int a = 10;

            //使用if语句检查布尔条件
            if(a < 20)
            {
                //如果条件为真，则输出下面语句
                Console.WriteLine("a小于20");
            }
            Console.WriteLine("a的值是{0}",a);
            Console.ReadLine();
        }
    }
}
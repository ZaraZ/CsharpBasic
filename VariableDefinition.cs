//变量初始化
using System;
namespace VariableDefinition
{
    class Program
    {
        static void Main(string[] ars)
        {
            short a;
            int b;
            double c;
            int num;

            //实际初始化
            a = 10;
            b = 20;
            c = a + b;
            num = Convert.ToInt32(Console.ReadLine());  //接收来自用户的值
            Console.WriteLine("a = {0}, b = {1}, c = {2}", a, b, c);            
            Console.WriteLine("num = {0}",num);
            Console.ReadLine();
        }
    }
}
//字段和局部变量的作用域冲突
using System;
namespace Wrox
{
    class ScopTest2
    {
        static int j = 20;
        public static void Main()
        {
            int j = 30;
            Console.WriteLine(j);
            return;
        }
    }
}
//局部变量的作用域冲突
using System;
namespace Wrox.ProCSharp.Basics
{
    public class ScopeTest
    {
        public static int Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 9; i >=0; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
            return 0;
        }//i在两个循环内部声明，所以i对于各个循环来说是局部变量
    }
}
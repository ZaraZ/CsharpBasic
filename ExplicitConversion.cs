//C#类型转换
using System;
namespace TypeConversionApplication
{
    class ExplicitConversion
    {
        static void Main(string[] args)
        {
            double d = 5673.47;
            int i;

            //强制转换double为int
            i = (int)d;
            Console.WriteLine(d);
            Console.WriteLine(i);
            Console.ReadKey();
        }
    }
}


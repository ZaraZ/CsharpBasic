//if...else语句
using System;

namespace DecisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 100;

            if(a < 20)
            {
                Console.WriteLine("a小于20");
            }
            else
            {
                Console.WriteLine("a大于20");
            }
            Console.WriteLine("a的值是{0}",a);
            Console.ReadLine();
        }
    }
}
//类型判断例子
using System;

namespace Wrox
{
    class Program
    {
        static void Main(String[] args)
        {
            var name = "Bugs Bunny";
            var age = 25;
            var isRabbit = true;

            Type nameType = name.GetType();
            Type ageType = age.GetType();
            Type isRabbitType = isRabbit.GetType();

            Console.WriteLine("name is type" + nameType.ToString());
            Console.WriteLine("age is type" + ageType.ToString());
            Console.WriteLine("isRabbit is type" + isRabbit.ToString());
            Console.ReadLine();
            return;
        }
    }
}
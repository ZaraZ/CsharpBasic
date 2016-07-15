//类型判断例子
/*
    类型判断遵循部分规则：
        1、变量必须初始化。否则编译器没有推断变量类型的依据；
        2、初始化起不能为空；
        3、初始化器必须放在表达式中；
        4、不能把初始化器设置为一个对象，除非初始化器中创建了一个新对象。
*/
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
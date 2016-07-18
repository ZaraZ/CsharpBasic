//class基本概念
using System;

namespace BoxApplication
{
    class Box
    {
        public double length;   //长度
        public double breadth;  //宽度
        public double height;   //高度

    }

    class Boxtester
    {
        static void Main(string[] args)
        {
            Box Box1 = new Box();   //声明Box1，类型为Box
            Box Box2 = new Box();   //声明Box2，类型为Box
            double volume = 0.0;    //体积

            //Box1详述
            Box1.height = 5.0;
            Box1.length = 6.0;
            Box1.breadth = 7.0;

            //Box2详述
            Box2.height = 10.0;
            Box2.length = 12.0;
            Box2.breadth = 13.0;

            //Box1的体积
            volume = Box1.height * Box1.length * Box1.breadth;
            Console.WriteLine("Box1的体积：{0}",volume);

            //Box2的体积
            volume = Box2.height * Box2.length * Box2.breadth;
            Console.WriteLine("Box2的体积：{0}",volume);

            Console.ReadKey();
        }
    }
}
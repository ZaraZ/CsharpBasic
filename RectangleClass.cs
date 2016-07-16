//C#基本语法的讨论
using System;
namespace RectangleApplication
{
    class Rectangle     //class用于声明一个类
    {
        //成员变量
        double length;
        double width;
        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length:{0}",length);
            Console.WriteLine("Width:{0}",width);
            Console.WriteLine("GetArea:{0}",GetArea());
        }
    }

    class ExecuteRectanle       //实例化一个类
    {
        static void Main(String[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
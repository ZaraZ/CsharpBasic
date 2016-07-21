using System;

using System.Collections;   //引入集合的命名空间

namespace ArrayListTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //声明一个ArrayList的对象
            ArrayList arrList = new ArrayList();
            //我们可以在这个数组中任意添加元素。
            arrList.Add(12);
            arrList.Add(31);
            arrList.Add(15);
            arrList.Add(75);
            arrList.Add(43);

            //要输出ArrayList的元素。每个放到ArrayList里的数组元素都会转换成object类型存放
            Console.WriteLine("原ArrayList元素为：");
            foreach(object o in arrList)
            {
                Console.Write(o + "\t");
            }
            Console.WriteLine();
            Console.WriteLine("插入元素之后的元素为：");
            arrList.Insert(2, 99);  //在索引为2的位置插入99
            foreach (object o in arrList)
            {
                Console.Write(o + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("排序之后的ArrayList的元素是：");
            arrList.Sort();
            foreach(object o in arrList)
            {
                Console.Write(o + "\t");
            }

            Console.WriteLine();
            Console.WriteLine("删除之后的元素：");
            arrList.Remove(99);     //通过数据删除
            arrList.RemoveAt(0);    //通过索引位置删除
            foreach(object o in arrList)
            {
                Console.Write(o + "\t");
            }

            Console.ReadKey();
        }
    }
}
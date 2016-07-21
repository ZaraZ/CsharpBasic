//创建一个程序，在程序中添加5名同学，兵刃以随机抽取两名同学出来。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ArrayListSt
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();
        arrList.Add("张三");
        arrList.Add("李四");
        arrList.Add("王二麻");
        arrList.Add("小明");
        arrList.Add("小红");
        ArrayList arrChou = new ArrayList();    //用来存放抽出的两个学生
        for(int i = 1; i <= 2; i++)
        {
            while (true)
            {
                int randIndex = new Random().Next(0, 5);
                if(arrChou.Contains(arrList[randIndex]))
                {
                    continue;
                }
                else
                {
                    arrChou.Add(arrList[randIndex]);
                    break;
                }
            }
        }
        foreach (object obj in arrChou)
        {
            Console.WriteLine(obj);
        }
        Console.ReadKey();
        }
    }
}
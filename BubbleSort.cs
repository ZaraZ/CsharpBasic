//冒泡排序

using System;

namespace BubbleSort
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] array = {55, 66, 33, 22, 77, 11, 99, 2131, 2, 34, 56};
        int min = array[0];

        //比较轮数
        for(int i = 0; i <= array.Length - 1; i++)
        {

            //每轮前后数值依次比较
            for(int j = 0; j < array.Length - 1; j++)
            {
                if(array[j] > array[j + 1])
                {

                    //后一位小于前一位，则交换
                    min = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = min;
                }
            }
        }

        for(int a = 0; a <= array.Length - 1; a++)
        {
            Console.Write(array[a] + "\t");
        }
        Console.ReadKey();
        }
    }
}
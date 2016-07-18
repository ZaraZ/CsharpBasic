/*
C# 结构的特点：
1、结构可带有方法、字段、索引、属性、运算符方法和事件。
2、结构可定义构造函数，但不能定义析构函数。但是，不能为结构定义默认的构造函数。默认的构造函数是自动定义的，且不能被改变。
3、与类不同，结构不能继承其他的结构或类。
4、结构不能作为其他结构或类的基础结构。
5、结构可实现一个或多个接口。
6、结构成员不能指定为 abstract、virtual 或 protected。
7、当使用 New 操作符创建一个结构对象时，会调用适当的构造函数来创建结构。与类不同，结构可以不使用 New 操作符即可被实例化。
8、如果不使用 New 操作符，只有在所有的字段都被初始化之后，字段才被赋值，对象才被使用。
*/
using System;

struct Books
{
    public string title;
    public string author;
    public string subject;
    public int book_id;
};

public class testStructure
{
    public static void Main(string[] args)
    {
        Books Book1;    /*声明Book1，类型为Book*/
        Books Book2;    /*声明Book2，类型为Book*/

        /*book1 详述*/
        Book1.title = "C Programming";
        Book1.author = "Nuha Ali";
        Book1.subject = "C Programming Tutorial";
        Book1.book_id = 6495407;

        /*book2 详述*/
        Book2.title = "Telecom Billing";
        Book2.author = "Zara Ali";
        Book2.subject = "Telecom Billing Tutorial";
        Book2.book_id = 6495700;

        /*打印Book1信息*/
        Console.WriteLine("Book 1 title : {0}",Book1.title);
        Console.WriteLine("Book 1 author : {0}",Book1.author);
        Console.WriteLine("Book 1 subject : {0}",Book1.subject);
        Console.WriteLine("Book 1 book_id : {0}",Book1.book_id);

        /*打印Book2信息*/
        Console.WriteLine("Book 2 title : {0}",Book2.title);
        Console.WriteLine("Book 2 author : {0}",Book2.author);
        Console.WriteLine("Book 2 subject : {0}",Book2.subject);
        Console.WriteLine("Book 2 book_id : {0}",Book2.book_id);

        Console.ReadKey();
    }
}
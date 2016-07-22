#C#编程基础知识点导图
给自己复习和记录用。<br />
***有任何意见和建议，欢迎交流，我的邮箱：xiangyunzmail@163.com***

## I、C#常量与变量
### 1、数据类型
#### a、值类型
#### b、预定义引用类型
##### （i）、Object类型
##### （ii）、字符串类型
### 2、变量
#### a、变量的声明
#### b、选择合适的变量名的数据类型
#### c、变量名的命名规范
#### d、变量命名的规则
#### e、变量命名建议
### 3、数据类型转换
### 4、常量
#### a、符号常量
### 5、总结

## II、表达式与运算符
### 1、算术运算符
### 2、比较运算符
### 3、赋值运算符
### 4、一元运算符
### 5、运算的优先级
### 6、前置和后置自加和自减运算
### 7、表达式的类型转换
### 8、三元运算符
### 9、运算符的扩展
### 10、其他运算符信息
### 11、总结

## III、控制流语句
### 1、选择结构语句
### 2、循环结构语句
#### a、while循环
#### b、do...while循环
#### c、死循环
#### d、for循环
### 3、转向结构语句
### 4、总结

## IV、数组
### 1、数组的定义
### 2、一维数组
### 3、多维数组
### 4、数组的扩容与缩容
#### a、扩容：
    在原有的定长的数组中增加长度。需要将之前的数据复制到新的数组中。
#### b、缩容:
    在原有数组中减少其中的元素，而其余元素的大小并不发生改变。
### 5、数组的冒泡排序
    冒泡排序算法的运作如下：（从后往前）
    1、比较相邻的元素。如果第一个比第二个大，就交换他们两个。
    2、对每一对相邻元素作同样的工作，从开始第一对到结尾的最后一对。在这一点，最后的元素应该会是最大的数。
    3、针对所有的元素重复以上的步骤，除了最后一个。
    4、持续每次对越来越少的元素重复上面的步骤，直到没有任何一对数字需要比较。
    对应代码：BubbleSort.cs
### 6、数组的列表集合
    数组列表集合ArrayList
    类似一维数组
    数组列表是动态数组
    可以存放任何对象
    常用方法：
    增加元素-Add
    插入元素-Insert
    删除元素-Remove

    练习：创建一个程序，在程序中添加5名同学，兵刃以随机抽取两名同学出来。（ArrayListSt.cs）

## V、字符串与日期操作
### 1、比较字符串
    比较字符串：
    比较字符串是指按照字典排序规则，判定两个字符串的相对大小。
    常用的比较字符串的方法包括：Compare、CompareTo、Equals、比较运算符等。
    Ps：按照字典规则，在英文字典中，出现在前面的单词小于出现在后面的单词。
    Equals方法用于方便的判断两个字符串是否相同，如果相同返回True；否则为False。
### 2、定位字符和子串
    定位子串是指一个字符串中寻找其中包含的子串或者某个字符。常用的定位子串和字符的方法包括IndexOf、LastIndexOf、StartWith、EndWith等。
    Ps：IndexOf/LastIndexOf方法用于搜索一个字符串中，某个特定的字符或子串第一次/最后一次出现的位置，该方法区分大小写，并从字符串的首字符开始以0计算。
    如果字符串中不包含这个字符或子串，则返回-1。
### 3、格式化字符串
    Format方法用于创建格式化的字符串以及连接多个字符串对象。形式如下：
    Format(string format, params object[] args)
    该方法的参数format用于指定返回字符串的格式，经常在format参数中包含一些大括号括起来数字，如{0}、{1}，这些数字分别一一对应于args参数数组中的变量。
### 4、连接字符串
    1、Concat方法用于连接两个或多个字符串；
    2、Join方法利用一个字符数组和一个分割字符串构造成新的字符串，常用于把多个字符串连接在一起，并用一个特殊的符号来分隔开；
    3、连接运算符“+”，可以方便的连接多个字符串。
### 5、分裂字符串
    Split方法可以把一个字符串，按照某个分隔符，分裂成一系列小的字符串。
### 6、字符串其他操作列举
    1、替换字符串：Replace
    2、转大小写：ToUpper、ToLower
    等等
### 7、日期操作

## VI、面向对象编程基础
### 1、类的概念
### 2、类的定义
### 3、构造函数
### 4、this关键字
### 5、方法
### 6、方法的调用
### 7、方法的参数
### 8、静态类和静态方法
### 9、方法的重载
### 10、命名空间的概念

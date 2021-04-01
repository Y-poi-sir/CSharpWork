# CSharpWork
my CSharpWork of CSharp class



【作业01】
a1. 写一个控制台程序，实现计算器功能。输入两个数字和一个运算符，打印出计算结果。

a2. 写一个Windows窗体应用，实现计算器功能。在两个文本框中输入数字，在组合框中选择运算符，点计算按钮后显示出计算结果。

a3. 根据教程学习Git和Github的使用方法。 
Git教程：https://www.liaoxuefeng.com/wiki/896043488029600 
通过一个游戏学习git： https://learngitbranching.js.org/?locale=zh_CN 
在VS中使用Github： https://zhuanlan.zhihu.com/p/31031838 
在VS中使用Gitee： https://www.jianshu.com/p/5d7655e10576

a4. 创建一个Github或者Gitee账号，并在Github/Gitee上面创建一个库（如CSharpWork），将两个计算器程序代码提交到这个库里面，并将Github/Gitee的库地址（备注学号+姓名）发至wsm@whu.edu.cn。

【作业02】
b1. 编写程序输出用户指定数据的所有素数因子。

b2. 编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和。

b3. 用“埃氏筛法”求2~ 100以内的素数。2~ 100以内的数，先去掉2的倍数，再去掉3的倍数，再去掉4的倍数，以此类推...最后剩下的就是素数。

b4. 编写面向对象程序实现长方形、正方形、三角形等形状的类。每个形状类都能计算面积、判断形状是否合法。请尝试合理使用接口/抽象类、属性来实现。

b5. 随机创建10个形状对象，计算这些对象的面积之和。请尝试使用简单工厂设计模式来创建对象。

【作业03】0319更新
c1. 为示例（参见第4章课件第9页）中的泛型链表类添加类似于List<T>类的ForEach(Action<T> action)方法。通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）。
  
c2. 使用事件机制，模拟实现一个闹钟功能。闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。在闹钟嘀嗒运行时或者响铃时，在控制台显示提示信息。

【作业04】0326更新
d1. 写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户、订单金额等进行查询）功能。

提示：主要的类有Order（订单）、OrderDetails（订单明细），OrderService（订单服务），订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。

要求：

（1）使用LINQ实现各种查询功能，查询结果按照订单总金额排序返回。

（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。

（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。

（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。

（5）OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。


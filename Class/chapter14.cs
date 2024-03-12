using System;

namespace Csharp_learn.Class
{
    // delegate可以看成一个包含有序方法列表的对象，这些方法具有相同的签名和返回类型
    // delegate void MyDel(int x)
    // MyDel dyDel = new MyDel(类.方法)
    // MyDel dyDel = 类.方法  <---------------快捷语法
    // 如上一个委托由  delegate 返回类型 名称 签名（参数）  组成
    delegate void Del(int x);

    public class ClassOne
    {
        public void Print(int x)
        {
            Console.WriteLine(x);
        }

        public void Write(int x)
        {
            Console.WriteLine(-x);
        }
    }

    public class ClassTwo
    {
        public ClassOne _classOne = new ClassOne();

        public void PrintNew(int x)
        {
            Del del = _classOne.Print;
            //组合委托
            //del3会调用所有方法,按添加顺序执行
            Del del2 = _classOne.Write;
            Del del3 = del + del2;
            //也可以用+=增加方法
            del2 += del;
            del2 += del;
            //也可以用-=减少方法
            //委托中有多个相同方法时，从最后开始搜索删除第一个匹配的方法
            //删除不存在的方法将无效
            //调用空委托会抛出异常
            del2 -= _classOne.Write;
            
            del2(x);
        }
        
    }
}
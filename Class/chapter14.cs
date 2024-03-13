using System;

namespace Csharp_learn.Class
{
    //委托像个加工厂，包含一系列有序的方法
    // delegate可以看成一个包含有序方法列表的对象，这些方法具有相同的签名和返回类型
    // delegate void MyDel(int x)
    // MyDel dyDel = new MyDel(类.方法)
    // MyDel dyDel = 类.方法  <---------------快捷语法
    // 如上一个委托由  delegate 返回类型 名称 签名（参数）  组成
    delegate void Del(int x);
    //带返回值的委托
    //调用列表中最后一个方法的返回值就是委托的返回值
    //其他方法的返回值会被忽略
    delegate int MyDel();
    //带引用的委托
    //根据方法的执行，前一个方法的返回值会传给下一个方法
    delegate void MyDel2(ref int x);
    
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
            //也可以用Invoke调用委托
            del2?.Invoke(x);
        }
        
    }
    //带返回值的委托
    //调用列表中最后一个方法的返回值就是委托的返回值
    //其他方法的返回值会被忽略
    public class DelClass
    {
        public int IntVal = 5;

        public int Add2()
        {
            IntVal += 2;
            return IntVal;
        }
        public int Add3()
        {
            IntVal += 3;
            return IntVal;
        }
    }

    public class ProgarmNew
    {
        public void Add2(ref int x)
        {
            x += 2;
        }
        public void Add3(ref int x)
        {
            x += 3;
        }
        public static void Test()
        {
            ProgarmNew progarmNew = new ProgarmNew();
            MyDel2 myDel2 = progarmNew.Add2;
            myDel2 += progarmNew.Add3;
            int x = 5;
            myDel2(ref x);
            Console.WriteLine(x);
        }
    }
    
    //匿名方法
    //匿名方法的组成：delegate(Parameters){ImplementationCode}
    delegate int OtherDel(int x);
    //params参数
    //如果委托的参数列表中有params参数，匿名方法参数列表必须省略params关键字
    delegate void SomeDel(int x, params int[] y);
    delegate int Lam(int x);
    public class ClassThree
    {
        public static void Test()
        {
            //匿名函数的参数数量、参数类型及位置、修饰符必须与委托相匹配
            //匿名函数可以访问外部变量,匿名方法使用外部变量成为方法捕获
            int val = 10;
            OtherDel otherDel = delegate(int x) { return x + 5; };
            SomeDel someDel = delegate(int x, int[] y) { Console.WriteLine(val); };
            Console.WriteLine(val);
            //匿名方法有点冗余，因此C#3.0引入Lambda表达式
            //Lambda表达式删除delegate关键字
            //在参数列表和匿名方法主体之间使用 =>
            Lam lam1 = (int x) => { return x + 1; };
            Lam lam2 = x => { return x + 1; };
            Lam lam3 = x => x + 1; //最简洁
            Console.WriteLine(lam1(1));
            Console.WriteLine(lam1(2));
            Console.WriteLine(lam1(3));
            //Lambda的参数数量、参数类型及位置、修饰符必须与委托相匹配
            //Lambda表达式中参数不一定需要包含类型，除非委托有ref或者out必须注明
            //只有一个参数可以省略=>左边括号
            //没有参数必须用一组空括号()=>
            
        }
    }
    
}
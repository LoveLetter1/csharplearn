using System;

namespace Csharp_learn.Class
{
    //引用转换
    public class A
    {
        public int Field1;
    }

    public class B : A
    {
        public int Field2;
    }

    public class Cha17
    {
        public static void Main1()
        {
            B var1 = new B();
            A var2 = (A)var1;
            object var3 = (object)var1;
            Console.WriteLine(var1.Field2);
            //var2访问不了Field2
            //Console.WriteLine(var2.Field2);
            Console.WriteLine(var3.GetHashCode());
        }

        public static void Main2()
        {
            A var1 = new A();
            //基类到派生类转换不安全会抛出异常
            //B var2 = (B)var1;
            
            //有效隐式转换
            B var3 = new B();
            //可以不写成以下形式 A本来就是B的基类
            //A var4 = (A)var3;
            A var4 = var3;
            //如果基类是null 则可以基类到派生类转换
            A var5 = null;
            B var6 = (B)var5;
            //最后一种派生类到基类的转换
            B var7 = new B();
            A var8 = var7;
            //var8原本就是B类型，下面转换允许
            B var9 = (B)var8;
        }


    }
}
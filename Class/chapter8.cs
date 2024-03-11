using System;
namespace Csharp_learn.Class
{
    // 类的继承 已存在的类叫做基类base class，新类成为派生类derived class
    // 派生类的组成有：
    // 本身声明的成员、基类的成员
    public class SomeClass
    {
        public string Field1 = "base class field";

        public void Method1(string value)
        {
            Console.WriteLine($"Base class -- method1:{value}");
        }
    }

    public class OtherClass : SomeClass
    {
        public string Field2 = "derived class field";
        public void Method2(string value)
        {
            Console.WriteLine($"derived class -- method2:{value}");
        }
    }
}
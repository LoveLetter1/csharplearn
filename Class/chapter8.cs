﻿using System;
namespace Csharp_learn.Class
{
    // 类的继承 已存在的类叫做基类base class，新类成为派生类derived class
    // 派生类的组成有：
    // 本身声明的成员、基类的成员
    // 虚方法和覆写方法 virtual用在基类方法 override用在派生类方法
    // 基类调用virtual方法会调用派生类的override方法
    // 覆写和被覆写的方法具有相同的访问优先级
    // 方法、索引、属性、事件都能被覆写
    // 不能覆写static或非虚方法
    public class SomeClass
    {
        public string Field1 = "base class field";

        public void Method1(string value)
        {
            Console.WriteLine($"Base class -- method1:{value}");
        }

        public virtual void Print()
        {
            Console.WriteLine("no overrode");
        }
        
    }

    public class OtherClass : SomeClass
    {
        //屏蔽基类字段
        public new string Field1 = "rewrite field1";
        public string Field2 = "derived class field";
        public void Method2(string value)
        {
            Console.WriteLine($"derived class -- method2:{value}");
        }
        public void BaseField()
        {
            Console.WriteLine(base.Field1);
        }

        public override void Print()
        {
            Console.WriteLine("has overrode");
        }
    }

    public class ThirdClass : OtherClass
    {
        public new void Print()
        {
            Console.WriteLine("third overrode");
        }
    }

    public class BaseClass
    {
        private int _number;

        public BaseClass()
        {
            _number = 10;
            Console.WriteLine("BaseClass has inited");
        }

        public BaseClass(int x)
        {
            _number = x;
            Console.WriteLine($"the number is {_number}");
        }
    }

    public class DerivedClass:BaseClass
    {
        private int _age;
        //readonly字段只能在构造函数中初始化或声明的时候直接赋值，不适用readonly属性
        private readonly int _score = 9;
        public DerivedClass(int y):base(x:y)
        {
            _age = 5;
            Console.WriteLine("derivedclass has inited");
        }
    }
    //readonly和this配合的一个例子
    public class User
    {
        public readonly int Field1;
        public readonly int Field2;
        public string UserName;
        public int UserId;
        private User()
        {
            Field1 = 5;
            Field2 = 10;
        }
        public User(string name):this()
        {
            UserName = name;
            UserId = 1;
        }

        public User(int id) : this()
        {
            UserName = "null";
            UserId = id;
        }
    }
    // 类的可访问性只有两个：public和internal
    // public可以被系统内任意程序集访问
    // internal只能被自己所在的程序集内的类看到
    internal class InternalClass
    {
        
    }
}
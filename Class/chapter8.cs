using System;
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
    // 成员的访问级别有5种：public,private,protected,internal,protected internal
    // 所有显式声明在类声明中的成员都是互相可见的，无论他们的访问性如何
    // 成员的访问级别不能比类高
    public class MyClass
    {
        public int PublicVar;
        private int PrivateVar;
        protected int ProtectedVar;
        internal int InternalVar;
        protected internal int ProInterVar;
        // 另一个类能否访问这些成员主要取决于2个特征：
        // 该类是否继承MyClass
        // 该类是否和MyClass处于同一程序集
        
    }
    public class MyClassSon : MyClass
    {
        public MyClassSon()
        {
            ProtectedVar = 5;
        }
        public void Print()
        {
            Console.WriteLine(ProInterVar);
            Console.WriteLine(ProtectedVar);
        }
    }
    // 抽象成员有四种类型：方法、属性、事件、索引器
    // 相对于virtual，abstract必须被重写
    // 抽象成员只能在抽象类中声明
    // 抽象类不能创建实例
    public abstract class Weapon
    {
        public int SideLength = 10;
        public const int TriSideCount = 3;
        public abstract void Print(string s);
        public abstract int MyInt { get; set; }
    }

    public class Gun : Weapon
    {
        private int _myInt;
        public override void Print(string s)
        {
            Console.WriteLine(s);
        }

        public override int MyInt
        {
            get
            {
                return _myInt;
            }
            set
            {
                _myInt = value;
            }
        }
    }
    // 密封类不能被继承，不能当基类
    sealed class Seal
    {
        
    }
    //静态类中所有成员都是静态的
    //静态类用于存放不受实例数据影响的数据和函数
    //常见有math库的实现
    //静态类可以有静态构造函数，不能有实例构造函数
    //静态类不能继承
    public static class MyMath
    {
        public static int _num;
        public static void Print(){}
        
    }
}
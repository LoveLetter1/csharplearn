using System;

namespace Csharp_learn.Class
{
    // readonly修饰符的使用
    // readonly的值可以在运行的时候再确定，在内存中有存储位置
    public class Shape
    {
        public readonly double PI = 3.1415;
        public readonly int NumberOfSides;

        public Shape(int numberOfSides)
        {
            NumberOfSides = numberOfSides;
        }
        
    }
    // this修饰符的使用
    // this能在实力构造函数、实例方法、属性和索引器的实例访问器中使用
    // this很少再代码中使用，主要区分类的成员和局部变量或参数
    public class Test
    {
        private int _val = 10;

        public int MaxVal(int _val)
        {
            return _val > this._val ? _val : this._val;
        }
    }
    // 索引器的使用
    // 索引器和属性类似，只不过关键字只能是this，后面必须有参数列表,参数列表用[类型 index]
    // 索引器可以重载，必须有不同的参数列表，关键字均为this
    public class Employee
    {
        public string LastName;
        public string FirstName;
        public string CityOfBirth;

        public string this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return LastName;
                    case 1: return FirstName;
                    case 2: return CityOfBirth;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: LastName = value;
                        break;
                    case 1: FirstName = value;
                        break;
                    case 2: CityOfBirth = value;
                        break;
                    default: throw new ArgumentOutOfRangeException("index");
                    
                }
            }
        }
    }
    // 分部类和分部类型的使用
    // 分布方法将定义和实现放在不同的类中
    public partial class PartClass
    {
        private int _a;
        private int _b;
        partial void PrintSum(int a, int b);
        public void Add(int a, int b)
        {
            PrintSum(a,b);
        }
    }
    public partial class PartClass
    {
        private int _c;
        private int _d;

        partial void PrintSum(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }

    
    
}
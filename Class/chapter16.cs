using System;

namespace Csharp_learn.Class
{
    // 接口是指定一组函数成员而不实现他们的引用类型
    // 只能类和结构来实现接口
    public interface IInfo
    {
        string GetName();
        string GetAge();
    }

    public class CA : IInfo
    {
        public string Name;
        public int Age;
        public string GetName()
        {
            return Name;
        }
        public string GetAge()
        {
            return Age.ToString();
        }
    }

    public class CB : IInfo
    {
        public string First;
        public string Last;
        public double Age;
        public string GetName()
        {
            return First + " " + Last;
        }

        public string GetAge()
        {
            return Age.ToString();
        }
    }
    //CA和CB都实现了IInfo接口
    public class Program
    {
        public static void PrintInfo(IInfo item)
        {
            Console.WriteLine($"{item.GetAge()}   {item.GetName()}");
        }

        public static void Main1()
        {
            CA ca = new CA();
            ca.Age = 12;
            ca.Name = "mike";
            CB cb = new CB();
            cb.Age = 14;
            cb.First = "wang";
            cb.Last = "san";
            PrintInfo(ca);
            PrintInfo(cb);
        }

        public static void Main2()
        {
            int[] arr = { 1, 20, 7, 19, 5 };
            Array.Sort(arr);
            foreach (var i in arr)
            {
                Console.Write($"{i} ");
            }

            
        }
    }
    //实现IComparable接口，可以排序
    public class ComArray : IComparable
    {
        public int Value;
        public int CompareTo(object obj)
        {
            ComArray comArray = (ComArray)obj;
            if (this.Value < comArray.Value) return -1;
            if (this.Value > comArray.Value) return 1;
            return 0;
        }
    }
    //接口声明
    //接口不能包含数据成员、静态成员
    //接口只能包含非静态的方法、属性、事件、索引器
    //接口成员是隐式public，不允许有任何修饰符，但接口可以声明public、protected、internal、private
    //如果类派生自基类并实现了接口，基类列表中的基类名称必须放在所有接口之前，如下所示
    //class Derived:MyBaseClass,IIfc1,IEnumerable,..{}除了第一个后面都是接口
    //接口是引用类型
    //实现多接口
    public interface IDataRetrieve
    {
        int GetData();
    }

    public interface IDataStore
    {
        void SetData(int x);
    }

    public class MultiInter : IDataRetrieve, IDataStore
    {
        private int _data;
        public int GetData()
        {
            return _data;
        }

        public void SetData(int x)
        {
            _data = x;
        }
    }
    //如果一个类实现多个接口，并且其中一些接口成员具有相同的签名和返回类型，那么类可以实现单个成员来满足所有包含重复成员的接口
    public interface IIfc1
    {
        void PrintOut1(string x);
    }
    public interface IIfc2
    {
        void PrintOut2(string x);
    }

    public interface IData : IIfc1, IIfc2
    {
        void PrintOut3(string x);
    }

    public class Over : IData
    {
        public void PrintOut1(string x)
        {
            throw new NotImplementedException();
        }

        public void PrintOut2(string x)
        {
            throw new NotImplementedException();
        }

        public void PrintOut3(string x)
        {
            throw new NotImplementedException();
        }
    }
    
    
}
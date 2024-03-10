using System;

namespace Csharp_learn
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Time time = new Time();
            Console.WriteLine(time.TimeOfInstantiation);
        }
        
        
    }

    static public class Tool
    {
        static public void Change(Student student)
        {
            student.age = student.age + 5;
        }
        
        static public void RefAsPara(ref Student student)
        {
            student.age = 50;
            Console.WriteLine(student.age);
            student = new Student();
            Console.WriteLine(student.age);
        }

        static public void OutAsPara(out Student result)
        {
            result = new Student();
            result.age = 50;
        }

        static public void ListPara(params int[] paras)
        {
            foreach (var i in paras)
            {
                    Console.WriteLine(i);
            }
        }

        static public void ArrayPara(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 5;
            }
        }

        static public int Add(int x, Student student = null)
        {
            return x;
        }

    }

    public class Student
    {
        // const和static无法同时出现
        // public const/static int 顺序比较优雅
        public const int num = 100;
        public int age = 10;
        private int grade = 5;

        public int Grade
        {
            get => grade;
        }

    }
    public class Rectangle
    {
        private double a=3.6;
        private double b=4.0;

        public double Area
        {
            get
            {
                return a * b;
            }
        }
    }

    public class Time
    {
        // private字段使用_驼峰
        // public字段和属性使用首字母大写
        private DateTime _timeOfInstantiation;
        public DateTime TimeOfInstantiation
        {
            get { return _timeOfInstantiation; }
        }
        //析构器
        //public析构器可以外部使用，private析构器只能类内部使用
        public Time()
        {
            _timeOfInstantiation = DateTime.Now;
        }
    }
}
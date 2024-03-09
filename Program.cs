using System;

namespace Csharp_learn
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Tool.OutAsPara(out Student student);
            Console.WriteLine(student.GetHashCode());
        }
        
        
    }

    static public class Tool
    {
        static public void Change(Student student)
        {
            student.Age = student.Age + 5;
        }

        static public void Add(ref int number)
        {
            number += 5;
        }

        static public void RefAsPara(ref Student student)
        {
            student.Age = 50;
            Console.WriteLine(student.Age);
            student = new Student();
            Console.WriteLine(student.Age);
        }

        static public void OutAsPara(out Student result)
        {
            result = new Student();
            result.Age = 50;
        }
    }

    public class Student
    {
        public int Age = 10;
    }
}
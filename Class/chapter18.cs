using System;
using System.Configuration;

namespace Csharp_learn.Class
{
   //泛型结构
   struct PieceOfData<T>
   {
      private T data;

      public T Data
      {
         get { return data; }
         set { data = value; }
      }
      public PieceOfData(T value)
      {
         data = value;
      }
      
      
   }
   
   //泛型委托
   delegate void DelegateOne<T>(T value);
   //另一个泛型实例
   delegate TR Func<T1, T2, TR>(T1 t1, T2 t2);
   public class Simple
   {
      public static void PrintString(string s)
      {
         Console.WriteLine(s);
      }

      public static void PrintUpperString(string s)
      {
         Console.WriteLine($"{s.ToUpper()}");
      }

      public static string PrintString(int p1, int p2)
      {
         return (p1 + p2).ToString();
      }
   }
   //泛型接口
   interface IDel<T>
   {
      T ReturnIt(T inValue);
   }

   public class Diff<T> : IDel<T>
   {
      public T ReturnIt(T inValue)
      {
         return inValue;
      }
   }
   //实现泛型接口的非泛型类
   public class DiffNew : IDel<int>
   {
      public int ReturnIt(int inValue)
      {
         return inValue;
      }
   }
   public class ProgramTwo
   {
      public static void Main1()
      {
         DelegateOne<string> myDel = Simple.PrintString;
         myDel += Simple.PrintUpperString;
         myDel("Hello World");
         Func<int, int, string> func = Simple.PrintString;
         Console.WriteLine(func(5, 6));
         Diff<string> diff = new Diff<string>();
         Console.WriteLine(diff.ReturnIt("abc"));
      }
   }
}
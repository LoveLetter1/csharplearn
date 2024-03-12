using System;
using System.Reflection;
using System.Threading;
using Csharp_learn.Class;

namespace Csharp_learn
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyArray myArray = new MyArray();
            myArray.Print();
            var arr = new[]{ 1, 2, 3 };
        }
        
    }
    
}
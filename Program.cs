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
            ClassTwo classTwo = new ClassTwo();
            classTwo.PrintNew(5);
        }
        
    }
    
}
using System;
using System.Reflection;
using System.Threading;
using ClassLibrary1;
using Csharp_learn.Class;
using MyMath = ClassLibrary1.MyMath;

namespace Csharp_learn
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyMath myMath = new MyMath(2, 3);
            myMath.Add();
        }
        
    }
    
}
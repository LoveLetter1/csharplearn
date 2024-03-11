using System;
using Csharp_learn.Class;

namespace Csharp_learn
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            OtherClass otherClass = new OtherClass();
            otherClass.Method1(otherClass.Field1);
            otherClass.Method1(otherClass.Field2);
            otherClass.Method2(otherClass.Field1);
            otherClass.Method2(otherClass.Field1);
        }
        
    }
    
}
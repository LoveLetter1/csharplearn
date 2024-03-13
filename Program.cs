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
            Incrementer incrementer = new Incrementer();
            Dozens dozens = new Dozens(incrementer);
            incrementer.DoCount();
            Console.WriteLine(dozens.DozensCount);
        }
        
    }
    
}
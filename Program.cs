using System;
using Csharp_learn.Class;

namespace Csharp_learn
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            User user = new User("mike");
            Console.WriteLine($"{user.UserId},{user.UserName},{user.Field1}");

        }
        
    }
    
}
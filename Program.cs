//This is a C# program using the while loop to index the number given
using System;
namespace Indexing.cs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int index = 1;
            while (index <= 5)
            { 
                Console.WriteLine(index);
                index++;
            }
        }
    }
}
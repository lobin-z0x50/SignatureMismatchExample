using Lib;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- App started ---");

            var c1 = new Class1();
            c1.Print("Hello World!");
        }
    }
}

namespace Lib
{
    public class Class1
    {
        public void Print(string message)
        {
            Print(message, null);
        }

        public void Print(string message, string? opt)
        {
            System.Console.Write("[Print] msg=");
            System.Console.WriteLine(message);
            if (opt != null)
            {
                System.Console.Write("        opt=");
                System.Console.WriteLine(opt);
            }
        }
    }
}

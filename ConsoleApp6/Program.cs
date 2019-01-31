using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string name = "Peter Millet";
                Console.WriteLine("Hello " + name);
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("An error has occured");
                Console.WriteLine("Press any key to close the program");
                Console.ReadKey(true);
            }
        }
    }
}

using System;
using System.IO;
using System.Linq;
namespace Shopping
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int x = 10000;

            while (x > 100)
            {


                String path = @"C:\Users\Jere\source\repos\Shopping\Shoppinglist.txt";
                Console.WriteLine("Anna tuote:  ");
                string tuote = Console.ReadLine();
                File.AppendAllText(path, tuote + Environment.NewLine);
                String line;

                try
                {

                    StreamReader sr = new StreamReader(@"C:\Users\Jere\source\repos\Shopping\Shoppinglist.txt");

                    line = sr.ReadLine();

                    while (line != null)
                    {

                        Console.WriteLine(line);

                        line = sr.ReadLine();
                    }

                    sr.Close();
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
                finally
                {
                    Console.WriteLine("Executing finally block.");
                }
            }
        }
    }
}

using System;

namespace CG_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] value = new string [] { 1, 1, 2, 3, 5, 8 };
            foreach (string values in value)
            {
                Console.WriteLine(values);
            }

            Console.ReadLine();
        }
    }
}

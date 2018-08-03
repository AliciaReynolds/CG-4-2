using System;

namespace CG_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*So this creates our array on one line.  Initally I used var but the program
            got angry at me and I don't know why. I tried changing the variable type within
            the foreach statement but it didn't like that.  I tried having the variable types all
            be string but then I either had to convert the numbers to a string to get it to read
            or I would have to put each number in quotations. Which just seemed like a lot of 
            unnecessary work.  So I made it all the variable types
            to be int, which seems to have appeased the beast.*/
              
         
            int [] value = new int[] { 1, 1, 2, 3, 5, 8 };
            foreach (int values in value)
            {
                Console.WriteLine(values);
            }

            Console.Readline();

        }
    }
}

using System;

namespace ForLoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Natural numbers from 1 to 10:");

            for (int i = 1; i <= 10; i++)
            {                               
                Console.WriteLine(i);                
            }


            Console.WriteLine("\nEven numbers from 1 to 10:"); // "\n" is the new line character which moves the cursor to the next line on the output window (console)

            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            Console.WriteLine("\nNatural numbers backwards from 10 to 1:");

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("\nNatural numbers backwards from 10 to 1  (skipping one number at every step):");

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
                i--; // i-- can also be written as i += 1 or i = i + 1
            }


            Console.WriteLine("\nEven numbers backwards from 10 to 1:");

            for (int i = 10; i > 0; i -= 2)
            {
                Console.WriteLine(i);
            }


            Console.WriteLine("\nAn inverted triangle comprised of #:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 6; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}

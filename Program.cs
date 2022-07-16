using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("how many obama's: ");
            int obama = Convert.ToInt32(Console.ReadLine());
            Console.Write("how many cares: ");
            int care = Convert.ToInt32(Console.ReadLine());
            Console.Write("what last name character: ");
            string? lastname = Console.ReadLine();
            for (int i = 0; i < obama; i++)
            {
                for (int j = 0; j < care; j++)
                {
                    Console.Write(lastname);
                }
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}

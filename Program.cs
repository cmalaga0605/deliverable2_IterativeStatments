using System;

namespace deliverable2_IterativeStatments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a value between 1 and 100 ");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input >= 1 && input <= 100)
            {
                for (int iteration = 0; iteration <= input; iteration++)
                {
                    Console.WriteLine("You have entered " + input +"." + " This is the current value in the loop : " + iteration);
                }
            }
        }
    }
}

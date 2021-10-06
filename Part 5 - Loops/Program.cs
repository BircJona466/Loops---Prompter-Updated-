using System;

namespace Part_5___Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int min;
            int max;
            int i;
            

            Console.WriteLine("Please enter your minimum number..");
            min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your maximum number..");
            max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a number between " + min + " and " + max );
            i = Convert.ToInt32(Console.ReadLine());

            while ((i <= min || (i >= max)))
            { 

                Console.WriteLine("That's not a number between " + min + " and " + max );
                    Console.WriteLine("Please enter a number between " + min + " and " + max );
                    i = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Thank you!");








            }
    }
}

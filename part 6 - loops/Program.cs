using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part_6___loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();

            int minimum;
            int maximum;
            int between;


            int score;
            int above =0;
            int total=0;
            bool done = false;

            int input;
            int x= 0;
            int answer = 0;

            int min;
            int max;
            int ran;




            Console.WriteLine("Please enter a minimum");
            minimum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now enter a maximum");
            maximum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Now enter a numer in between {minimum} and {maximum}.");
            between = Convert.ToInt32(Console.ReadLine());

            while (between< minimum || between >maximum)
            {
                Console.WriteLine($"{between} is not in between {minimum} and {maximum}.");
                Console.WriteLine("");
                Console.WriteLine($"Now enter a numer in between {minimum} and {maximum}.");
                between = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"{between} is between {minimum} and {maximum}.");
            Console.WriteLine("_________________________________________________________________________________________________________");

            while (!done)
            {
                Console.WriteLine("Enter a % you got on a test");
                score = Convert.ToInt32(Console.ReadLine());
                if (score >= 70)
                {
                    above += 1;
                }
                total += 1;
                Console.WriteLine("do you have another score???");
                if (Console.ReadLine().ToLower() != "yes" )
                     done = true;
                
            }
            Console.WriteLine($"{((double)above / total) *100} % of your tests are over 70%");
            Console.WriteLine("__________________________________________________________________________________________________");

            Console.WriteLine("Please enter a number:");
            input = Convert.ToInt32(Console.ReadLine());

            for (x=1; x<= input; x+= 2)
            {
                answer +=x;
            }
            Console.WriteLine($"If you add all the odd numbers from 1 to {input} is {answer}");


            Console.WriteLine("__________________________________________________________________________________________________________");
            Console.WriteLine("Please enter a minimum:");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now enter a maximum");
            max = Convert.ToInt32(Console.ReadLine());
            for (int i =1; i <=25; i++)
            {
                ran = generator.Next(min, max);
                Console.WriteLine("");
                Console.WriteLine(ran);
            }











                Console.ReadLine();
        }
    }
}

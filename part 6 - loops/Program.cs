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

            int score;
            int above =0;
            int total=0;
            
            
            bool done = false;
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























            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionProgramming
{
    internal class FlipCoin
    {
       public static void HeadAndTail()
        {
            int h_count = 0;
            int t_count = 0;
            Console.WriteLine("Enter number of times you want to flip the coin :");
            int n = Convert.ToInt32(Console.ReadLine());
            double heads, tails;
            for(int i=0; i < n; i++)
            {
                Random random = new Random();
                int v = random.Next(0, 2);
                Console.WriteLine("random value : " +v);
                if(v == 0)
                {
                    t_count++;
                }
                else
                {
                    h_count++;
                }
            }
            heads = h_count / (double)n * 100;
            tails = t_count / (double)n * 100;
            Console.WriteLine("percentage of heads : " +heads+ "%");
            Console.WriteLine("percentage of tails : " +tails+ "%");

        }
    }

}

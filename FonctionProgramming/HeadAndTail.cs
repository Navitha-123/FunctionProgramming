using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FonctionProgramming
{
    internal class HeadAndTail
    {
        public static void HeadAndTailPercentage()
        {
            int percentage = 1;
            int Head = 0;
            int Tail = 0;
            Random random = new Random();
            int result = random.Next(0, 1);
            if (percentage > 0.5)
            {
                Console.WriteLine("Flip coin is Head");

            }
            else
            {
                Console.WriteLine("Flip coin is Tail");
            }

        }
    }
}

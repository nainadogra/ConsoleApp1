using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class A1Q4
    {
        public static void participant()
        {
            int[] participantCodes = { 102, 215, 324, 453, 536 };

            int maleCount = 0;
            int femaleCount = 0;

            for (int i = 0; i < participantCodes.Length; i++)
            {
                if (participantCodes[i] % 2 == 0) // even code, male participant
                {
                    maleCount++;
                }
                else // odd code, female participant
                {
                    femaleCount++;
                }
            }

            Console.WriteLine("Survey Report:");
            Console.WriteLine("Male participants: " + maleCount);
            Console.WriteLine("Female participants: " + femaleCount);
        }
    }
}


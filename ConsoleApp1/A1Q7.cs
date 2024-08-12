using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class A1Q7
    {
        public static void book()
        {
            int[] bookCodes = { 101, 203, 304, 405, 506 };
            int searchCode = 304;

            int index = SearchBookCode(bookCodes, searchCode);

            if (index != -1)
            {
                Console.WriteLine("Book code " + searchCode + " found at index " + index);
            }
            else
            {
                Console.WriteLine("Book code " + searchCode + " not found");
            }
        }

        static int SearchBookCode(int[] bookCodes, int searchCode)
        {
            for (int i = 0; i < bookCodes.Length; i++)
            {
                if (bookCodes[i] == searchCode)
                {
                    return i;
                }
            }
            return -1; // not found
        }
    }

}

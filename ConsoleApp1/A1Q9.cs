using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class A1Q9
    {
        public static void Id()
        {
            int[] ids = { 102, 215, 102, 324, 215 };

            int[] uniqueIds = RemoveDuplicates(ids);

            Console.WriteLine("Unique IDs:");
            foreach (int id in uniqueIds)
            {
                Console.WriteLine(id);
            }
        }

        static int[] RemoveDuplicates(int[] ids)
        {
            List<int> uniqueList = new List<int>();

            foreach (int id in ids)
            {
                if (!uniqueList.Contains(id))
                {
                    uniqueList.Add(id);
                }
            }

            return uniqueList.ToArray();
        }
    }
}

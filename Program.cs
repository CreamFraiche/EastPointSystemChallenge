using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //'Repository Pattern'
            int[] testCodes = new int[9] { 62102, 61022, 61023, 61021, 61123, 61027, 61025, 62100, 62101 };
            int[] testCodes2 = new int[11] { 65102, 65022, 65023, 65021, 65024, 65027, 65025, 65100, 65101, 65111, 65112 };

            //Instantiate Regions
            Region test = new Region(testCodes, "Region 1");
            Region test2 = new Region(testCodes2, "Region 2");

            //Test Output Region 1
            Console.WriteLine("All Codes of " + test.getName());
            foreach (int code in test.getAll())
            {
                Console.WriteLine(code);
            }

            Console.WriteLine("Individual groups of " + test.getName());
            for (int i = 0; i < test.getGroupAmt(); i++)
            {
                Console.WriteLine("Group Number: " + i);

                foreach (int code in test.getGroup(i))
                {
                    Console.WriteLine(code);
                }
            }

            //Region 2
            Console.WriteLine("All Codes of " + test2.getName());
            foreach (int code in test2.getAll())
            {
                Console.WriteLine(code);
            }

            Console.WriteLine("Individual groups of " + test2.getName());
            for (int i = 0; i < test2.getGroupAmt(); i++)
            {
                Console.WriteLine("Group Number: " + i);

                foreach (int code in test2.getGroup(i))
                {
                    Console.WriteLine(code);
                }
            }

            //Optional for Output reading purposes
            System.Threading.Thread.Sleep(8000);
        }
    }
}

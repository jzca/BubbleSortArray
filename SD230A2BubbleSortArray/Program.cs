using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SD230A2BubbleSortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var newInput = new List<int>()
            {
                8, -1, 7, 9, 4, -10, 0, 6, 2
            };

            int temp = 0;

            // Two layers of for loop, create a producting sloution
            // that the main function loop would repeat dozens of times or more if needed
            // to swap two numbers as [Bubble Sort] suggests.

            for (int s = 0; s < newInput.Count - 1; s++)
            {
                for (int i = 0; i < newInput.Count - 1; i++)
                {

                    // If Index 1 is Bigger Than Index 2

                    if (newInput[i] > newInput[i + 1])
                    {
                        // Put Index 1 to temp
                        temp = newInput[i];
                        // Make I1 is I2 because it's bigger
                        newInput[i] = newInput[i + 1];
                        // Make I2 is I1 because it's smaller
                        newInput[i + 1] = temp;
                    }
                }
            }

            newInput.ForEach(p => Console.WriteLine(p));
            Console.ReadLine();
        }
    }
}

// More test 8, -1, 7, 9, 4, -10, 0, 6, 2
// ,-11,-11,-100,12,45,546,54
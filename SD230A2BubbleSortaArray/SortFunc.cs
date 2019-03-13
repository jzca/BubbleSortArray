using System;
using System.Collections.Generic;
using System.Text;

namespace SD230A2BubbleSortaArray
{
    class SortFunc
    {
        public List<int> Input { get; set; }

        public SortFunc()
        {
            Input = new List<int>()
            {
                8, -1, 7, 9, 4, -10, 0, 6, 2
            };
        }

        public object SortFuncDetail()
        {

            for (int i = 0; i < Input.Count; i++)
            {
                if (i > i + 1)
                {
                    Console.WriteLine(i);
                }
            }

            return Console.ReadLine();
        }



    }
}

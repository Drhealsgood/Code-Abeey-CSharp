using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeAbbeyProblems
{
    class Problems
    {
        /// <summary>
        /// returns the sum of x and y
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>x + y</returns>
        public static int SumOfTwoVars(int x, int y)
        {
            return x + y;
        }

        /// <summary>
        /// http://www.codeabbey.com/index/task_view/sum-in-loop
        /// </summary>
        /// <param name="n"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int SumInLoop(List<int> values)
        {
            return values.Sum();
        }

        public static List<int> SumsInLoop(List<List<int>> values)
        {
            List<int> output = new List<int>();
            foreach(List<int> vs in values)
            {
                output.Add(SumInLoop(vs));
            }
            return output;
        }

        public static List<int> MinofTwoNumbersMultiple(List<List<int>> input)
        {
            List<int> values = new List<int>();
            foreach(List<int> set in input)
            {
                values.Add(set.Min());
            }
            return values;
        }

        public static int MinOfTwoNumbers(int x, int y)
        {
            if (x < y) return x;
            return y;
        }

        public static int MinOfThreeNumbers(int x, int y, int z)
        {
            if (z < y || x < y)
            {
                if (x < z)
                {
                    return x;
                }
                return z;
            }
            return y;

        }

        public static int[] MaximumOfAnArray(int [] values)
        {
            int max = -50000;
            int min = 50000;
            foreach(int v in values)
            {
                if (v > max)
                {
                    max = v;
                }
                if (v < min)
                {
                    min = v;
                }
            }
            Console.WriteLine(String.Format("{0} {1}", max, min));
            return new int [] {max, min};
        }
    }
}

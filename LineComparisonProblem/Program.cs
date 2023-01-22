using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    public class program
    {
        public static void LenghtOfLine(int x1, int y1, int x2, int y2)
        {
            double result = (x2 - x1) ^ 2 + (y2 - y1) ^ 2;
            double c = Math.Sqrt(result);
            Console.WriteLine(c);
        }
        public static void Main(string[] args)
        {
            LenghtOfLine(1, 2, 3, 4);
        }
    }
}
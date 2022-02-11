using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineCompareProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            LineCompare line1 = new LineCompare(3, 5, 4, 5);
            line1.CalculateLength();
            LineCompare line2 = new LineCompare(1, 2, 4, 5);
            line2.CalculateLength();

            if (line1.Equals(line2))
                if (line1.CalculateLength() > line2.CalculateLength())
                {
                    Console.WriteLine("Lines are  equal \n");
                    Console.WriteLine("Line1 is greater than line2 \n");
                }
                else
                if (line1.CalculateLength() < line2.CalculateLength())
                {
                    Console.WriteLine("Lines are not equal \n");
                    Console.WriteLine("Lines1 is smaller than Line2 \n");
                }
            if (line1.CalculateLength() == line2.CalculateLength())
            {
                Console.WriteLine("Line1 are line2 are equal \n");
            }
            Console.ReadLine();
        }
    }
}

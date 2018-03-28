using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2A
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        
        public class SumScores
        {
            public void add(double y)
            {
                Console.WriteLine("Please enter a number between 0 - 100: ");
                double x1 = double.Parse(Console.ReadLine();
                if (x1 < 0 || x1 > 100)
                {
                    Console.WriteLine("Number must be between 0 - 100. Please enter number: ");
                }
            }
        }
    }
}

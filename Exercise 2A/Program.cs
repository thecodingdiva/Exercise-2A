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
            SumScores sum = new SumScores();
            Add.SumScores();
        }
        
        public class SumScores
        {
            public void Add(double y)
            {
                Console.WriteLine("Please enter a number between 0 - 100: ");
                double x1 = double.Parse(Console.ReadLine());
                if (x1 < 0 || x1 > 100)
                {
                    Console.WriteLine("Number must be between 0 - 100. Please enter number: ");
                    double.Parse(Console.ReadLine());
                }
                else
                {
                    x1 = double.Parse(Console.ReadLine());
                }
            }
        }
    }
}

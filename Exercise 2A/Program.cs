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
            ////Answer for Basic
            //SumScores sum = new SumScores();
            //sum.scoreAvg();

            ////Answer for Intermediate
            //Intermediate sum2 = new Intermediate();
            //sum2.IntermediateScoreAvg();

            //Answer for Advanced
            Advanced sum3 = new Advanced();
            sum3.IntermediateScoreAvg();
        }

        public class SumScores
        {
            public double Add()
            {
                double x1, x2, x3, x4, x5, x6, x7, x8, x9, x10;
                Console.WriteLine("Please enter a number between 0 - 100. 1: ");
                x1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a number between 0 - 100. 2: ");
                x2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a number between 0 - 100. 3: ");
                x3 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a number between 0 - 100. 4: ");
                x4 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a number between 0 - 100. 5: ");
                x5 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a number between 0 - 100. 6: ");
                x6 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a number between 0 - 100. 7: ");
                x7 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a number between 0 - 100. 8: ");
                x8 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a number between 0 - 100. 9: ");
                x9 = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter a number between 0 - 100. 10: ");
                x10 = double.Parse(Console.ReadLine());

                double y = x1 + x2 + x3 + x4 + x5 + x6 + x7 + x8 + x9 + x10;
                Console.WriteLine("The sum of your scores is: " + y);
                return y;
            }

            public double scoreAvg()
            {
                char letterGrade;
                double sum = Add();
                double avg = sum/10;

                if (avg >= 90)
                {
                    letterGrade = 'A';
                }
                else if (avg > 80)
                {
                    letterGrade = 'B';
                }
                else if (avg > 70)
                {
                    letterGrade = 'C';
                }
                else if (avg > 60)
                {
                    letterGrade = 'D';
                }
                else
                {
                    letterGrade = 'F';
                }

                Console.WriteLine("The average is: " + avg);
                Console.WriteLine("The letter grade is: " + letterGrade);
                return avg;
            }
    }
    }
}


    


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2A
{
    class Advanced
    {
        public double Add()
        {
            double[] scores = new double[0];
            int i = 0;
            int arrayLen = 0;
            Console.ReadLine();

            if (Console.ReadLine() != "done")
            {               
                while (Console.ReadLine() != "done");
                {
                    Console.WriteLine("Please Enter Score or 'done': ");
                    Console.ReadLine();
                    scores[i] = Convert.ToInt32(Console.ReadLine());
                    i++;
                }
            }
            else
            {
                arrayLen = i;
            }

            double sumOfScores = scores.Sum();
            double avg = sumOfScores / arrayLen;
            Console.WriteLine(sumOfScores);
            return avg;
        }

            public double IntermediateScoreAvg()
        {
            char letterGrade;
            double avg = Add();

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

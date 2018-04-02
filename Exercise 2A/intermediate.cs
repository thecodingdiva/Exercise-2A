using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2A
{
    class Intermediate
    {
        public double Add()
        {
            Console.WriteLine("How many scores do you have to enter? ");
            int numOfScores = Convert.ToInt32(Console.ReadLine());

            double[] scores = new double[numOfScores];

            int i = 0;
            while (i < scores.Length)
            {
                Console.WriteLine("Please enter score: ");
                scores[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
                     
            double sumOfScores = scores.Sum();
            double avg = sumOfScores / numOfScores;
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
            else if (avg >= 80)
            {
                letterGrade = 'B';
            }
            else if (avg >= 70)
            {
                letterGrade = 'C';
            }
            else if (avg >= 60)
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

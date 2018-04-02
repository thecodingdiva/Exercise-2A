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
            int i = 0;
            int flag = 1;
            double scores = 0;

            while (flag != -1)
            {
                Console.WriteLine("Please Enter Score or '-1': ");
                flag = Convert.ToInt32(Console.ReadLine());
                scores += Convert.ToInt32(flag);
                i++;                
            }         

            double avg = scores / (i-1);
            Console.WriteLine(avg);
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

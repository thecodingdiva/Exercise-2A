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

            double sumOfScores = scores.Sum();




            return sumOfScores;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLab
{
    class BaseballArray
    {
        public string[] baseballStatsName;
        public double[] baseballStats;
        double slugPercentage;


        public BaseballArray()
        {
            baseballStatsName = new string[] { "Games", "At Bats", "Runs", "Hits", "Total Bases" };
            baseballStats = new double[5];

        }
        public void AddUserInput()
        {
            for (int i = 0; i < baseballStatsName.Length; i++)
            {
                Console.WriteLine("Please enter the baseball stats for {0}:", baseballStatsName[i]);
                baseballStats[i] = Convert.ToDouble(Console.ReadLine());
            }
        }

        public void CalculateSlugPercentage()
        {
            slugPercentage = ((baseballStats[4] / baseballStats[1]) * 100);
            Console.WriteLine("\nYour player's slugging percentage is " + Convert.ToInt32(slugPercentage) + "%.");
            Console.ReadLine();
        }
    }
}

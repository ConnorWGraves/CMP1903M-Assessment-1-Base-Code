using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    class Report
    {
        string answer;
        //Handles the reporting of the analysis
        public static void decision(List <string> Measurements)
        {
            foreach(var measurement in Measurements)
            {
                Console.WriteLine(measurement);
            }
            //Console.WriteLine(Measurements);
            Console.ReadLine();
        }



    }
}

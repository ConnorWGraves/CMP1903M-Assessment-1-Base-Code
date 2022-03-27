﻿//Base code project for CMP1903M Assessment 1
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Code traversal:
Program.cs - Handles the other files
Inputs.cs - Handles inputs
Analyse.cs - main bulk, will search the text
Report.cs - Handles the output to the user
*/
namespace CMP1903M_Assessment_1_Base_Code
{
    class Program
    {
        static void Main()
        {
            //Local list of integers to hold the first five measurements of the text
           

            //Create 'Input' object
            var input = new Input();

            //Get either manually entered text, or text from a file
            var ToAnalyse = input.GetText();

            //Create an 'Analyse' object
            var analysis = new Analyse();

            //Pass the text input to the 'analyseText' method
            var results = analysis.analyseText(ToAnalyse);
            


            //Receive a list of integers back


            //Report the results of the analysis
            Report report = new Report();
            report.decision();
            report.report();

            //TO ADD: Get the frequency of individual letters?

           
        }
        
        
    
    }
}

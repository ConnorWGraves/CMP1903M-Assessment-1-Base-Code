//Base code project for CMP1903M Assessment 1
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

            //Create 'Input' object
            var Input = new Input();

            
            var ToAnalyse = Input.GetText();

            //Create an 'Analyse' object
            var analysis = new Analyse();

            //Pass the text input to the 'analyseText' method
            
            analysis.analyseText(ToAnalyse);
            


            

           
        }
        
        
    
    }
}

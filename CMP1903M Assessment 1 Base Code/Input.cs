using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        public string GetText()
        {
            //A welcoming title for the user to be welcomed wtih
            Console.WriteLine("--------------------");
            Console.WriteLine("  Welcome to...");
            Console.WriteLine("      TEXT ANALYSIS");
            Console.WriteLine("--------------------");

            Console.WriteLine("Would you like to input you're own text or import a .txt file \n(file/self)");
            
            string option = Console.ReadLine();
            string Text = "NULL";
            if (option == "file")

            {

                Console.WriteLine("\nWhere is the file located?(\n(enter file path)");
                while (true)
                {
                    Location = Console.ReadLine();
                    if (File.Exists(Location)) // checking the location exsits before going forward
                    {
                        break;
                    }
                    Console.WriteLine("File not found please try again\n");
                }

                text = System.IO.File.ReadAllText(Location);
            }
            if (option == "self")
            {
                //Collects the raw text from the user
                Console.WriteLine("Write your text here:");
                text = Console.ReadLine();
            }

       
                      

          // Returns the text that it has retreieved
            return Text;
        }

        
       

        

       

    }
}

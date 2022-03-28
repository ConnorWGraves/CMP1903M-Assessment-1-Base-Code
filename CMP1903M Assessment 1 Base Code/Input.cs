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
                    if (File.Exists(Location))
                    {
                        break;
                    }
                    Console.WriteLine("File not found please try again\n");
                }

                text = System.IO.File.ReadAllText(Location);
            }
            if (option == "self")
            {

                Console.WriteLine("Write your text here:");
                text = Console.ReadLine();
            }

            else
            {

                Console.WriteLine("Input not recognised try again:\n");
                text = Console.ReadLine();
            }

                   

                        
             

          
            return Text;
        }

        
        //Handles the text input for Assessment 1
        string text = "nothing";
        private string Location;

        //Method: manualTextInput
        //Arguments: none
        //Returns: string
        //Gets text input from the keyboard
        public string manualTextInput()
        {

            return text;
        }

        //Method: fileTextInput
        //Arguments: string (the file path)
        //Returns: string
        //Gets text input from a .txt file
        public string fileTextInput(string fileName)
        {

            return text;
        }

    }
}

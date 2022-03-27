using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Assessment_1_Base_Code
{
    public class Input
    {
        public void GetText()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("  Welcome to...");
            Console.WriteLine("      TEXT ANALYSIS");
            Console.WriteLine("--------------------");

            Console.WriteLine("Would you like to input you're own text or import a .txt file \n(file/self)");
            while(true)
            {
                string option = Console.ReadLine();
                switch (option)
                {
                    case "file":
                        Console.WriteLine("\nWhere is the file located?(\n(enter file path)");
                        while(true)
                        {
                            string Location = ReadLine();
                            if (FileStyleUriParser.Exists(location))
                            {
                                break;
                            }
                            Console.WriteLine("File not found please try again\n");
                        }
                        var Text = System.IO.File.ReadAllText(Location);
                        while(false)
                        break;
                    
                    case "self":
                        Console.WriteLine("Write your text here:");
                        var Text =Console.ReadLine();
                        while(false)
                        break;
                    
                    default:
                        Console.WriteLine("Input not recognised");

                        break;

                        
                }

            }
            return Text;
        }
        //Handles the text input for Assessment 1
        string text = "nothing";
        
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

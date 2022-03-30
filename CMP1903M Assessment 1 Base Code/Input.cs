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
            
            
            while(true)
            { 
                string option = Console.ReadLine();
                if (option == "file")

                {

                    Console.WriteLine("\nWhere is the file located?(\n(enter file path)");
                    while (true)
                    {
                    
                        string Location = Console.ReadLine();
                        if (File.Exists(Location))
                        {
                            return System.IO.File.ReadAllText(Location);
                        }
                        Console.WriteLine("File not found please try again\n");
                    }

                
                }
                if (option == "self")
                {
                    string text = "";
                    while (text == "")
                    {
                        text = Console.WriteLine("Write your text here (Make sure it isn't blank):\n");
                    }
                    return Console.ReadLine();
                }

                else
                {

                    Console.WriteLine("Input not recognised try again:\n");
                    
                }

                   
            }
                        
             

          
            
        }

        
       

    }
}

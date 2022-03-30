using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace CMP1903M_Assessment_1_Base_Code
{
    public class Analyse
    {
        

        public void analyseText(string input) 
            
        {
            var report = new Report(); //Creating the new instance of class ready to be worked on            
            switch (input)
            {
                case "": //If no input found
                    Console.WriteLine("No input found"); //Error Handling
                    break; 

                default:

                    List<string> Measurements = new();
                    //1. Number of sentences
                    //Calculates sentences by the amount of sentence ending punctuation
                    int sentence = 0;
                  
                    for (int i = 0; i < input.Length; i++)
                    {
                        string sentences = input[i].ToString();
                        if (".?!".Contains(sentences)) 
                        {
                            sentence++;
                        }
                    }
                    string sentenceStr = (sentence.ToString());
                    Measurements.Add(sentenceStr);//adds the new metric to the array



                    //2. Number of vowels
                    int vowelcount = 0;
                    for (int i = 0; i < input.Length; i++)
                    {
                        string vowel = input[i].ToString();
                        if ("aeiouAEIOU".Contains(vowel)) 
                        {
                            vowelcount++;
                        }
                    }

                    string vowelStr = ("Vowel Count: "+ vowelcount.ToString());
                    Measurements.Add(vowelStr);



                    //3. Number of consonants
                    int consonantcount = 0;
                    for (int i = 0; i < input.Length; i++)
                    {
                        string consonant = input[i].ToString();
                        if ("bcdfghjklmnpqrstvwxyzBCDFGHJKLMNPQRSTVWXYZ".Contains(consonant)) //If consonant is found, lower or upper case 
                        {
                            consonantcount++;
                        }
                    }
                    string constantStr = ("Constant count: " + consonantcount.ToString());
                    Measurements.Add(constantStr); 



                    //4. Number of upper case letters
                    int uppercount = 0;
                    for (int i = 0; i < input.Length; i++)
                    {
                        string upper = input[i].ToString();
                        if ("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Contains(upper)) //If upper case letter is found
                        {
                            uppercount++;
                        }
                    }
                    string upperStr = ("Capital count: "+ uppercount.ToString());
                    Measurements.Add(upperStr);



                    //5. Number of lower case letters
                    int lowercount = 0;
                    for (int i = 0; i < input.Length; i++)
                    {
                        string lower = input[i].ToString();
                        if ("abcdefghijklmnopqrstuvwxyz".Contains(lower)) //If lower case letter is found
                        {
                            lowercount++;
                        }
                    }
                    string lowerStr = ("Lower characters count :"+ lowercount.ToString());
                    Measurements.Add(lowerStr);


                    //6. Most Common Character
                    int[] count = new int[128]; //Possible ASCII chars 
                    int maximum = 0;
                    Char result = Char.MinValue; //Char is initialised with a 0.
                    Array.Clear(count, 0, count.Length); //Zeroes out all the elements.

                    foreach (Char c in input)
                    {
                        if (c != ' ' && ++count[c] > maximum) //If total count > maximum and not a null value.
                        {
                            maximum = count[c];
                            result = c;
                            //If Two or more characters appear the same amount, the first alphabetically will display.

                        }

                    }
                    string Mode = ("Most common character" + result);
                    Measurements.add(Mode);


                    //7. Send our list of ints and strings to Report
                    
                    report.decision(Measurements);
                    break;

            }
                

 

        }

        
    }
}

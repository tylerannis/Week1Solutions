using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Review
{
    class Program
    {
        //declare a global variable called loopCount
        static int loopCount = 0;

        static void Main(string[] args)
        {
            StringBuilding("This is a really long and stupid and complicated string that i am writing off the top of my head");
            //print out the number of loops
            Console.WriteLine(loopCount);
            //Call our ListPractice
            ListPractice();
            //Call our ListPractice backwards
            ListPractice();
            //Call foreach
            ListPractice();
            Console.ReadKey();
        }
    
        //building a string, it's the equal to using a counter but for strings
        //This function will take in a string and output a string with all vowels capitalized, and all consonants lowercase.
        static void StringBuilding(string input)
        {
            
            //string.Empty means ""
            string output = "";
            //loop over each individual letter in input
            for (int i = 0; i < input.Length; i++)
            {
                //get an individual letter from input, the index number is [i]
                string letter = input[i].ToString();

                //time to find out if the letter you just found is a vowel
                //first declare a new string
                string vowels = "aeiou";
                if (vowels.Contains(letter.ToLower()))
                {
                    //it is a vowel
                    output = output + letter.ToUpper();
                }
                else
                    //add a lowercase letter to output
                {
                    output = output + letter.ToLower();
                }
                //we did a loop yay, so count it
                loopCount = loopCount + 1;
            }
            //print the output to the console
            Console.WriteLine(output);       
        }
        //working with LISTS
        static void ListPractice()
        {
            //declare a new list
            List<string> sportsList = new List<string>() { "Baseball", "Basketball", "Rugby", "Football", "Ping-Pong" };

            //print out the contents of sportsList using a for loop in proper order
            for (int i = 0; i < sportsList.Count; i++)
            {
                Console.WriteLine(sportsList[i]);
                //we done did a loop so count it
                loopCount++;
            }

            //print out sportsList using a for loop in reverse order
            //Dude you need to put -1 at the end of your .Count because we want it to start at the last index
            //i >= 0; i--
            for (int i = sportsList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(sportsList[i]);
            }

            //list out the contents of the sportsList using a foreach loop
            foreach (var item in sportsList)
            {
                Console.WriteLine(item);
            }
        }
    }
}

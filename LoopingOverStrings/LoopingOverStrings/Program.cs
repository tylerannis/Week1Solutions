using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingOverStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            FindALetter("e", "the united states of america");
            
        
            FindAWord("some", "Some of the people buy some stuff, some of the time, some of the stuff has some missing parts. Some people don't mind, but some people need to return the item.");

            Console.ReadKey();
        }

        //create a new function to loop over the letters of a string and count the number of a certain letter
        static void FindALetter(string letterToFind, string text)
        {
            //declare your variable to hold number of letter matches
            int letterCount = 0;

            //loop over the string
            for (int i = 0; i < text.Length; i++)
            {
                //get the current letter we are looking at and convert it to a string for ease of use
                string letter = text[i].ToString();

                //is this a letter we need to find?
                if (letter == letterToFind)
                {
                    //found a letter add to counter
                    letterCount = letterCount + 1;
                }
            }
            //time to display output
            Console.WriteLine("Found " + letterCount + " " + letterToFind + "'s in " + text);
        }
        //Create a function to loop over words in a string
        static void FindAWord(string wordToFind, string word)
        {
            int wordCount = 0;

            //split the string into words and convert the array to a list for ease of use
            List<string> words = word.Split(' ').ToList();

            //loop over each word
            for (int i = 0; i < words.Count; i++)
            {
                //get the current word out of our loop, use .tolower to standerdize your text
                string item = words[i];
                if (item.ToLower() == wordToFind.ToLower())
                {
                    //Count the word
                    wordCount = wordCount + 1;
                }
            }
            //output
            Console.WriteLine("Found " + wordCount + " " + wordToFind + "'s in " + word);
        }
    }
}

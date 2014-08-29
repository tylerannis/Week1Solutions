using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePracticeforChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            //using a for loop you can call said function for a certain series of numbers
            for (int i = 0; i <= 20; i++)
            {
                FizzBuzz(i);
            }
            for (int i = 92; i >= 79; i--)
            {
                FizzBuzz(i);
            }
            //call Yoadizer using (text)
            Yoadizer("I like code");
            //Call TextStats(input)
            TextStats("Craig: The Cybermen — they blew up! I blew them up with love! The Doctor: No, that's impossible — and also grossly sentimental and overly simplistic. You destroyed them because of the deeply ingrained hereditary trait to protect one's own genes — which in turn triggered a... a... uh... Yeah. Love. You blew them up with love.");
            //Call is prime
            for (int i = 1; i <= 25; i= i + 2)
            {
                IsPrime(i);
            }
            Console.ReadKey();  
        }
        static void FizzBuzz(int number)
        {
            //Make if else to find the parameters of the question(is number divisable by...
            if (number % 5==0 && number % 3 ==0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 ==0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
        }
        static void Yoadizer(string text)
        {
            List<string> texts = text.Split(' ').ToList();
            for (int i = texts.Count-1; i >= 0; i--)
            {
                Console.WriteLine(texts[i]);
            }
        }
        static void TextStats(string input)
        {
            //length of string
            Console.WriteLine(input.Length);
            //convert string to list then count of list
            List<string> list = input.Split(' ').ToList();
            Console.WriteLine(list.Count);

            //declare variables for counters
            int vCount = 0;
            int cCount = 0;
            int sCount = 0;
            //make a loop for your counters to run through and so you have an index i to set into your if statments
            for (int i = 0; i < input.Length; i++)
            {
                if ("aeiou".Contains(input[i]))
                {
                    vCount++;
                }
                else if ("qwrtypsdfghjklzxcvbnm".Contains(input[i]))
                {
                    cCount++;
                }
                else
                {
                    sCount++;
                }
            }
            //Don't forget to print your counters
            Console.WriteLine(vCount);
            Console.WriteLine(cCount);
            Console.WriteLine(sCount);
        }
        static void IsPrime(int number)
        {
            //when trying to find out if something is true use a bool variable
            bool yesPrime = true;
            //This for loop is imparitive to making sure that your function loop will run trough every number in your parameters, if you don't set i it would only run through % for the number you specified in the if statement you would use
                for (int i = 2; i < number; i++)
			{
                    //inside your loop is where you set your equation for finding if the numbers are prime
                if (number % i ==0)
                {
                    yesPrime = false;
                }                
			}
            //you have to write your console if statments outside of the loop with i
            if (yesPrime)
            {
                
                Console.WriteLine(number + " is a prime number");
            }
            else
            {
                Console.WriteLine(number);
            }      
        }

    }
}

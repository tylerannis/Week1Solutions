using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //How to call a function( just type the name in another function with (); after it
            HelloWorld();
            //Need Console.Readkey(); to keep the console from closing immediatly
            Console.ReadKey();
        }
        static void HelloWorld()
        {
            Console.WriteLine("HelloWorld");
           //calling Greet function
            Greet("Dustin");
        }
        static void Greet(string name)
        {
            Console.WriteLine("Hello, " + name);

           //Calling the DoubleIt function, this will make nothing appear on the console when we run it until we set a variable to it 'int sevenDoubled'
           int sevenDoubled = DoubleIt(7);
            //now we write something to the console about DoubleIt
           Console.WriteLine(sevenDoubled);
            //you can pass in functions usually you will pass in i for integer
           Console.WriteLine(DoubleIt(sevenDoubled));

            //call the Multiply function
           Console.WriteLine(Multiply(sevenDoubled, 9));

            //do a loop from 1 to 10 that triples each number
           for (int i = 1; i <= 10; i = i + 1)
           {
               Console.WriteLine(Multiply(i, 3));
           }
        }
        // Function DoubleIt is going to take in a number and spit out double that number
        static int DoubleIt(int num)
        {
            return num * 2;
        }

        static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}

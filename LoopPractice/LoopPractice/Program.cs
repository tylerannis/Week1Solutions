using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling WhileLoopTest function
            WhileLoopTest();

            //readkey to keep the console open
            Console.ReadKey();
        }
       
        static void WhileLoopTest()
        {
            //while loop from 1 to 10
            //first declare our incrementor or start point
            int i = 1;
            //next define the while loop condition
            while (i <= 10)
            {
                Console.WriteLine(i);
                //make sure that you actually set increment of variable
                i = i + 1;
            }
            FlipACoin(250);
        }
  
        //we will construct a for loop that is going to flip a coin and use a COUNTER to count how many times it landed on heads or tails
        static void FlipACoin(int flips)
        {
           //declaring ints to hold how many times we flipped heads and tails
            int countHeads = 0;
            int countTails = 0;

            //creat a random number generator
            //need to flip the coin
            Random rng = new Random();

          //flip the as many times as the flips (parameter) says we should
            for (int i = 0; i < flips; i = i + 1)
            {
                //FLIP THAT COIN
                int flip = rng.Next(0, 2);
                //this is where you tell the computer when to count what
                if (flip == 0)
                {
                    countTails = countTails + 1;
                }
                else
                {
                    countHeads = countHeads + 1;
                }
            }
           //what you input into the console
            Console.WriteLine("# of Heads: " + countHeads + "\n" + "# of Tails: " + countTails);

            //calling FlipForHeads function with while loop 
            FlipForHeads(62);
        }

        //flip coin until we get certain number of heads
        static void FlipForHeads(int numHeads)
        {
            //counts number of heads flipped
            int headsFlipped = 0;
            //random number generator to "flip" a coin
            Random rng = new Random();
            //count the total flips
            int totalFlips = 0;
            //do a while loop to flip coins until we have reached the desired number of heads
            while (headsFlipped != numHeads)
            {
                //flip a coin, this is the same as saying
                //int flip = rng.Next(0, 2);
                //if (flip == 0)
                if (rng.Next(0, 2) == 0)
                {
                    headsFlipped = headsFlipped + 1;
                }
                //add a flip to our total flip count
                totalFlips = totalFlips + 1;
            }
            //write the output of howmany flips it to to find all the heads
            Console.WriteLine("It took " + totalFlips + " flips to get " + numHeads + " heads.");
        }
    }
}

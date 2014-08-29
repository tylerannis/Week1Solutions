using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a new list of string for a menu
            List<string> myMenu = new List<string>() { "Pizza", "Tacos", "Hummus", "Instant Potatoes" };
          
            //add one more item to the list
            myMenu.Add("Deep fried Twix");
          
            //loop through our menu and print each item
            for (int i = 0; i < myMenu.Count; i++)
            {
                Console.WriteLine(myMenu[i]);
            }
               
         //removing things from a list by name
            myMenu.Remove("Pizza");
            //remove using index number
            myMenu.RemoveAt(1);
            
            //Another Easier way to print out an array or list
           Console.WriteLine(string.Join(", ", myMenu));
            
            //Loop through the List again, to make Twix pop
           for (int i = 0; i < myMenu.Count; i++)
           {
               //set a variable equal to the current item in our list
               string item = myMenu[i];
               //here we took our item and made it lowercase then no matter how item is written, in the string we are searching for using .Contains()
               // we can search for an all lowercase word and it will work, usually .Contains is case sensitive  
               if (item.ToLower().Contains("twix"))
               {
                   Console.WriteLine(item.ToUpper());
               }
               else
               {
                   Console.WriteLine(item);
               }
           }

            //keep the window open
            Console.ReadKey();  

        }
    }
}

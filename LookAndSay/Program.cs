using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LookAndSay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            string userInput = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            char previous = userInput[0];
            userInput = userInput.Substring(1,userInput.Length-1)+" ";
            int count = 1;
            foreach(char digit in userInput)
            {
                if(digit!=previous)
                {
                    result.Append(Convert.ToString(count)+previous);
                    count = 1;
                    previous = digit;
                }
                else
                {
                
                    count++;
                }
            }
            Console.WriteLine("Result: "+result);
            Console.ReadLine();
        }
    }
}
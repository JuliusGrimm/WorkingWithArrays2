using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArrays2
{
    class Program
    {
        static void Main(string[] args)
        {   //Created a random number generater
            Random rnd = new Random();
            //Created an array/list of doubles up to a cap of 10
            double[] nums = new double[10];
            //Created a for loop for the list that increases the list count until it reaches 10
            for (int i=0; i<nums.Length;i++)
            {
                //Here a random decimal number is created
                double num = rnd.NextDouble();
                //It's rounded to 2 decimal places here
                num = Math.Round(num, 2);
                //Here it places the random number into the list/array
                nums[i] = num;
                //This line prints it to the console
                Console.WriteLine(i.ToString() + " " + nums[i]);
            }
            //Closes out the program
            Console.WriteLine("\nPress enter to close program.");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_Number_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0,5);
            int yourNumber;
            while (true)
            {
                Console.Write("Please enter your number: ");
                yourNumber = int.Parse(Console.ReadLine());

                if (randomNumber == yourNumber)
                {
                    Console.WriteLine("Succsessful ! You'r Find Number");
                    Console.WriteLine("Computer Number:{0}",randomNumber);
                    break;
                }
                else
                {
                    Console.WriteLine("upss! you'r Not Find Number ");
                }
            }
        }
    }
}

using System;

namespace GuessMyNumber
{

    public class Program
    {
        public static void Main(string[] args = null)
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 11);
            //Generates the random number

            Console.WriteLine("I'm thinking of a number between 1 and 10.");
            Console.WriteLine("Guess which number I'm thinking of (and hit 'Enter').");

            bool z = int.TryParse(Console.ReadLine(), out int a);
            //^replaced all instances of "int a = Convert.ToInt16(Console.ReadLine());"
            //I realized that finding "int a" this way would break the program if a non-integer is entered

            Test.TestMet(z);
            //test for an integer (true/false), output it as int a

            GuessAgain.TryAgain(a, n);
            //Why couldn't the Test class access n and a? GuessAgain could.
            //And when I try to make them public here, everything else goes to shit
            //Had to re-initialize both in Test

            
        }
    }
}
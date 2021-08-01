using System;

namespace GuessMyNumber
{

    public class Program
    {
        public static void Main(string[] args = null)
        {
            Random rnd = new Random();
            int n = rnd.Next(1, 11);
            //Console.WriteLine(n);

            Console.WriteLine("I'm thinking of a number between 1 and 10.");
            Console.WriteLine("Guess which number I'm thinking of (and hit 'Enter').");

            //Why can't the Test class access n and a?
            //And when I try to make them public here, everything else goes to shit


            //bool z = int.TryParse(Console.ReadLine(), out int a);
            int a = Convert.ToInt16(Console.ReadLine());
            GuessAgain.TryAgain(a, n);
           // Test.TestMet(z);
        }
    }
}
using System;
namespace GuessMyNumber
{
    public class GuessAgain
    {
        static public void TryAgain(int a, int n)
        {
            if (a < n)
            {
                Console.WriteLine("Too low");
                a = Convert.ToInt16(Console.ReadLine());
                TryAgain(a, n);
            }
            else if (a > n)
            {
                Console.WriteLine("Too high");
                a = Convert.ToInt16(Console.ReadLine());
                TryAgain(a, n);
            }
            else if (a == n)
            {
                Console.WriteLine("You are correct!");
                Console.WriteLine("Play again.");
                Console.WriteLine();
                Console.WriteLine();
                Program.Main(null);
            }
            else
            {
                Console.Write("Error");
            }
        }
    }
}

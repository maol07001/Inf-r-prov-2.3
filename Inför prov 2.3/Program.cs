using System;
namespace uppgift_2._3
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar vill du hyra bilen");
            int x = int.Parse(Console.ReadLine());
            int antaldagar = (x * 500) - 500;
            int dagsum = 300 + antaldagar;

            Console.WriteLine("Hur många km ska du köra?");
            int km = int.Parse(Console.ReadLine());
            int kilometer = km * 1;
            int sum = dagsum + kilometer;

            Console.WriteLine("summan är: " + sum + "kronor.");
        }
    }
}
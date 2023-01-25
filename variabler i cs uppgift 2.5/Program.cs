using System;
namespace uppgift5
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vilket år är det");
            int årtal = int.Parse(Console.ReadLine());
            int tvåk = 2100 - årtal;
            if (tvåk > 0)
            {
                Console.WriteLine("det är " + tvåk + " år kvar till 2100");
            }
            else
            {
                Console.WriteLine("2100 har redan passerat");
            }
        }
    }
}
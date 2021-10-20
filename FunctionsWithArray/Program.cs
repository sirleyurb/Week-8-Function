using System;

namespace FunctionsWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "red", "blue", "green" };
            string[] morecolors = { "yellow", "pink", "beige", "purple" };
            PickRandomColors(colors);
            PickRandomColors(morecolors);
        }

        private static void PickRandomColors(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);

            Console.WriteLine(someArray[randomIndex]);
        }
    }
}

using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C50_GSatTue_Basics04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            // Create a one - dimensional array double[] prices with the values 25.5, 40.0, 33.75.Print
            //the second price(index 1).
            double[] price = { 25.5, 40.0, 33.75 };
            Console.WriteLine(price[1]);

            #endregion

            #region Question 2
            //Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
            //shelf 1 has 1, 4 copies.Print the number of copies on shelf 1, slot 0.
            int[,] shelfCopies = {
                {3,5 },
                {1,4 }
            };
            Console.WriteLine(shelfCopies[0,0]);
            Console.WriteLine(shelfCopies[0, 1]);
           
            Console.WriteLine(shelfCopies[1, 0]);
            Console.WriteLine(shelfCopies[1, 1]);

            #endregion


        }
    }
}

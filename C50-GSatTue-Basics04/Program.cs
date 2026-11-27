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
            //int[,] shelfCopies = {
            //    {3,5 },
            //    {1,4 }
            //};
            //Console.WriteLine(shelfCopies[0,0]);
            //Console.WriteLine(shelfCopies[0, 1]);

            //Console.WriteLine(shelfCopies[1, 0]);
            //Console.WriteLine(shelfCopies[1, 1]);

            #endregion

            #region Question 3
            //Write a method called PrintWelcomeMessage that takes no parameters and prints
            //"Welcome to the Library!".Call it from Main.
            PrintWelcomeMessage();
            #endregion

            #region Question 4
            //Write a method PrintBookTitle(string title) that prints "Book title: " + title.Call it with
            //"Clean Code".
          

            PrintBookTitle("Clean Code");

            #endregion


            #region Question 5
            // Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
            //int pages = 400; and print pages afterward. What do you expect to see, and why? 
            int pages = 400;
            Console.WriteLine(pages);   //400
           int x = AddBonusPages(pages);
            Console.WriteLine(pages);    //400

            #endregion

            #region Question 6
            //Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0].Call it
            // with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward.What do you expect to
            //see, and why?


            // Reference type change value 

            double[] prices = { 25.5, 40.0 };


            Console.WriteLine(prices[0]);   //25.5
            double y = ApplyDiscount(prices);
            Console.WriteLine(prices[0]);    //20.5



            #endregion

        }
        public static double ApplyDiscount(double[] prices)
        {
            return prices[0] - 5;
        }
        public static int AddBonusPages(int pages)
        {
            return pages + 50;
        }
        public static void PrintBookTitle(string title)
        {

            Console.WriteLine("Book title: " + title);
        
        }

       public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
    }
}

namespace Fizz_Buzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool text = false;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                    text = true;
                }
                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                    text = true;
                }
                if (!text) 
                {
                    Console.Write(i.ToString());
                }
                text = false;
                Console.WriteLine();
            }

            // další možnost - původní řešení:

            //string cislo;
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        cislo = "FizzBuzz";
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        cislo = "Fizz";
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        cislo = "Buzz";
            //    }
            //    else
            //    {
            //        cislo = i.ToString();
            //    }

            //    Console.WriteLine(cislo);
            //}
        }
    }
}
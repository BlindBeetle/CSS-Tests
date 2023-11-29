using System;

namespace conversionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion
            int num = 1234567;
            long bigNum = num;
            Console.WriteLine(bigNum);

            float myFloat = 13.37f;
            double myNewDouble = myFloat;
            Console.WriteLine(myNewDouble);

            //challenge :)
            string challengeString = myFloat.ToString();
            Console.WriteLine(challengeString);
            // correct answer!

            double myDouble = 13.27;
            int myInt;
            // explicit conversion
            // cast double into int
            myInt = (int)myDouble;

            //type conversion
            string myString = myDouble.ToString();
            //*13.27*


            Console.WriteLine(myInt);
            Console.Read();
        }
    }
}
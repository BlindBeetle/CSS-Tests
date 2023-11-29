namespace Conclusion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "I control text.";
            Console.WriteLine(myString);

            int myInt = 1;
            float myFloat = 3.14349f;
            decimal myDecimal = 3.419083809m;
            Console.WriteLine(myDecimal);
            Console.WriteLine(myInt);
            Console.WriteLine(myFloat);

            string parseNumber = "2";
            Console.WriteLine(Convert.ToInt32(parseNumber));
            Console.Read();
        }
    }
}
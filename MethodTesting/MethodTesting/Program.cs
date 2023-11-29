namespace MethodTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factori(8, 9);
            Console.Read();
        }

        public static void Factori(int number, int number2) 
        {
            int number0 = number;
            number = number2;
            number2 = number0;

            Console.WriteLine(number);
            Console.WriteLine(number2);
        
        }
    }
}
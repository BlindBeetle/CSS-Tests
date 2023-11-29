namespace VariableTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            num1 = 13;

            int num3, num4, num5;

            int num2 = 23;

            int sum = num1 + num2;

            Console.WriteLine(sum);

            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;

            Console.WriteLine(dDiv);

            float f1 = 3.1415F;
            float f2 = 5.1F;
            float fDiv = f1 / f2;
            Console.WriteLine(fDiv);

            Console.Read();
        }
    }
}
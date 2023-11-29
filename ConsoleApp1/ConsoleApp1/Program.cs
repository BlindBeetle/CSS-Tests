namespace ConsoleApp1
{
    internal class Program
    {

        public static void Swap(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine(x);
            Console.WriteLine(y);

        }
        static void Main(string[] args)
        {
            Swap(0, 1);
            Console.Read();
        }
    }
}
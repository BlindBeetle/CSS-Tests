namespace Challenge_1___Methods
{
    internal class Program
    {

        public static string LowUpper(string conv) 
        {
            string conv0 = conv.ToUpper();
            conv = conv.ToLower();
            return conv + conv0;
        }

        static void Main(string[] args)
        {
            string s = "HelLo tHerE!";
            s = LowUpper(s);
            Console.WriteLine(s);
        }
    }
}
namespace StringTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string wizardRed = "Red Wizard: Hello World!";

            string wizardGreen = "Green Wizard: We love casting spells.";
            string wizardGreen1 = wizardGreen.ToUpper();

            string wizardPurple = "Purple Wizard: These lines of code are sponsored by; the shadow goverment!";

            Console.WriteLine(wizardRed);
            Console.WriteLine(wizardGreen1);
            Console.WriteLine(wizardPurple);
            Console.Read();
        }
    }
}
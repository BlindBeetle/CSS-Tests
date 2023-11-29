namespace ifStatememntTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please put in todays temperature in C'.");
            string temp = Console.ReadLine();

            try
            {
                sbyte test = sbyte.Parse(temp);
            }
            catch (OverflowException)
            {
                Console.WriteLine("No way the temperature is {0}", temp);
                Console.ReadKey();
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("Please put in a number next time.");
                Console.ReadKey();
                return;
            } catch (Exception)
            {
                Console.WriteLine("You are really good at following instructions...");
                Console.ReadKey();
                return;
            }

            sbyte tempNumber = sbyte.Parse(temp);

            if (tempNumber < 20) {
                Console.WriteLine("Get your coats ready!");
            } else if (tempNumber < 32)
            {
                Console.WriteLine("Lovely weather we are having!");
            } else if (tempNumber > 32)
            {
                Console.WriteLine("Time for hell :skull:");
            }else
            {
                Console.WriteLine("Temperatur is 20 C'.");
            }

            Console.ReadKey();
        }
    }
}
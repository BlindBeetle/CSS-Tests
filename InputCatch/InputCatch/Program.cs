namespace InputCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please put in a number of your choice.");
            string numberInput = Console.ReadLine();
            try 
            {
                int numberInputreal = int.Parse(numberInput);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please put in a number next time.");
            
            }
            catch (Exception) 
            {
                Console.WriteLine("Please pick a number between -128 and 128 next time.");
            }
            Console.ReadKey();
        }
    }
}
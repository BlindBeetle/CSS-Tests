namespace GeneralTesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float myFloat = float.Parse(stringForFloat);
            int myInt = int.Parse(stringForInt);

            string name = "Bora";
            string age = "20";

            //String Concatenation
            Console.WriteLine("My brothers name is " + name + " and he is " + age + " years old.");

            //String Formatting
            Console.WriteLine("{0} is my brother and {1} years old", name, age);

            //String Interpolaton $$$
            Console.WriteLine($"{name} is my brother and {age} years old.",name,age);

            //There is also one like Console.WriteLine(@"....."); that includes the spaces in between lines.
            //if you put \n it puts the remaining text into a new line. (This isnt possible with the @"....." I just showed.)

            Console.Read();
        }
    }
}
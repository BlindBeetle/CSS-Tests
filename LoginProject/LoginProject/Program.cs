namespace LoginProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string loginName = "poyraz";
            string loginPassword = "password";

            Console.WriteLine("Please enter your username.");
            string inputName0 = Console.ReadLine();
            string inputName = inputName0.ToLower();

            Console.WriteLine("Please enter your password");
            string inputPassword = Console.ReadLine();

            if (loginName == inputName & loginPassword == inputPassword)
            {
                Console.WriteLine("Welcome back {0}",inputName0);
                Console.Read();
                return;
            }
            else
            {
                Console.WriteLine("Username or password incorrect. :( ");
                Console.Read();
                return;
            }
        }
    }
}
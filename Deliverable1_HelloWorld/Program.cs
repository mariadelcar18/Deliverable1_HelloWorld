namespace Deliverable1_HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solution (1): Hello, World!");
            Console.WriteLine(" ");

            // Specifying and assigning stg variables
            string stg = "Hello, World!";
            
            // Writing line 
            Console.WriteLine("Solution (2): " + stg);
            Console.WriteLine(" ");

            // Request user input
            Console.WriteLine("Please enter a user's name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("The user's name is: " + userName);
            Console.WriteLine(" ");

            // Request a numeric data 
            Console.WriteLine("Please enter the user's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("The user's age is: " + age);
        }
    }
}
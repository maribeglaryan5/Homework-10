namespace Task_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 is Rock, 2 is Paper, 3 is scissors
            int computerChoice = new Random().Next(1,3);

            Console.WriteLine("Choose one option: Rock, Paper, Scissors (1,2,3): ");

            int userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                if (computerChoice == 2)
                {
                    Console.WriteLine("Computer won");
                }
                else if(computerChoice == 3)
                {
                    Console.WriteLine("User won");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }
            }
            else if(userChoice == 2)
            {
                if (computerChoice == 2)
                {
                    Console.WriteLine("Draw!");
                }
                else if (computerChoice == 3)
                {
                    Console.WriteLine("Computer won");
                }
                else
                {
                    Console.WriteLine("User won");
                }
            }
            else
            {
                if (computerChoice == 2)
                {
                    Console.WriteLine("User won");
                }
                else if (computerChoice == 3)
                {
                    Console.WriteLine("Draw!");
                }
                else
                {
                    Console.WriteLine("Computer won");
                }
            }
        }
    }
}

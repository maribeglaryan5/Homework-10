namespace Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(0, 100);


            Console.WriteLine("Guess the number");
            
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if(number > randomNumber)
                {
                    Console.WriteLine("Your guess is high");
                }
                else if(number == randomNumber)
                {
                    Console.WriteLine("You've guessed right");
                    break;
                }
                else
                {
                    Console.WriteLine("Your guess is too low");
                }
            }
        }
    }
}

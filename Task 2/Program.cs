namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            string userText = Console.ReadLine();
            char userChar = Char.Parse(Console.ReadLine());

            int occurrences = 0;
            for (int i = 0; i < userText.Length; i++)
            {
                if(userChar == userText[i])
                {
                    occurrences++;
                }
            }

            Console.WriteLine($"char appearted {occurrences} times");
        }
    }
}

namespace Task_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputInt = Console.ReadLine();

            int wordSum = 1;

            if (!string.IsNullOrEmpty(inputInt))
            {
                for (int i = 0; i < inputInt.Length; i++)
                {
                    if (inputInt[i] == ' ')
                    {
                        wordSum++;
                    }
                }

                Console.WriteLine($"Number of words: " + wordSum);
            }
        }
    }
}

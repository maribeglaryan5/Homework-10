namespace Task_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                var res = random.Next(0, 100);
                Console.WriteLine(res);
            }
        }
    }
}

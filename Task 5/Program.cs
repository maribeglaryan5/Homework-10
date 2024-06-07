namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startInt = int.Parse(Console.ReadLine());
            int endInt = int.Parse(Console.ReadLine());

            for (int i = startInt; i < endInt; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

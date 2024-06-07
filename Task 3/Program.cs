namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[50];
            for (int i = 0; i < 50; i++)
            {
                int a = int.Parse(Console.ReadLine());
                number[i] = a;
            }

            double average = number.Sum() / 50;

            Console.WriteLine($"Largest number is {average}");
        }
    }
}

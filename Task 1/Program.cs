namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[10];
            for (int i = 0; i < 10; i++)
            {
                int a = int.Parse(Console.ReadLine());
                number[i] = a;
            }

            int largestNumber = number.Max();

            Console.WriteLine($"Largest number is {largestNumber}");
        }  
    }
}

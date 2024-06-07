using System.ComponentModel;
using System.Runtime.Intrinsics.X86;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            string reversedName = "";

            for (int i = 0; i < userInput.Length; i++)
            {
                char lastElement = userInput[userInput.Length - (i + 1)];
                reversedName += lastElement;
            }

            if (reversedName.Equals(userInput))
            {
                Console.WriteLine("It's polidrom");
            }
            else
            {
                Console.WriteLine("It's not polidrom");
            }
        }
    }
}

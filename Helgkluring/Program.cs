using System;

namespace Helgkluring
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                StartProgram();
            }
        }

        private static void StartProgram()
        {
            int input = InputFromUser();
            int answer = NumDigits(input);
            DisplayResult(input, answer);
        }

        private static int InputFromUser()
        {
            Console.Write("Ange ett tal: ");
            int answer = int.Parse(Console.ReadLine());
            return answer;
        }

        private static int NumDigits(int input)
        {
            int digits = input == 0 ? 1 : (int)Math.Floor(Math.Log10(Math.Abs(input)) + 1);
            return digits;
        }

        private static void DisplayResult(int input, int answer)
        {
            Console.WriteLine($"Ditt tal ({input}) innehåller {answer} siffror.");
        }
    }
}
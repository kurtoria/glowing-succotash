using System;

namespace Calculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Start();

        }

        private static Calculator calculator = new Calculator();

        public static void Start() 
        {
            int Number = 0; do
            {
                Console.WriteLine("What do u want to do?");
                Console.WriteLine("1. Add two numbers");
                Console.WriteLine("2. Multiply two numbers");
                Console.WriteLine("3. Sum the number between two numbers");
                Console.WriteLine("4. Add number to memory");
                Console.WriteLine("5. Clear memory");
                Console.WriteLine("6. Print calculator contents");
                Console.WriteLine("7. Quit");
                Number = int.Parse(Console.ReadLine());
                SwitchCase(Number);
            } while (Number != 7);
        }
            

        private static void SwitchCase(int nr)
        {
            switch (nr)
            {
                case 1:
                    EnterNumbers();
                    Console.WriteLine(calculator.SumNumbers());
                    break;
                case 2:
                    EnterNumbers();
                    Console.WriteLine(calculator.MultiplyNumbers());
                    break;
                case 3:
                    EnterNumbers();
                    Console.WriteLine(calculator.SumInBetween());
                    break;
                case 4:
                    EnterNumber();
                    break;
                case 5:
                    calculator.ClearMemory();
                    checkMemoryClear();
                    break;
                case 6:
                    Console.WriteLine(calculator.ToString());
                    break;
                case 7:
                    Console.WriteLine("Later!");
                    break;
                default:
                    break;
            }
        }

        private static void EnterNumbers()
        {
            Console.WriteLine("Type in first number:");
            calculator.FirstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Type in second number:");
            calculator.SecondNumber = int.Parse(Console.ReadLine());
        }

        private static void EnterNumber()
        {
            Console.WriteLine("Type in number u would like to save:");
            calculator.NumberInMemory = int.Parse(Console.ReadLine());
            Console.WriteLine("The number {0} successfully saved to memory", calculator.NumberInMemory);
        }

        private static void checkMemoryClear()
        {
            if (calculator.NumberInMemory == 0.0)
            {
                Console.WriteLine("Memory is cleared!");
            }
            else
            {
                Console.WriteLine("Oops, something went wrong, try again");
            }
        }
            
    }
}

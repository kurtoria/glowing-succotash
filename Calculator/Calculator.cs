using System;
namespace Calculator
{
    public class Calculator
    {
        public double FirstNumber { get; set; }
        public double SecondNumber { get; set; }
        public double NumberInMemory { get; set; }

        public Calculator()
        {
            FirstNumber = 0.0;
            SecondNumber = 0.0;
            NumberInMemory = 0.0;
        }

        public override string ToString()
        {
            return String.Format("First number: {0}, second number: {1}, number in memory: {2}", FirstNumber, SecondNumber, NumberInMemory);
        }

        public double SumNumbers() 
        {
            return FirstNumber + SecondNumber;
        }

        public double MultiplyNumbers()
        {
            return FirstNumber * SecondNumber;
        }

        public double SumInBetween()
        {

            double totalSum = 0.0;
            for (double i = FirstNumber; i <= SecondNumber; i++)
            {
                totalSum = totalSum + i;
            }
            return totalSum;
        }

        public void ClearMemory() 
        {
            NumberInMemory = 0.0;
        }
    }
}

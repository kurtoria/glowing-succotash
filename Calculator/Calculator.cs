﻿using System;
namespace Calculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public int NumberInMemory { get; set; }

        public Calculator()
        {
            FirstNumber = 0;
            SecondNumber = 0;
            NumberInMemory = 0;
        }

        public override string ToString()
        {
            return String.Format("First number: {0}, second number: {1}, number in memory: {2}", FirstNumber, SecondNumber, NumberInMemory);
        }
    }
}

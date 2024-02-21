using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class CalculatorClass
    {
        // Private Fields:
        private decimal currentValue, operand1, operand2;
        private string op;

        // Public Properties:
        public decimal Operand1
        {
            get { return operand1; }
            set { operand1 = value; }
        }

        public decimal Operand2
        {
            get { return operand2; }
            set { operand2 = value; }
        }

        public decimal CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; }
        }

        // Creates a Calculator object with default values
        // The default value for the op field is null
        // Default Constructor:
        public CalculatorClass()
        {
            op = null;
        }

        // Methods:
        public void Add(decimal displayValue)
        {
            CurrentValue = displayValue;
            operand1 = CurrentValue;
            op = "+";
        }

        public void Subtract(decimal displayValue)
        {
            CurrentValue = displayValue;
            operand1 = CurrentValue;
            op = "-";
        }

        public void Multiply(decimal displayValue)
        {
            CurrentValue = displayValue;
            operand1 = CurrentValue;
            op = "*";
        }

        public void Divide(decimal displayValue)
        {
            CurrentValue = displayValue;
            operand1 = CurrentValue;
            op = "/";
        }

        public void EqualsOp(decimal displayValue)
        {
            Operand2 = displayValue;

            switch (op)
            {
                case "+":
                    CurrentValue = Operand1 + Operand2;
                break;

                case "-":
                    CurrentValue = Operand1 - Operand2;
                break;

                case "*":
                    CurrentValue = Operand1 * Operand2;
                break;

                case "/":
                    CurrentValue = Operand1 / Operand2;
                break;

                default:
                break;
            }
        }

        public void Clear()
        {
            Operand1 = 0;
            Operand2 = 0;
            CurrentValue = 0;
            op = null;
        }
    }
}

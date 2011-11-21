using System.Collections.Generic;

namespace Calculator
{

    /// <summary>
    ///     Represents a simple calculator with a storage engine for remembering values
    /// </summary>
    public class Calculator
    {
        private double _result = 0;
        private Dictionary<string, double> storage = new Dictionary<string, double>();

        public void Update(Operation opr, double val)
        {
        }

        public double Result
        {
            get { return _result; }
        }

        public void Clear()
        {
            _result = 0;
        }

        public double Recall(string index)
        {
            return storage[index];
        }

        public void Store(string index, double val)
        {
            storage[index] = val;
        }

        private void Add(double val)
        {
            _result += val;
        }

        private void Subtract(double val)
        {
            _result -= val;
        }

        private void Multiply(double val)
        {
            _result *= val;
        }

        private void Divide(double val)
        {
            _result = _result / val;
        }
    }

    public enum Operation
    {
        Addition, Subtraction, Multiplication, Division
    }
}

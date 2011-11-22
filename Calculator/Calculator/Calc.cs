using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Calculator
{

    /// <summary>
    ///     Represents a simple calculator with a storage engine for remembering values
    /// </summary>
    public class Calc
    {
        private double _result;
        private Dictionary<string, double> storage = new Dictionary<string, double>();

        public Calc()
        {
            Clear();
        }

        [Pure]
        public double Result
        {
            get { return _result; }
        }

        public void Clear()
        {
            _result = 0;
        }

        [Pure]
        public double Recall(string index)
        {
            Contract.Requires(index != null);
            return storage.ContainsKey(index) ? storage[index] : 0.0;
        }

        public void Store(string index, double val)
        {
            Contract.Requires(index != null);
            storage[index] = val;
        }

        public void Add(double val)
        {
            _result += val;
        }

        public void Subtract(double val)
        {
            _result -= val;
        }

        public void Multiply(double val)
        {
            _result *= val;
        }

        public void Divide(double val)
        {
            Contract.Requires(Math.Abs(val - 0) > EPSILON);
            _result = _result / val;
        }
    }
}

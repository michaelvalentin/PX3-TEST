// <copyright file="CalcTest.cs">Copyright ©  2011</copyright>

using System;
using Calculator;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator
{
    [TestClass]
    [PexClass(typeof(Calc))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class CalcTest
    {
        [PexMethod]
        public void Subtract([PexAssumeUnderTest]Calc target, double val)
        {
            target.Subtract(val);
            // TODO: add assertions to method CalcTest.Subtract(Calc, Double)
        }
        [PexMethod]
        public void Store(
            [PexAssumeUnderTest]Calc target,
            string index,
            double val
        )
        {
            target.Store(index, val);
            // TODO: add assertions to method CalcTest.Store(Calc, String, Double)
        }
        [PexMethod]
        public double ResultGet([PexAssumeUnderTest]Calc target)
        {
            double result = target.Result;
            return result;
            // TODO: add assertions to method CalcTest.ResultGet(Calc)
        }
        [PexMethod]
        public double Recall([PexAssumeUnderTest]Calc target, string index)
        {
            double result = target.Recall(index);
            return result;
            // TODO: add assertions to method CalcTest.Recall(Calc, String)
        }
        [PexMethod]
        public void Multiply([PexAssumeUnderTest]Calc target, double val)
        {
            target.Multiply(val);
            // TODO: add assertions to method CalcTest.Multiply(Calc, Double)
        }
        [PexMethod]
        public void Divide([PexAssumeUnderTest]Calc target, double val)
        {
            target.Divide(val);
            // TODO: add assertions to method CalcTest.Divide(Calc, Double)
        }
        [PexMethod]
        public Calc Constructor()
        {
            Calc target = new Calc();
            return target;
            // TODO: add assertions to method CalcTest.Constructor()
        }
        [PexMethod]
        public void Clear([PexAssumeUnderTest]Calc target)
        {
            target.Clear();
            // TODO: add assertions to method CalcTest.Clear(Calc)
        }
        [PexMethod]
        public void Add([PexAssumeUnderTest]Calc target, double val)
        {
            target.Add(val);
            // TODO: add assertions to method CalcTest.Add(Calc, Double)
        }
    }
}

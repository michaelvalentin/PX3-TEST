// <copyright file="CalcTest.Constructor.g.cs">Copyright �  2011</copyright>
// <auto-generated>
// This file contains automatically generated unit tests.
// Do NOT modify this file manually.
// 
// When Pex is invoked again,
// it might remove or update any previously generated unit tests.
// 
// If the contents of this file becomes outdated, e.g. if it does not
// compile anymore, you may delete this file and invoke Pex again.
// </auto-generated>
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Pex.Framework.Generated;

namespace Calculator
{
    public partial class CalcTest
    {
[TestMethod]
[PexGeneratedBy(typeof(CalcTest))]
public void Constructor315()
{
    Calc calc;
    calc = this.Constructor();
    Assert.IsNotNull((object)calc);
    Assert.AreEqual<double>(0, calc.Result);
}
    }
}

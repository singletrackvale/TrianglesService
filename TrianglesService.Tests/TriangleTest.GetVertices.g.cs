using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrianglesService.Models;
// <copyright file="TriangleTest.GetVertices.g.cs">Copyright ©  2017</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace TrianglesService.Models.Tests
{
    public partial class TriangleTest
    {

[TestMethod]
[PexGeneratedBy(typeof(TriangleTest))]
public void GetVertices217()
{
    bool b;
    Triangle s0 = new Triangle();
    s0.V1x = 0;
    s0.V1y = 0;
    s0.V2x = 0;
    s0.V2y = 0;
    s0.V3x = 0;
    s0.V3y = 0;
    s0.Column = 0;
    s0.Row = (string)null;
    b = this.GetVertices(s0, (string)null, 0);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
    Assert.AreEqual<int>(0, s0.V1x);
    Assert.AreEqual<int>(0, s0.V1y);
    Assert.AreEqual<int>(0, s0.V2x);
    Assert.AreEqual<int>(0, s0.V2y);
    Assert.AreEqual<int>(0, s0.V3x);
    Assert.AreEqual<int>(0, s0.V3y);
    Assert.AreEqual<int>(0, s0.Column);
    Assert.AreEqual<string>((string)null, s0.Row);
}

[TestMethod]
[PexGeneratedBy(typeof(TriangleTest))]
public void GetVertices645()
{
    bool b;
    Triangle s0 = new Triangle();
    s0.V1x = 0;
    s0.V1y = 0;
    s0.V2x = 0;
    s0.V2y = 0;
    s0.V3x = 0;
    s0.V3y = 0;
    s0.Column = 0;
    s0.Row = (string)null;
    b = this.GetVertices(s0, "\0", 0);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
    Assert.AreEqual<int>(0, s0.V1x);
    Assert.AreEqual<int>(0, s0.V1y);
    Assert.AreEqual<int>(0, s0.V2x);
    Assert.AreEqual<int>(0, s0.V2y);
    Assert.AreEqual<int>(0, s0.V3x);
    Assert.AreEqual<int>(0, s0.V3y);
    Assert.AreEqual<int>(0, s0.Column);
    Assert.AreEqual<string>((string)null, s0.Row);
}

[TestMethod]
[PexGeneratedBy(typeof(TriangleTest))]
public void GetVertices727()
{
    bool b;
    Triangle s0 = new Triangle();
    s0.V1x = 0;
    s0.V1y = 0;
    s0.V2x = 0;
    s0.V2y = 0;
    s0.V3x = 0;
    s0.V3y = 0;
    s0.Column = 0;
    s0.Row = (string)null;
    b = this.GetVertices(s0, "A", 0);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
    Assert.AreEqual<int>(0, s0.V1x);
    Assert.AreEqual<int>(0, s0.V1y);
    Assert.AreEqual<int>(0, s0.V2x);
    Assert.AreEqual<int>(0, s0.V2y);
    Assert.AreEqual<int>(0, s0.V3x);
    Assert.AreEqual<int>(0, s0.V3y);
    Assert.AreEqual<int>(0, s0.Column);
    Assert.AreEqual<string>((string)null, s0.Row);
}

[TestMethod]
[PexGeneratedBy(typeof(TriangleTest))]
public void GetVertices716()
{
    bool b;
    Triangle s0 = new Triangle();
    s0.V1x = 0;
    s0.V1y = 0;
    s0.V2x = 0;
    s0.V2y = 0;
    s0.V3x = 0;
    s0.V3y = 0;
    s0.Column = 0;
    s0.Row = (string)null;
    b = this.GetVertices(s0, "A", 1);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)s0);
    Assert.AreEqual<int>(0, s0.V1x);
    Assert.AreEqual<int>(10, s0.V1y);
    Assert.AreEqual<int>(0, s0.V2x);
    Assert.AreEqual<int>(0, s0.V2y);
    Assert.AreEqual<int>(10, s0.V3x);
    Assert.AreEqual<int>(10, s0.V3y);
    Assert.AreEqual<int>(1, s0.Column);
    Assert.AreEqual<string>("A", s0.Row);
}

[TestMethod]
[PexGeneratedBy(typeof(TriangleTest))]
public void GetVertices418()
{
    bool b;
    Triangle s0 = new Triangle();
    s0.V1x = 0;
    s0.V1y = 0;
    s0.V2x = 0;
    s0.V2y = 0;
    s0.V3x = 0;
    s0.V3y = 0;
    s0.Column = 0;
    s0.Row = (string)null;
    b = this.GetVertices(s0, "G", 0);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
    Assert.AreEqual<int>(0, s0.V1x);
    Assert.AreEqual<int>(0, s0.V1y);
    Assert.AreEqual<int>(0, s0.V2x);
    Assert.AreEqual<int>(0, s0.V2y);
    Assert.AreEqual<int>(0, s0.V3x);
    Assert.AreEqual<int>(0, s0.V3y);
    Assert.AreEqual<int>(0, s0.Column);
    Assert.AreEqual<string>((string)null, s0.Row);
}

[TestMethod]
[PexGeneratedBy(typeof(TriangleTest))]
public void GetVertices536()
{
    bool b;
    Triangle s0 = new Triangle();
    s0.V1x = 0;
    s0.V1y = 0;
    s0.V2x = 0;
    s0.V2y = 0;
    s0.V3x = 0;
    s0.V3y = 0;
    s0.Column = 0;
    s0.Row = (string)null;
    b = this.GetVertices(s0, "A", 10);
    Assert.AreEqual<bool>(true, b);
    Assert.IsNotNull((object)s0);
    Assert.AreEqual<int>(50, s0.V1x);
    Assert.AreEqual<int>(0, s0.V1y);
    Assert.AreEqual<int>(50, s0.V2x);
    Assert.AreEqual<int>(10, s0.V2y);
    Assert.AreEqual<int>(40, s0.V3x);
    Assert.AreEqual<int>(0, s0.V3y);
    Assert.AreEqual<int>(10, s0.Column);
    Assert.AreEqual<string>("A", s0.Row);
}

[TestMethod]
[PexGeneratedBy(typeof(TriangleTest))]
public void GetVertices200()
{
    bool b;
    Triangle s0 = new Triangle();
    s0.V1x = 0;
    s0.V1y = 0;
    s0.V2x = 0;
    s0.V2y = 0;
    s0.V3x = 0;
    s0.V3y = 0;
    s0.Column = 0;
    s0.Row = (string)null;
    b = this.GetVertices(s0, "A", 13);
    Assert.AreEqual<bool>(false, b);
    Assert.IsNotNull((object)s0);
    Assert.AreEqual<int>(0, s0.V1x);
    Assert.AreEqual<int>(0, s0.V1y);
    Assert.AreEqual<int>(0, s0.V2x);
    Assert.AreEqual<int>(0, s0.V2y);
    Assert.AreEqual<int>(0, s0.V3x);
    Assert.AreEqual<int>(0, s0.V3y);
    Assert.AreEqual<int>(0, s0.Column);
    Assert.AreEqual<string>((string)null, s0.Row);
}
    }
}

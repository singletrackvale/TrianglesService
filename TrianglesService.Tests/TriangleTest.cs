// <copyright file="TriangleTest.cs">Copyright ©  2017</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrianglesService.Models;

namespace TrianglesService.Models.Tests
{
    [TestClass]
    [PexClass(typeof(Triangle))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TriangleTest
    {

        [PexMethod]
        public bool GetVertices(
            [PexAssumeUnderTest]Triangle target,
            string row,
            int col
        )
        {
            bool result = target.GetVertices(row, col);
            return result;
            // TODO: add assertions to method TriangleTest.GetVertices(Triangle, String, Int32)
        }

        [PexMethod]
        public bool GetRowColumn(
            [PexAssumeUnderTest]Triangle target,
            int v1x,
            int v1y,
            int v2x,
            int v2y,
            int v3x,
            int v3y
        )
        {
            bool result = target.GetRowColumn(v1x, v1y, v2x, v2y, v3x, v3y);
            return result;
            // TODO: add assertions to method TriangleTest.GetRowColumn(Triangle, Int32, Int32, Int32, Int32, Int32, Int32)
        }
    }
}

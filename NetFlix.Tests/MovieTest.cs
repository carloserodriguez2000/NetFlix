using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetFlix;

namespace NetFlix.Tests
{
    /// <summary>This class contains parameterized unit tests for Movie</summary>
    [TestClass]
    [PexClass(typeof(Movie))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class MovieTest
    {

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        public string ToStringTest([PexAssumeUnderTest]Movie target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method MovieTest.ToStringTest(Movie)
        }
    }
}

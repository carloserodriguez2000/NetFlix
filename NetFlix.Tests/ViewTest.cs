using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetFlix;

namespace NetFlix.Tests
{
    /// <summary>This class contains parameterized unit tests for View</summary>
    [TestClass]
    [PexClass(typeof(View))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ViewTest
    {

        /// <summary>Test stub for Display(Genre)</summary>
        [PexMethod]
        internal void DisplayTest([PexAssumeUnderTest]View target, Genre aGenre)
        {
            target.Display(aGenre);
            // TODO: add assertions to method ViewTest.DisplayTest(View, Genre)
        }
    }
}

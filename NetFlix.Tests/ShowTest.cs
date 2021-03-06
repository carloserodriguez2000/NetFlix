using System.Collections.Generic;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetFlix;

namespace NetFlix.Tests
{
    /// <summary>This class contains parameterized unit tests for Show</summary>
    [TestClass]
    [PexClass(typeof(Show))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ShowTest
    {

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public Show ConstructorTest()
        {
            Show target = new Show();
            return target;
            // TODO: add assertions to method ShowTest.ConstructorTest()
        }

        /// <summary>Test stub for ToString()</summary>
        [PexMethod]
        public string ToStringTest([PexAssumeUnderTest]Show target)
        {
            string result = target.ToString();
            return result;
            // TODO: add assertions to method ShowTest.ToStringTest(Show)
        }

        /// <summary>Test stub for get_Episodes()</summary>
        [PexMethod]
        public List<Episode> EpisodesGetTest([PexAssumeUnderTest]Show target)
        {
            List<Episode> result = target.Episodes;
            return result;
            // TODO: add assertions to method ShowTest.EpisodesGetTest(Show)
        }

        /// <summary>Test stub for get_Rating()</summary>
        [PexMethod]
        public int RatingGetTest([PexAssumeUnderTest]Show target)
        {
            int result = target.Rating;
            return result;
            // TODO: add assertions to method ShowTest.RatingGetTest(Show)
        }
    }
}

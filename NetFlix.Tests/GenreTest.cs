using System.Collections.Generic;
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetFlix;

namespace NetFlix.Tests
{
    /// <summary>This class contains parameterized unit tests for Genre</summary>
    [TestClass]
    [PexClass(typeof(Genre))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GenreTest
    {
        [TestMethod]
        //public void test()
        //{
        //    Assert.IsTrue(true);
        //}

        /// <summary>Test stub for .ctor(String)</summary>
        [PexMethod]
        public Genre ConstructorTest(string Name)
        {
            Genre target = new Genre(Name);
            return target;
            // TODO: add assertions to method GenreTest.ConstructorTest(String)
        }

        /// <summary>Test stub for GetEnumerator()</summary>
        [PexMethod]
        public IEnumerator<Title> GetEnumeratorTest([PexAssumeUnderTest]Genre target)
        {
            IEnumerator<Title> result = target.GetEnumerator();
            return result;
            // TODO: add assertions to method GenreTest.GetEnumeratorTest(Genre)
        }

        /// <summary>Test stub for get_Titles()</summary>
        [PexMethod]
        public List<Title> TitlesGetTest([PexAssumeUnderTest]Genre target)
        {
            List<Title> result = target.Titles;
            return result;
            // TODO: add assertions to method GenreTest.TitlesGetTest(Genre)
        }

        /// <summary>Test stub for op_Addition(Genre, Genre)</summary>
        [PexMethod]
        public Genre op_AdditionTest(Genre g1, Genre g2)
        {
            Genre result = g1 + g2;
            return result;
            // TODO: add assertions to method GenreTest.op_AdditionTest(Genre, Genre)
        }

        /// <summary>Test stub for op_Addition(Genre, Title)</summary>
        [PexMethod]
        public Genre op_AdditionTest01(Genre g1, Title t1)
        {
            Genre result = g1 + t1;
            return result;
            // TODO: add assertions to method GenreTest.op_AdditionTest01(Genre, Title)
        }
    }
}

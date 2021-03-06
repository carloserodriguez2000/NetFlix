// <copyright file="TitleTest.cs">Copyright ©  2016</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetFlix;

namespace NetFlix.Tests
{
    /// <summary>This class contains parameterized unit tests for Title</summary>
    [PexClass(typeof(Title))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class TitleTest
    {
        /// <summary>Test stub for .ctor(String, Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public Title ConstructorTest(string Name, int? Rating)
        {
            Title target = new Title(Name, Rating);
            return target;
            // TODO: add assertions to method TitleTest.ConstructorTest(String, Nullable`1<Int32>)
        }

        /// <summary>Test stub for .ctor()</summary>
        [PexMethod]
        public Title ConstructorTest01()
        {
            Title target = new Title();
            return target;
            // TODO: add assertions to method TitleTest.ConstructorTest01()
        }

        /// <summary>Test stub for get_Rating()</summary>
        [PexMethod]
        public int? RatingGetTest([PexAssumeUnderTest]Title target)
        {
            int? result = target.Rating;
            return result;
            // TODO: add assertions to method TitleTest.RatingGetTest(Title)
        }

        /// <summary>Test stub for set_Rating(Nullable`1&lt;Int32&gt;)</summary>
        [PexMethod]
        public void RatingSetTest([PexAssumeUnderTest]Title target, int? value)
        {
            target.Rating = value;
            // TODO: add assertions to method TitleTest.RatingSetTest(Title, Nullable`1<Int32>)
        }

        /// <summary>Test stub for op_Addition(Title, Title)</summary>
        [PexMethod]
        public Genre op_AdditionTest(Title t1, Title t2)
        {
            Genre result = t1 + t2;
            return result;
            // TODO: add assertions to method TitleTest.op_AdditionTest(Title, Title)
        }
    }
}

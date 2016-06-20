using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetFlix;
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace NetFlix.Tests
{
    public partial class ViewTest
    {

[TestMethod]
[PexGeneratedBy(typeof(ViewTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void DisplayTestThrowsNullReferenceException734()
{
    View s0 = new View();
    this.DisplayTest(s0, (Genre)null);
}

[TestMethod]
[PexGeneratedBy(typeof(ViewTest))]
public void DisplayTest564()
{
    Genre genre;
    genre = GenreFactory.Create((string)null);
    View s0 = new View();
    this.DisplayTest(s0, genre);
    Assert.IsNotNull((object)s0);
}

[TestMethod]
[PexGeneratedBy(typeof(ViewTest))]
public void DisplayTest515()
{
    Genre genre;
    genre = GenreFactory.Create("");
    View s0 = new View();
    this.DisplayTest(s0, genre);
    Assert.IsNotNull((object)s0);
}
    }
}

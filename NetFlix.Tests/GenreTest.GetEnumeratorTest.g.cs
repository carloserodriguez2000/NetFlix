using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using NetFlix;
using Microsoft.Pex.Framework.Generated;
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
    public partial class GenreTest
    {

[TestMethod]
[PexGeneratedBy(typeof(GenreTest))]
public void GetEnumeratorTest79701()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      Genre genre;
      IEnumerator<Title> iEnumerator;
      genre = GenreFactory.Create((string)null);
      iEnumerator = this.GetEnumeratorTest(genre);
      disposables.Add((IDisposable)iEnumerator);
      disposables.Dispose();
      Assert.IsNotNull((object)iEnumerator);
      Assert.IsNotNull((object)genre);
      Assert.AreEqual<string>((string)null, genre.Name);
      Assert.IsNotNull(genre.Titles);
      Assert.AreEqual<int>(0, genre.Titles.Capacity);
      Assert.AreEqual<int>(0, genre.Titles.Count);
    }
}
    }
}

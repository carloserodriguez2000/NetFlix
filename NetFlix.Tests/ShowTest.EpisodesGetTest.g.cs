using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
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
    public partial class ShowTest
    {

[TestMethod]
[PexGeneratedBy(typeof(ShowTest))]
public void EpisodesGetTest846()
{
    Show show;
    List<Episode> list;
    show = new Show();
    list = this.EpisodesGetTest(show);
    Assert.IsNotNull((object)list);
    Assert.AreEqual<int>(0, list.Capacity);
    Assert.AreEqual<int>(0, list.Count);
    Assert.IsNotNull((object)show);
    Assert.IsNotNull(show.Episodes);
    Assert.IsTrue(object.ReferenceEquals(show.Episodes, (object)list));
    Assert.AreEqual<string>((string)null, ((Title)show).Name);
    Assert.IsNull((object)(((Title)show).Rating));
}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConfMSProject.domain;
using NUnit.Framework;

namespace ConfMSTest.domain
{
    public class AppStringEqualityTest
    {
        [Test]
        public void ShouldReturnTrueIfAppStringsAreEqual()
        {
            var appString1 = new AppString("John");
            var appString2 = new AppString("John");

            Assert.True(appString1.Equals(appString2));
        }

        [Test]
        public void ShouldReturnFalseIfAppStringsAreNotEqual()
        {
            var appString1 = new AppString("John");
            var appString2 = new AppString("John1");

            Assert.False(appString1.Equals(appString2));
        }
    }
}

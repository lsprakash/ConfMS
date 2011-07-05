using System;
using ConfMSProject.domain;
using NUnit.Framework;

namespace ConfMSTest.domain
{
    [TestFixture]
    class ConferenceTest
    {
        [Test]
        public void ShouldCreateAConferenceObject()
        {
            string title = "RubyConf";
            DateTime startTime = new DateTime(2011, 7, 5, 9, 0, 0);
            Duration duration = new Duration(8);
            Conference conference = new Conference(title, startTime, duration);

            Assert.AreEqual(title, conference.Title);
            Assert.AreEqual(startTime, conference.StartTime);
            Assert.AreEqual(duration.Hours, conference.Duration.Hours);
        }
    }
}
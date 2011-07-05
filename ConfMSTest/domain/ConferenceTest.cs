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
            int durationInHours = 8; //TODO: replace primitive with Duration class.
            Conference conference = new Conference(title, startTime, durationInHours);

            Assert.AreEqual(title, conference.Title);
            Assert.AreEqual(startTime, conference.StartTime);
            Assert.AreEqual(durationInHours, conference.Duration);
        }
    }
}
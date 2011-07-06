using System;
using ConfMSProject.domain;
using ConfMSProject.repository;
using NUnit.Framework;

namespace ConfMSTest.repository
{
    [TestFixture]
    class ConferenceRepositoryTest 
    {
        [Test]
        public void ShouldCreateANewConferenceObject()
        {
            var javaConference = "Java Conference";
            var startTime = new DateTime(2011, 7, 6, 10, 0, 0);
            var duration = new Duration(8);

            Conference conference = new Conference(javaConference, startTime, duration);

            var conferenceRepository = new ConferenceRepository();
            conferenceRepository.Save(conference);

        }
    }
}
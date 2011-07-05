using System;
using System.IO;
using System.Linq;
using System.Text;
using ConfMSProject.domain;
using ConfMSProject.repository;
using NUnit.Framework;

namespace ConfMSTest.repository
{
    [TestFixture]
    class SessionRepositoryTest : NHibernateInMemoryTestFixtureBase
    {

        [Test]
        public void ShouldSaveConfSessionToDB()
        {
            var confSession = new ConfSession("Test Session");
            confSession.Description = "Some long description.. little long only";

            var repository = new ConfSessionRepository();
            repository.Save(confSession);

            var sessions = repository.FindByTitle("Test");
            var returnedSession = sessions[0];
            Assert.AreEqual(returnedSession, confSession);

            var sessions2 = repository.FindByTitle("ghhg");
            Assert.True(sessions2.Count==0);

        }

    }
}

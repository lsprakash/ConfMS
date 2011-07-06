using System;
using System.IO;
using ConfMSProject.domain;
using ConfMSProject.repository;
using ConfMSTest.repository;
using NUnit.Framework;

namespace ConfMSTest.domain
{
    [TestFixture]
    class SessionRepositoryTest : RepositoryTest //TODO: Change class name to ConfSessionRepositoryTest
    {
        public SessionRepositoryTest()
        {
        }

        [Test]
        public void ShouldSaveConfSessionToDB()
        {
            var confSession = new ConfSession("Test Session");
            confSession.Description = "Some long description.. little long only";

            var repository = new ConfSessionRepository(session);
            repository.Save(confSession);
            
            var sessions = repository.FindByTitle("Test");
            var returnedSession = sessions[0];
            Assert.AreEqual(returnedSession, confSession);

            var sessions2 = repository.FindByTitle("ghhg");
            Assert.True(sessions2.Count==0);
            session.Close();
        }

        [Test]
        public void ShouldSaveConfSessionWithFormatToDB()
        {
            var confSession = new ConfSession("Workshop Session");
            confSession.Description = "Session with a Workshop Format";
            confSession.Format = new Format("WorkShop", new Duration(3));

            var repository = new ConfSessionRepository(session);
            repository.Save(confSession);

            
            var sessions = repository.FindByTitle("Workshop");
            var returnedSession = sessions[0];
            //Assert.AreEqual(returnedSession, confSession);
            session.Close();
        }
    }
}

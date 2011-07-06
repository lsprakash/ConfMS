using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using ConfMSProject.domain;


namespace ConfMSTest.domain
{
    [TestFixture]
    public class SessionTest
    {
            [Test]
            public void ShouldBeAbleToCreateSession()
            {
                const string SESSION_NAME = "DevOpsWorkshopSession";
                var session = new ConfSession(SESSION_NAME);
                session.Description = "Some Description";
                Assert.AreEqual(new Title(SESSION_NAME), session.SessionTitle);
                Assert.AreNotEqual(new Title("Blah"), session.SessionTitle);
            }

            [Test]
            public void ShouldAssociateFormatToConfSession()
            {
                var format = new ConfMSProject.domain.Format("WorkShop", new Duration(3));
                var confSession = new ConfSession("Test Session");

                confSession.Format = format;
                Assert.AreEqual(format, confSession.Format);
            }
    }
}

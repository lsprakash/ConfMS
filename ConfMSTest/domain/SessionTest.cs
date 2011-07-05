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
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConfMSProject.domain;
using NUnit.Framework;

namespace ConfMSTest.domain
{
    [TestFixture]
    public class SpeakerTest
    {
        [Test]
        public void ShouldCreateSpeakerWithNameAndEmail()
        {
            const string name = "John";
            const string email = "abc@xyz.com";
            var speaker = new Speaker(name, email);
            Assert.AreEqual(new Name(name), speaker.Name);
            Assert.AreEqual(new Email(email), speaker.Email);
        }
    }
}

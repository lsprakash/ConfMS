using ConfMSProject.domain;
using ConfMSProject.repository;
using NUnit.Framework;

namespace ConfMSTest.repository
{
    [TestFixture]
    public class SpeakerRepositoryTest
    {
        [Test]
        public void ShouldCreateAndSaveSpeaker()
        {
            var name = "John";
            var email = "abc@xyz.com";
            var speaker = new Speaker(name, email);

            var repository = new SpeakerRepository();
//            repository.Save(speaker);

//            var actualSpeakers = repository.findAll();
//
//            Assert.AreEqual(1, actualSpeakers.Count());
        }
    }
}

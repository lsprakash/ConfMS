using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ConfMSProject.domain;
using ConfMSProject.repository;
using NUnit.Framework;

namespace ConfMSTest.repository
{
    public class BaseRepositoryTest
    {
        [Test]
        public void ShouldSaveObject()
        {
            var speaker = new Speaker("John", "abc@xyz.com");
            var baseRepository = new SpeakerRepository();
            baseRepository.Save(speaker);
            var criteria = baseRepository.GetCriteria();
            IList<Speaker> speakers = criteria.List<Speaker>();
            Assert.AreEqual(1, speakers.Count());
            Assert.AreEqual(speaker, speakers[0]);
        }
    }
}

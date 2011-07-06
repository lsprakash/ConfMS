using System.IO;
using ConfMSProject.domain;

namespace ConfMSProject.repository
{
    public class SpeakerRepository : BaseRepository<Speaker>
    {
        public SpeakerRepository() : base("Speaker.hbm.xml")
        {
        }

    }
}
using System.IO;
using ConfMSProject.repository;
using NHibernate;
using NUnit.Framework;

namespace ConfMSTest.repository
{
    public class RepositoryTest
    {
        protected ISession session;

        [SetUp]
        public void setDB()
        {
            NHibernateSessionManager.InitalizeSessionFactory(new FileInfo("domain/mappings/ConfSession.hbm.xml"), new FileInfo("domain/mappings/Conference.hbm.xml"));
            NHibernateSessionManager.CreateDB();
            session = new NHibernateSessionManager().openSession();
        }
    }
}
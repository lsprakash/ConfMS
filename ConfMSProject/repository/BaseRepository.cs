using System;
using System.IO;
using ConfMSProject.domain;
using NHibernate;
using NUnit.Framework;

namespace ConfMSProject.repository
{
    public class BaseRepository<T> where T : class
    {
        private const string MappingPath = "domain/mappings/";
        private readonly NHibernateSessionManager sessionManager;
        private ISession session;

        public BaseRepository(string mappingFile)
        {
            NHibernateSessionManager.InitalizeSessionFactory(new FileInfo(MappingPath+mappingFile));
            NHibernateSessionManager.CreateDB();
            sessionManager = new NHibernateSessionManager();
            session = sessionManager.openSession();
        }

        public void Save(T t)
        {
            using (var tx = session.BeginTransaction())
            {
                session.Save(t);
                tx.Commit();
            }
            session.Flush();
            session.Clear();
        }

        public ICriteria GetCriteria()
        {
            return session.CreateCriteria<T>();
        }
    }
}
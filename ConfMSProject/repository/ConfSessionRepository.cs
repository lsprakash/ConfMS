using System;
using System.Collections.Generic;
using System.IO;
using ConfMSProject.domain;
using NHibernate.Criterion;
using NUnit.Framework;

namespace ConfMSProject.repository
{
    public class ConfSessionRepository : NHibernateSessionManager
    {

        public ConfSessionRepository()
        {
            InitalizeSessionFactory(new FileInfo("domain/mappings/ConfSession.hbm.xml"));
        }

        public void Save(ConfSession confSession)
        {
            Session.Save(confSession);
        }

        public List<ConfSession> FindByTitle(string titleSearchString)
        {
            var criteria = Session.CreateCriteria(typeof(ConfSession));
            if (titleSearchString != null)
                criteria.Add(Restrictions.Like("SessionTitle.Name", "%" + titleSearchString + "%"));
            return (List <ConfSession>) criteria.List<ConfSession>();
        }
    }
}
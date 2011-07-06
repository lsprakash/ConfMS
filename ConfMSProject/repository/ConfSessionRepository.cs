using System;
using System.Collections.Generic;
using System.IO;
using ConfMSProject.domain;
using NHibernate.Criterion;
using NUnit.Framework;

namespace ConfMSProject.repository
{
    public class ConfSessionRepository
    {

        public ConfSessionRepository()
        {
            
        }

        public void Save(ConfSession confSession)
        {
            using (var session = new NHibernateSessionManager().openSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    session.Save(confSession);
                    tx.Commit();
                }
            }

        }

        public List<ConfSession> FindByTitle(string titleSearchString)
        {
            using (var session = new NHibernateSessionManager().openSession())
            {
                using (var tx = session.BeginTransaction())
                {
                    var criteria = session.CreateCriteria(typeof (ConfSession));
                    if (titleSearchString != null)
                        criteria.Add(Restrictions.Like("SessionTitle.Name", "%" + titleSearchString + "%"));
                    return (List<ConfSession>) criteria.List<ConfSession>();
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using ConfMSProject.domain;
using NHibernate;
using NHibernate.Criterion;

namespace ConfMSProject.repository
{
    public class ConfSessionRepository
    {
        private readonly ISession session;

        public ConfSessionRepository(ISession session)
        {
            this.session = session;
        }

        public void Save(ConfSession confSession)
        {
            using (var tx = session.BeginTransaction())
			{
				session.Save(confSession);
				tx.Commit();
			}
            session.Save(confSession);
        }

        public List<ConfSession> FindByTitle(string titleSearchString)
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
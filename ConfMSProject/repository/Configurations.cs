using NHibernate;
using NHibernate.Cfg;

namespace ConfMSProject.repository
{
    public interface IConfigurations
    {
        ISession GetOrCreateSession();
    }

    public class Configurations : IConfigurations
    {
        private static Configurations configurations;
        private readonly ISessionFactory sessionFactory;

        public static Configurations Instance
        {
            get { return configurations ?? (configurations = new Configurations()); }
        }

        public static void Create(string configFile, string databaseConnectionString, int nHibernateCommandTimeout, string showSql)
        {
            configurations = new Configurations(configFile);
        }

        private Configurations()
        {
            var configuration = new Configuration();
            sessionFactory = configuration.Configure().BuildSessionFactory();
        }

        private Configurations(string configFile)
        {
            Configuration configuration = new Configuration().Configure(configFile);
            sessionFactory = configuration.BuildSessionFactory();            
        }

        public ISession GetOrCreateSession()
        {
            return sessionFactory.OpenSession();
        }

    }

}
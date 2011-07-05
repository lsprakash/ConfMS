using System;
using System.Collections.Generic;
using System.IO;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace ConfMSTest.repository
{
    public class NHibernateInMemoryTestFixtureBase
    {
        protected static ISessionFactory sessionFactory;
        protected static Configuration configuration;

        public static void InitalizeSessionFactory(params FileInfo[] hbmFiles)
        {
            try
            { //hibernate.properties
                var properties = new Dictionary<string, string>
                                     {
                                         {"connection.driver_class", "NHibernate.Driver.SQLite20Driver"}, //using SQLLite.. in-memory DB
                                         {
                                             "proxyfactory.factory_class",
                                             "NHibernate.ByteCode.Castle.ProxyFactoryFactory, NHibernate.ByteCode.Castle"
                                             },
                                         {"dialect", "NHibernate.Dialect.SQLiteDialect"},
                                         {"connection.provider", "NHibernate.Connection.DriverConnectionProvider"},
                                         {"connection.connection_string", "Data Source=:memory:;Version=3;New=True;"},
                                         {"connection.release_mode", "auto"},
                                         {"show_sql", "true"}
                                     };

                configuration = new Configuration { Properties = properties };
                Console.WriteLine("Init of Session Factory()");
                foreach (var mappingFile in hbmFiles)
                { //Passed hbm.xml files... add them to configuration
                    configuration = configuration.AddFile(mappingFile);
                }
                configuration.BuildMapping();
                sessionFactory = configuration.BuildSessionFactory();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                throw;
            }
        }

        public ISession CreateSession()
        {
            var openSession = sessionFactory.OpenSession(); //Opens a new session and creates DB (exports DB tables)
            var connection = openSession.Connection;
            using (var writer = new StringWriter())
            {
                new SchemaExport(configuration).Execute(false, true, false, connection, writer);
                Console.WriteLine(writer);
            }
            return openSession;
        }
    }
}
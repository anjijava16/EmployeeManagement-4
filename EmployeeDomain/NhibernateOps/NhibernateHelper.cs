using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Context;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Tool.hbm2ddl;

namespace Domain.Models
{
    /// <summary>
    /// Here basic NHibernate manipulation methods are implemented.
    /// </summary>
    public class NHibernateHelper
    {
        private ISessionFactory _sessionFactory = null;

        /// <summary>
        /// In case there is an already instantiated NHibernate ISessionFactory,
        /// retrieve it, otherwise instantiate it.
        /// </summary>
        public ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                {

                    _sessionFactory = Fluently
                .Configure()
                .Database((MsSqlConfiguration.MsSql2008 // 
                        .ConnectionString(c => c.FromConnectionStringWithKey("abc"))
                        .ShowSql()))
                .CurrentSessionContext("web")
                .Mappings(m => m.FluentMappings
                .AddFromAssemblyOf<Domain.Models.Entities.Department>())
              .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Domain.Models.BaseVo<int>>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(true, true))
                .BuildSessionFactory();

                    //Configuration configuration = new Configuration();
                    //configuration.Configure();

                    //// build a Session Factory
                    //_sessionFactory = configuration.BuildSessionFactory();
                }
                return _sessionFactory;
            }
        }

        /// <summary>
        /// Open an ISession based on the built SessionFactory.
        /// </summary>
        /// <returns>Opened ISession.</returns>
        public ISession OpenSession()
        {
            return SessionFactory.OpenSession();

        }
        /// <summary>
        /// Create an ISession and bind it to the current tNHibernate Context.
        /// </summary>
        public void CreateSession()
        {
            CurrentSessionContext.Bind(OpenSession());
        }

        /// <summary>
        /// Close an ISession and unbind it from the current
        /// NHibernate Context.
        /// </summary>
        public void CloseSession()
        {
            if (CurrentSessionContext.HasBind(SessionFactory))
            {
                CurrentSessionContext.Unbind(SessionFactory).Dispose();
            }
        }

        /// <summary>
        /// Retrieve the current binded NHibernate ISession, in case there
        /// is any. Otherwise, open a new ISession.
        /// </summary>
        /// <returns>The current binded NHibernate ISession.</returns>
        public ISession GetCurrentSession()
        {
            if (!CurrentSessionContext.HasBind(SessionFactory))
            {
                CurrentSessionContext.Bind(SessionFactory.OpenSession());
            }
            return SessionFactory.GetCurrentSession();
        }
    }

}

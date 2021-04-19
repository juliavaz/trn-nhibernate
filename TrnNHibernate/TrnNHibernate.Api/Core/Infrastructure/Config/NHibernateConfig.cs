using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Microsoft.Extensions.Configuration;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System.Collections.Generic;
using System.Diagnostics;
using TrnNHibernate.Api.Core.Infrastructure.Maps;

namespace TrnNHibernate.Core.Infrastructure.Config
{
    public class NHibernateConfig
    {

        FluentConfiguration _fluentConfiguration;

        private IList<IInterceptor> interceptors;
        public NHibernateConfig(IConfiguration configuration)
        {
            interceptors = new List<IInterceptor>();

            _fluentConfiguration = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(configuration.GetConnectionString("Default")))
                .Mappings(x => x.FluentMappings.Add<ClienteMap>());
        }

        public ISessionFactory BuildSessionFactory()
        {
            foreach (var interceptor in interceptors)
            {
                _fluentConfiguration.ExposeConfiguration(x => x.SetInterceptor(interceptor));
            }
          
            return _fluentConfiguration.BuildSessionFactory();
        }

        public void ConfigureCurrentSessionContextClass(CurrentSessionContextClassOption currentSessionContextClassOption)
        {
            _fluentConfiguration.CurrentSessionContext(currentSessionContextClassOption.ToString());    
            
        }

        public void CreateSchema()
        {
            _fluentConfiguration.ExposeConfiguration(c => new SchemaExport(c).Execute(true, true, false))
            .BuildConfiguration();
        }

        public void UpdateSchema()
        {
            _fluentConfiguration.ExposeConfiguration(c => new SchemaUpdate(c).Execute(false, true))
                .BuildConfiguration();
        }

        public void ValidateSchema()
        {
            SchemaValidator validator = new SchemaValidator(_fluentConfiguration.BuildConfiguration());
            validator.Validate();
            try
            {
               
            }
            catch (HibernateException ex)
            {
                Trace.WriteLine(ex.Message);
            }
            
        }

        public NHibernateConfig AddInterceptor(IInterceptor interceptor)
        {
            interceptors.Add(interceptor);
            return this;
        }

    }

    public enum CurrentSessionContextClassOption
    {
        web,
        thread_static
    }
}

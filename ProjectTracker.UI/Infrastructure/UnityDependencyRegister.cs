using ProjectTracker.DL.CountryContextRepository;
using ProjectTracker.DL.DBContextRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Unity;

namespace ProjectTracker.UI.Infrastructure
{
    public class UnityDependencyRegister
    {
        public static void Register(HttpConfiguration configuration)
        {
            var container = new UnityContainer();
            container.RegisterType<IProjectContext, ProjectContextRepository>();
            container.RegisterType<ICountryContext, CountryContextRepository>();
            configuration.DependencyResolver = new UnityResolver(container);
        }
    }
}
using ProjectTracker.BL.CountryRepository;
using ProjectTracker.BL.ProjectRepository;
using ProjectTracker.DL;
using ProjectTracker.Models;
using ProjectTracker.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Unity;
using Unity.Injection;
using Unity.Registration;
using Unity.RegistrationByConvention;

namespace ProjectTracker.UI.Infrastructure
{
    public class UnityDependencyRegister<T> where T : BaseEntity
    {
        public static void Register(HttpConfiguration configuration)
        {

            var container = new UnityContainer();

            //Initialization of Generic Repository from IProject interface for both the Class
            container.RegisterType<IProject, ProjectRepository>(new InjectionMember[] { new InjectionConstructor(new Repository<Project>())});
            container.RegisterType<ICountry, CountryRepository>(new InjectionMember[] { new InjectionConstructor(new Repository<Country>())});
            configuration.DependencyResolver = new UnityResolver(container);
        }
    }
}
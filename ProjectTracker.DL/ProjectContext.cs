using ProjectTracker.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.DL
{
    public sealed class ProjectContext : DbContext
    {
        //Lazy Singleton pattern to initialize Project Context class
        private static readonly Lazy<ProjectContext> instance = new Lazy<ProjectContext>(()=>new ProjectContext());
        

        private ProjectContext() : base("ProjectsDB")
        {
            Database.SetInitializer(new ProjectDBInitilizer());
        }

        public static ProjectContext GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Country> Countries { get; set; }
    }

    public class ProjectDBInitilizer : DropCreateDatabaseIfModelChanges<ProjectContext>
    {
        protected override void Seed(ProjectContext context)
        {
            List<Project> MyProjects = new List<Project> {

                new Project
                {
                    ProjectId=1,
                    Name="Grid Automation",
                    Description="Grid Automation in Genpact",
                    CountryId=1,
                    StartDate=new DateTime(2017,03,01),
                    EndDate=new DateTime(2020,03,01)

                },
                 new Project
                {
                    ProjectId=2,
                    Name="I&Shore",
                    Description="I&Shore on 6th floor",
                    CountryId=2,
                    StartDate =new DateTime(2018,03,01),
                    EndDate=new DateTime(2020,03,01)

                },
                  new Project
                {
                    ProjectId=2,
                    Name="GE OnlineStore",
                    Description="GE Onlinestore project",
                    CountryId=3,
                    StartDate=new DateTime(2015,03,01),
                    EndDate=new DateTime(2025,03,01)

                },

            };

            List<Country> MyCountries = new List<Country>
            {
              new Country
              {
                  CountryId=1,
                  CountryName="United Kingdom",
                  ContinentId=2,
                  Manager="Philippe Begon",
                  CreatedDate=new DateTimeOffset(new DateTime(2019,01,07))

              },
              new Country
              {
                  CountryId=2,
                  CountryName="United States",
                  ContinentId=3,
                  Manager="Antonio",
                  CreatedDate=new DateTimeOffset(new DateTime(2019,01,07))

              },
              new Country
              {
                  CountryId=3,
                  CountryName="Brasil",
                  ContinentId=4,
                  Manager="Juliana Pompilo",
                  CreatedDate=new DateTimeOffset(new DateTime(2019,01,07))

              }
            };

            context.Projects.AddRange(MyProjects);
            context.Countries.AddRange(MyCountries);
            base.Seed(context);
        }
    }
}

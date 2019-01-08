using ProjectTracker.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.DL.DBContextRepository
{
    public interface IProjectContext
    {
        Task<IEnumerable<Project>> GetAsync();
        Task<Project> GetByIdAsync(int Id);
        Task AddProjectAsync(Project projectToAdd);
        Task RemoveProjectAsync(int Id);
        Task UpdateProjectAsync(int Id, Project projecToUpdate);
    }
}

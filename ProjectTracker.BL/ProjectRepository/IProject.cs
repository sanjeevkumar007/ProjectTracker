using ProjectTracker.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.BL.ProjectRepository
{
    public interface IProject
    {
        Task<IEnumerable<Project>> GetProjectsAsync();
        Task<Project> GetProjectsByIdAsync(int Id);
        Task AddProjectAsync(Project projectToAdd);
        Task RemoveProjectAsync(int Id);
        Task UpdateProjectAsync(int Id, Project projecToUpdate);
    }
}

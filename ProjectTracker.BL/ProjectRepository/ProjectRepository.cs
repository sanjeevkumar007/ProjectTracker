using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectTracker.Models.Entities;
using ProjectTracker.DL;

namespace ProjectTracker.BL.ProjectRepository
{
    public class ProjectRepository : IProject
    {
        private readonly IRepository<Project> _context;

        
        public ProjectRepository(IRepository<Project> context)
        {
            _context = context;
        }
        public async Task AddProjectAsync(Project projectToAdd)
        {
            await _context.CreateAsync(projectToAdd);
        }

        public async Task<IEnumerable<Project>> GetProjectsAsync()
        {
            return await _context.GetAllAsync();
        }

        public async Task<Project> GetProjectsByIdAsync(int Id)
        {
            return await _context.GetAsync(Id);
        }

        public async Task RemoveProjectAsync(int Id)
        {
            await _context.RemoveAsync(Id);
        }

        public async Task UpdateProjectAsync(int Id, Project projecToUpdate)
        {
            await _context.UpdateAsync(Id, projecToUpdate);
        }
    }
}

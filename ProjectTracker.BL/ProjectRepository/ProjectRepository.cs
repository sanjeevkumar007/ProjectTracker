using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Models.Entities;
using ProjectTracker.DL.DBContextRepository;

namespace ProjectTracker.BL.ProjectRepository
{
    public class ProjectRepository : IProject
    {
        private readonly IProjectContext _context;
        public ProjectRepository(IProjectContext context)
        {
            _context = context;
        }
        public async Task AddProjectAsync(Project projectToAdd)
        {
            await _context.AddProjectAsync(projectToAdd);
        }

        public async Task<IEnumerable<Project>> GetProjectsAsync()
        {
            return await _context.GetAsync();
        }

        public async Task<Project> GetProjectsByIdAsync(int Id)
        {
            return await _context.GetByIdAsync(Id);
        }

        public async Task RemoveProjectAsync(int Id)
        {
            await _context.RemoveProjectAsync(Id);
        }

        public async Task UpdateProjectAsync(int Id, Project projecToUpdate)
        {
            await _context.UpdateProjectAsync(Id, projecToUpdate);
        }
    }
}

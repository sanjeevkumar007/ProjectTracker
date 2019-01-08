using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTracker.Models.Entities;
using System.Data.Entity;

namespace ProjectTracker.DL.DBContextRepository
{
    public class ProjectContextRepository : IProjectContext
    {
        private readonly ProjectContext _context;

        public ProjectContextRepository()
        {
             _context=new ProjectContext();
        }
        public async Task AddProjectAsync(Project projectToAdd)
        {
             _context.Projects.Add(projectToAdd);
           await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Project>> GetAsync()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<Project> GetByIdAsync(int Id)
        {
            return await _context.Projects.FindAsync(Id);
        }

        public async Task RemoveProjectAsync(int Id)
        {
            var project = await _context.Projects.FirstOrDefaultAsync(p => p.ProjectId == Id);
            _context.Projects.Remove(project);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProjectAsync(int Id, Project projecToUpdate)
        {
            var project = await _context.Projects.FirstOrDefaultAsync(p => p.ProjectId == Id);
            _context.Projects.Remove(project);
            _context.Projects.Add(projecToUpdate);
            await _context.SaveChangesAsync();
        }
    }
}

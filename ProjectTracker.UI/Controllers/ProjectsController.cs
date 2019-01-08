﻿using ProjectTracker.DL.DBContextRepository;
using ProjectTracker.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ProjectTracker.UI.Controllers
{
    public class ProjectsController : ApiController
    {
        private readonly IProjectContext _context;

       
        public ProjectsController(IProjectContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetProjectsAsync()
        {
            var projects=await _context.GetAsync();
            return Ok(projects);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetProjectsByIdAsync(int Id)
        {
            var project= await _context.GetByIdAsync(Id);
            return Ok(project);

        }

        [HttpPost]
        public async Task<IHttpActionResult> AddProjectAsync(Project projectToAdd)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _context.AddProjectAsync(projectToAdd);
            return Ok();
        }

        [HttpPut]
        public async Task<IHttpActionResult> UpdateProjectAsync(int Id,Project projectToUpdate)
        {
            if (Id==0)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _context.UpdateProjectAsync(Id,projectToUpdate);
            return Ok();
        }

        [HttpDelete]
        public async Task<IHttpActionResult> RemoveProjectAsync(int Id)
        {
            if (Id == 0)
            {
                return NotFound();
            }

            await _context.RemoveProjectAsync(Id);
            return Ok();
        }
    }
}
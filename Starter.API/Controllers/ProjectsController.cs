using Microsoft.AspNetCore.Mvc;
using Starter.Core.Entities;
using Starter.Infrastructure.Data;


namespace Starter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProjectsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetProjects()
        {
            var projects = _context.Projects.ToList();
            return Ok(projects);
        }

        [HttpPost]
        public IActionResult CreateProject([FromBody] Project project)
        {
            _context.Projects.Add(project);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetProjects), new { id = project.Id }, project);
        }
    }
}

using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
using DevFreela.API.Persistence;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly FreelanceTotalCostConfig _config; // Configuration for freelance total cost
        private readonly DevFreelaDbContext _context; // Database context for accessing projects

        public ProjectsController(IOptions<FreelanceTotalCostConfig> options, DevFreelaDbContext context)
        {
            _config = options.Value; // Initialize configuration
            _context = context; // Initialize database context
        }

        // GET api/projects?search=crm
        [HttpGet]
        public IActionResult Get(string search = "")
        {
            var projects = _context.Projects
                .Include(p => p.Client) // Include related client data
                .Include(p => p.Freelancer) // Include related freelancer data
                .Where(p => !p.IsDeleted &&
                    (string.IsNullOrEmpty(search) || p.Title.ToLower().Contains(search.ToLower()))) // Filter projects based on search
                .ToList();

            var model = projects.Select(ProjectItemViewModel.FromEntity).ToList(); // Convert entities to view models
            return Ok(model); // Return the filtered project list
        }

        // GET api/projects/1234
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // Implementation to fetch a project by ID
            return Ok(); // Return the corresponding project
        }

        // POST api/projects
        [HttpPost]
        public IActionResult Post(CreateProjectInputModel model)
        {
            if (model.TotalCost < _config.Minimum || model.TotalCost > _config.Maximum)
            {
                return BadRequest("Number out of limits."); // Validate total cost limits
            }

            // Here you should add the code to save the project to the database
            // Example: _context.Projects.Add(new Project { ... });
            // _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = 1 }, model); // Return created project
        }

        // PUT api/projects/1234
        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateProjectInputModel model)
        {
            return NoContent(); // Implementation for updating a project
        }

        // DELETE api/projects/1234
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent(); // Implementation for deleting a project
        }

        // PUT api/projects/1234/start
        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent(); // Implementation for starting a project
        }

        // PUT api/projects/1234/complete
        [HttpPut("{id}/complete")]
        public IActionResult Complete(int id)
        {
            return NoContent(); // Implementation for completing a project
        }

        // POST api/projects/1234/comments
        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, CreateProjectCommentInputModel model)
        {
            return Ok(); // Implementation for posting a comment on a project
        }
    }
}
using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string query)
        {
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            // if invalid object
            // return NotFound();

            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateProjectModel createProject)
        {
            // if invalid object
            // return BadRequest();

            // Create object

            return CreatedAtAction(nameof(GetById), new { id = createProject.Id }, createProject);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, UpdateProjectModel updateProject)
        {
            // if invalid object
            // return BadRequest();

            // Update object

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // if object not found
            // return NotFound();

            // Delete object

            return NoContent();
        }

        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] CreateCommentModel createComment)
        {
            return NoContent();
        }

        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            return NoContent();
        }

        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            return NoContent();
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using SQ.CurriculumService.Repository.Repositories;

namespace SQ.CurriculumService.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private ITaskRepository taskRepository;
        public TaskController(ITaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        [HttpGet(Name = "GetAllTask")]
        public IActionResult Get()
        {
            return Ok(this.taskRepository.GetAll());
        }
    }
}

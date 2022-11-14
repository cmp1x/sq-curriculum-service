using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SQ.CurriculumService.Repository.Models;
using SQ.CurriculumService.Repository.Repositories;
using SQ.CurriculumService.Web.Models;
using SQ.CurriculumService.Web.Profiles;
using System.Collections.Generic;

namespace SQ.CurriculumService.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private ITaskRepository taskRepository;
        private IMapper mapper;
        public TaskController(ITaskRepository taskRepository, IMapper mapper)
        {
            this.taskRepository = taskRepository;
            this.mapper = mapper;
        }

        [HttpGet(Name = "GetAllTask")]
        public IActionResult Get()
        {
            var allTasksFromRep = this.taskRepository.GetAll().ToList();
            var allTasksDto = this.mapper.Map<IEnumerable<TaskDb>, IEnumerable<TaskDto>>(allTasksFromRep);
            return Ok(allTasksDto);
        }
    }
}

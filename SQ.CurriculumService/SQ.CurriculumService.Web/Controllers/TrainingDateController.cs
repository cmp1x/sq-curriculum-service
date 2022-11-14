using Microsoft.AspNetCore.Mvc;
using SQ.CurriculumService.Repository.Repositories;

namespace SQ.CurriculumService.Web.Controllers
{
    public class TrainingDateController: ControllerBase
    {
        private ITrainingDateRepository TrainingDateRepository;

        public TrainingDateController (ITrainingDateRepository db)
        {
            this.TrainingDateRepository = db;
        }

        [HttpGet("FromTaskId")]
        public IActionResult GetFromTaskId(int taskId)
        {
            return Ok(this.TrainingDateRepository.GetFromTaskId(taskId));
        }
    }
}

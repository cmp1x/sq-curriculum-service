using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SQ.CurriculumService.Repository.Models;
using SQ.CurriculumService.Repository.Repositories;
using SQ.CurriculumService.Web.Models;

namespace SQ.CurriculumService.Web.Controllers
{
    public class TrainingDateController: ControllerBase
    {
        private ITrainingDateRepository trainingDateRepository;
        private IMapper mapper;

        public TrainingDateController (ITrainingDateRepository db, IMapper mapper)
        {
            this.trainingDateRepository = db;
            this.mapper = mapper;
        }

        [HttpGet("FromTaskId")]
        public IActionResult GetFromTaskId(int taskId)
        {
            var allTrainingDatesFromRep = this.trainingDateRepository.GetFromTaskId(taskId).ToList();
            var allTrainingDates = this.mapper.Map<List<TrainingDateDb>, List<TrainingDateDto>>(allTrainingDatesFromRep);
            return Ok(allTrainingDates);
        }
    }
}

using SQ.CurriculumService.Repository.Enums;

namespace SQ.CurriculumService.Web.Models
{
    public class TaskDto
    {
        //public int Id { get; set; }
        public string TaskId { get; set; }
        public StatusState Status { get; set; }
        public bool IsCompleted { get; set; } = false;
        public PriorityColor Priority { get; set; } 

        public decimal HoursSpent { get; set; }

        public List<TrainingDateDto> TrainingDates { get; set; }
    }
}

using SQ.CurriculumService.Repository.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ.CurriculumService.Repository.Models
{
    [Table("t_task")]
    public class TaskDb
    {
        public int Id { get; set; }
        public string TaskId { get; set; }
        public StatusState Status { get; set; }

        public PriorityColor PriorityColor { get; set; }

        public decimal HoursSpent { get; set; }

        public List<TrainingDateDb> TrainingDates { get; set; } = new List<TrainingDateDb>();
    }
}

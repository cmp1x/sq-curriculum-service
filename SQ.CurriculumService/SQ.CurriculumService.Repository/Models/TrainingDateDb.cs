using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SQ.CurriculumService.Repository.Models
{
    [Table("t_training_date")]
    public class TrainingDateDb
    {
        public int Id { get;set; }
        public DateTime DateTime { get;set; }
        public TimeSpan Duration { get; set; }

        [ForeignKey("TaskId")]
        public int TaskId { get; set; }

        [JsonIgnore]
        public virtual TaskDb TaskDb { get; set; }
    }
}

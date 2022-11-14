using SQ.CurriculumService.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ.CurriculumService.Repository.Repositories
{
    public interface ITrainingDateRepository
    {
        public IQueryable<TrainingDateDb> GetFromTaskId(int taskId);
    }
}

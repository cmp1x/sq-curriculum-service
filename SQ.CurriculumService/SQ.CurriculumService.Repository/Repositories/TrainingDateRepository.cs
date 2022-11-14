using SQ.CurriculumService.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ.CurriculumService.Repository.Repositories
{
    public class TrainingDateRepository : ITrainingDateRepository
    {
        private CurriculumDbContext CurriculumDbContext;
        public TrainingDateRepository(CurriculumDbContext db)
        {
            this.CurriculumDbContext = db;
        }
        public IQueryable<TrainingDateDb> GetFromTaskId(int taskId)
        {
            return this.CurriculumDbContext.TrainingDates
                .Where(trd => trd.TaskId == taskId);
        }
    }
}

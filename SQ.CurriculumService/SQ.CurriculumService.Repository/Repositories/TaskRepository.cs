using Microsoft.EntityFrameworkCore;
using SQ.CurriculumService.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ.CurriculumService.Repository.Repositories
{
    public class TaskRepository: ITaskRepository
    {
        private CurriculumDbContext CurriculumDbContext;
        public TaskRepository(CurriculumDbContext curriculumDbContext)
        {
            this.CurriculumDbContext = curriculumDbContext;
        }
        public IQueryable<TaskDb> GetAll()
        {
            return this.CurriculumDbContext.Tasks
                .Include(trd => trd.TrainingDates)
                ;
        }
    }
}

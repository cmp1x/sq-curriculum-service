using SQ.CurriculumService.Repository.Models;

namespace SQ.CurriculumService.Repository.Repositories
{
    public interface ITaskRepository
    {
        public IQueryable<TaskDb> GetAll();
    }
}
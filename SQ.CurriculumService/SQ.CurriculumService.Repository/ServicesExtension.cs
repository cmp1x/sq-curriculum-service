using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SQ.CurriculumService.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SQ.CurriculumService.Repository
{
    public static class ServicesExtension
    {
        public static void AddRepositoryServices(this IServiceCollection service, string connectionString)
        {
            service.AddTransient<ITaskRepository, TaskRepository>();
            service.AddTransient<ITrainingDateRepository, TrainingDateRepository>();
            service.AddDbContext<CurriculumDbContext>(option => option.UseNpgsql(connectionString));
        }
    }
}

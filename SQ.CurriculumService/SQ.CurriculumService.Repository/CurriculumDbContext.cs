using Microsoft.EntityFrameworkCore;
using SQ.CurriculumService.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ.CurriculumService.Repository
{
    public class CurriculumDbContext : DbContext
    {
        public CurriculumDbContext(DbContextOptions<CurriculumDbContext> options)
            : base(options)
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public DbSet<TaskDb> Tasks { get; set; }
        public DbSet<TrainingDateDb> TrainingDates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var task = this.CreateTaskDbEntity(1, 1);

            var taskDate1 = this.CreateTrainingDateDbEntity(1, task, "2015-03-19T02:13:55", "00:30:12");
            var taskDate2 = this.CreateTrainingDateDbEntity(2, task, "2015-03-20T12:22:58", "00:12:54");

            modelBuilder.Entity<TaskDb>().HasData(task);

            modelBuilder.Entity<TrainingDateDb>().HasData(
                new TrainingDateDb()
                {
                    Id = taskDate1.Id,
                    TaskId = task.Id,
                    DateTime = taskDate1.DateTime,
                    Duration = taskDate1.Duration,
                }
                , new TrainingDateDb()
                {
                    Id = taskDate2.Id,
                    TaskId = task.Id,
                    DateTime = taskDate2.DateTime,
                    Duration = taskDate2.Duration,
                }
                );

            modelBuilder.Entity<TaskDb>()
                .HasMany(task=>task.TrainingDates)
                .WithOne(trb => trb.TaskDb)
                .HasForeignKey(task=>task.TaskId);

            //modelBuilder.Entity<TrainingDateDb>()
            //    .HasOne<TaskDb>(trd => trd.TaskDb)
            //    .WithMany(task => task.TrainingDates)
            //    .HasForeignKey(trd => trd.TaskId);

        }
        #region PrivateMethods
        private TaskDb CreateTaskDbEntity(int priorityColorId, int statusStateId)
        {
            return new TaskDb()
            {
                Id = 1,
                PriorityColor = Enums.PriorityColor.RED,
                Status = Enums.StatusState.INPROGRESS,
                TaskId = "BcC3wjiURyg",
                HoursSpent = 123,
            };
        }
        private TrainingDateDb CreateTrainingDateDbEntity(int id, TaskDb taskDb, string dateTime, string duration)
        {
            return new TrainingDateDb()
            {
                Id = id,
                TaskId = taskDb.Id,
                DateTime = this.ParseDateTime(dateTime).ToUniversalTime(),
                Duration = this.ParseDuration(duration),
                TaskDb = taskDb
            };
        }

        private DateTime ParseDateTime(string datetime)
        {
            var dateAsArrayOfString = datetime.Split('T')[0].Split('-');
            var timeAsArrayOfString = datetime.Split('T')[1].Split(':');
            return new DateTime(
                Convert.ToInt16(dateAsArrayOfString[0]),
                Convert.ToInt16(dateAsArrayOfString[1]),
                Convert.ToInt16(dateAsArrayOfString[2]),
                Convert.ToInt16(timeAsArrayOfString[0]),
                Convert.ToInt16(timeAsArrayOfString[1]),
                Convert.ToInt16(timeAsArrayOfString[2])
                );
        }

        private TimeSpan ParseDuration(string duration)
        {
            var durationAsArrayOfString = duration.Split(':');
            return new TimeSpan(
                Convert.ToInt16(durationAsArrayOfString[0]),
                Convert.ToInt16(durationAsArrayOfString[1]),
                Convert.ToInt16(durationAsArrayOfString[2])
                );
        }
        #endregion
    }
}

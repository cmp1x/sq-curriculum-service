using AutoMapper;
using SQ.CurriculumService.Repository.Models;
using SQ.CurriculumService.Web.Models;

namespace SQ.CurriculumService.Web.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<TaskDb, TaskDto>().ReverseMap();
            CreateMap<TrainingDateDb, TrainingDateDto>().ReverseMap();

            //CreateMap<TaskDb, TaskDto>()
            //    .ForMember(
            //        dto => dto.TaskId,
            //        db => db.MapFrom(db => $"{db.TaskId}"))
            //    .ForMember(
            //        destination => destination.HoursSpent,
            //        options => options.MapFrom(source => $"{source.HoursSpent}"))
            //    .ForMember(
            //        dest => dest.Status,
            //        opt => opt.MapFrom(src => $"{src.Status}"))
            //    .ForMember(
            //        dest => dest.Priority,
            //        opt => opt.MapFrom(src => $"{src.PriorityColor}"))
            //    .ForMember(
            //        dest => dest.TrainingDate,
            //        opt => opt.MapFrom(src => src.TrainingDates));
            //
            //CreateMap<TaskDto, TaskDb>()
            //    //.ForMember(
            //        //dest => dest.TaskId,
            //        //opt => opt.MapFrom(src => $"{src.TaskId}"))
            //    .ForMember(
            //        dest => dest.HoursSpent,
            //        opt => opt.MapFrom(src => src.HoursSpent))
            //    .ForMember(
            //        dest => dest.Status,
            //        opt => opt.MapFrom(src => src.Status))
            //    .ForMember(
            //        dest => dest.PriorityColor,
            //        opt => opt.MapFrom(src => src.Priority))
            //    .ForMember(
            //        dest => dest.TrainingDates,
            //        opt => opt.MapFrom(src => src.TrainingDate));
        }
    }
}

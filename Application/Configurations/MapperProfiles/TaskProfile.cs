using AutoMapper;
using Domain.Entities;

namespace Application.Configurations.MapperProfiles
{
    public class TaskProfile : Profile
    {
        public TaskProfile()
        {
            CreateMap<Features.TaskItems.Commands.CreateTaskItem.CreateTaskItemRequest, TaskItem>();
            CreateMap<Features.TaskItems.Commands.UpdateTaskItem.UpdateTaskItemRequest, TaskItem>();
            CreateMap<Features.TaskItems.Queries.GetAllTaskItems.GetAllTaskItemsDto, TaskItem>().ReverseMap();
            CreateMap<Features.TaskItems.Queries.GetTaskItemDetailsRequest.GetTaskItemDetailsDto, TaskItem>();
        }
    }
}

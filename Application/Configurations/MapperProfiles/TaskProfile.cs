using Application.Features.TaskItems.Queries.GetTaskItemDetailsRequest;
using AutoMapper;
using Domain.Entities;

namespace Application.Configurations.MapperProfiles
{
    public class TaskProfile : Profile
    {
        public TaskProfile()
        {
            CreateMap<TaskItem, Features.TaskItems.Commands.CreateTaskItem.CreateTaskItemRequest>();
            CreateMap<TaskItem, Features.TaskItems.Commands.UpdateTaskItem.UpdateTaskItemRequest>();
            CreateMap<Features.TaskItems.Queries.GetAllTaskItems.GetAllTaskItemsDto, TaskItem>().ReverseMap();
            CreateMap<GetTaskItemDetailsDto, TaskItem>();
        }
    }
}

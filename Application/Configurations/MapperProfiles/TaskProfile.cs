using Application.Features.TaskItems.Queries.GetAllTaskItems;
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
            CreateMap<TaskItem, GetAllTaskItemsDto>();
            CreateMap<TaskItem, Features.TaskItems.Queries.GetTaskItemDetailsRequest.GetTaskItemDetailsDto>();
        }
    }
}

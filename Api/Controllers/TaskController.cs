using Application.Features.TaskItems.Commands.CreateTaskItem;
using Application.Features.TaskItems.Commands.DeleteTaskItem;
using Application.Features.TaskItems.Commands.UpdateTaskItem;
using Application.Features.TaskItems.Queries.GetAllTaskItems;
using Application.Features.TaskItems.Queries.GetTaskItemDetailsRequest;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TaskController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<GetAllTaskItemsDto>>> Get()
        {
            var result = await _mediator.Send(new GetAllTaskItemsRequest());
            return Ok(result);
        }

        [HttpGet("id")]
        public async Task<ActionResult<GetTaskItemDetailsDto>> Get(Guid id)
        {
            var result = await _mediator.Send(new GetTaskItemDetailsRequest(id));
            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateTaskItemRequest item)
        {
            var response = await _mediator.Send(item);
            return CreatedAtAction(nameof(Post), new { id = response });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(UpdateTaskItemRequest item)
        {
            await _mediator.Send(item);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var command = new DeleteTaskItemRequest(id);
            await _mediator.Send(command);
            return NoContent();
        }
    }
}

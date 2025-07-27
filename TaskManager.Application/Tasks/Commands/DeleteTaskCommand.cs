using MediatR;

namespace TaskManager.Application.Tasks.Commands;

public class DeleteTaskCommand : IRequest
{
    public int Id { get; set; }
}
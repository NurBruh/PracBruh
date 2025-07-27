using MediatR;
namespace TaskManager.Application.Tasks.Commands;

public class CreateTaskCommand : IRequest<int>
{
    public string Title { get; set; } = "";
    public string? Description { get; set; }
    public string Status {get; set; } = "В ожидании";
    public DateTime? Deadline { get; set; }
    public int? UserId { get; set; }
}
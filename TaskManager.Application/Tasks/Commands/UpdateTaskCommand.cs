using MediatR;
namespace TaskManager.Application.Tasks.Commands;

public class UpdateTaskCommand : IRequest
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string? Description { get; set; }
    public string Status { get; set; } = "В ожидании";
    public DateTime? DeadDate { get; set; }
    public int? UserId { get; set; }
}
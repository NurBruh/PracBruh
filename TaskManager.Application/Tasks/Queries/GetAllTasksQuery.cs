using MediatR;
using TaskManager.Domain.Entities;

namespace TaskManager.Application.Tasks.Queries;

public class GetAllTasksQuery :  IRequest<List<TaskItem>>
{
    
}
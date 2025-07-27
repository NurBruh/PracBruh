using MediatR;
using Microsoft.EntityFrameworkCore;
using TaskManager.Application.Common.Interfaces;
using TaskManager.Domain.Entities;
namespace TaskManager.Application.Tasks.Queries;

public class GetAllTasksQueryHandler : IRequestHandler<GetAllTasksQuery, List<TaskItem>>
{
    private readonly IAppDbContext _context;

    public GetAllTasksQueryHandler(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<List<TaskItem>> Handle(GetAllTasksQuery request, CancellationToken cancellationToken)
    {
        return await _context.Tasks.ToListAsync(cancellationToken);
    }

}
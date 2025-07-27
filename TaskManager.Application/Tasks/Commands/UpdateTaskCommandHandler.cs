using MediatR;
using Microsoft.EntityFrameworkCore;
using TaskManager.Application.Common.Interfaces;
using TaskManager.Domain.Entities;

namespace TaskManager.Application.Tasks.Commands;

public class UpdateTaskCommandHandler : IRequestHandler<UpdateTaskCommand>
{
    private readonly IAppDbContext _context;

    public UpdateTaskCommandHandler(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
    {
        var task = await _context.Tasks.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        if (task == null)
            throw new Exception("Task now found");
        
        task.Title = request.Title;
        task.Description = request.Description;
        task.Status = request.Status;
        task.Deadline = request.DeadDate;
        task.UserId = request.UserId;
        
        await _context.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}
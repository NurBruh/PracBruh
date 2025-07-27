using MediatR;
using Microsoft.EntityFrameworkCore;
using TaskManager.Application.Common.Interfaces;

namespace TaskManager.Application.Tasks.Commands;

public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand>
{
    private readonly IAppDbContext _context;

    public DeleteTaskCommandHandler(IAppDbContext context)
    {
        _context = context;
    }

    public async Task<Unit> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
    {
        var task = await _context.Tasks.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

        if (task == null)
            throw new Exception("Задача не найдено!");
        
        _context.Tasks.Remove(task);
        await _context.SaveChangesAsync(cancellationToken);
        return Unit.Value;
    }
}
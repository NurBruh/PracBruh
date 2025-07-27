using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using TaskManager.Domain.Entities;
namespace TaskManager.Application.Common.Interfaces;

public interface IAppDbContext
{
    DbSet<TaskItem> Tasks { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    public DatabaseFacade Database { get; }
}
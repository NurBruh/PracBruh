using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using TaskManager.Application.Common.Interfaces;
using TaskManager.Domain.Entities;
namespace TaskManager.Infrastructure;

public class AppDbContext : DbContext, IAppDbContext
{
   public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
   public DbSet<TaskItem> Tasks { get; set; } = null!;

   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity<TaskItem>()
         .HasIndex(x => x.UserId);

      modelBuilder.Entity<TaskItem>()
         .HasIndex(x => x.Title);

      modelBuilder.Entity<TaskItem>()
         .HasIndex(x => x.Status);

   }
   
   public DatabaseFacade Database => base.Database;

}
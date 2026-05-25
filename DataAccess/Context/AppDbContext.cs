using Microsoft.EntityFrameworkCore;
using DataAccess.Entities;

namespace DataAccess.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Session> Sessions {get; set; }
    public DbSet<AuditLog> auditLogs {get; set;}
}
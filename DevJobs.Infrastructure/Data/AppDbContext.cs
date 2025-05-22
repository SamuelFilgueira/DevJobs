using System.Text.Json;
using DevJobs.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevJobs.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }
    public DbSet<Job> Jobs { get; set; }
    public DbSet<Candidatura> Candidaturas { get; set; }

    protected override void OnModelCreating(ModelBuilder mb)
    {

        mb.Entity<Job>()
            .HasOne(u => u.Recrutador)
            .WithMany(j => j.VagasPublicadas)
            .HasForeignKey(j => j.RecrutadorId)
            .OnDelete(DeleteBehavior.Restrict);

        mb.Entity<Candidatura>()
           .HasOne(c => c.User)
           .WithMany(u => u.Candidaturas)
           .HasForeignKey(c => c.UserId)
           .OnDelete(DeleteBehavior.Restrict);

        mb.Entity<Candidatura>()
            .HasOne(j => j.Job)
            .WithMany(j => j.Candidaturas)
            .HasForeignKey(j => j.JobId)
            .OnDelete(DeleteBehavior.Restrict);

        mb.Entity<Job>()
            .Property(j => j.Skills)
            .HasConversion(v => JsonSerializer.Serialize(v, new JsonSerializerOptions()),
            v => JsonSerializer.Deserialize<List<string>>(v, new JsonSerializerOptions())!
            );

        base.OnModelCreating(mb);
    }
}

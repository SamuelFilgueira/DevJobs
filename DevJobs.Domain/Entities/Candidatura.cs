namespace DevJobs.Domain.Entities;

public class Candidatura : BaseEntity
{
    public Guid UserId { get; set; }
    public User User { get; set; } = null!;

    public Guid JobId { get; set; }
    public Job Job { get; set; } = null!;

    public DateTime DataCandidatura { get; set; } = DateTime.UtcNow;
}

namespace DevJobs.Domain.Entities;

public class Job : BaseEntity
{
    public Job(string title, string description, string senioridade, double salario, string localidade, Guid recrutadorId)
    {
        Title = title;
        Description = description;
        Senioridade = senioridade;
        Salario = salario;
        Localidade = localidade;
        RecrutadorId = recrutadorId;

        Candidaturas = new List<Candidatura>();
        Skills = new List<string>();
    }

    public string Title { get; private set; } 
    public string Description { get; private set; } 
    public string Senioridade { get; private set; } 
    public double Salario { get; private set; }
    public string Localidade { get; private set; }

    public Guid RecrutadorId { get; private set; }
    public User Recrutador { get; private set; } = null!;
    public List<string> Skills { get; private set; }
    public List<Candidatura> Candidaturas { get; private set; }
}

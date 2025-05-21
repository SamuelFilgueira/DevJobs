using DevJobs.Domain.Enums;

namespace DevJobs.Domain.Entities;

public class User : BaseEntity
{
    public User(string userName, string email, string passwordHash, double pretensaoSalarial, string descricao, string numeroCelular)
    {
        UserName = userName;
        Email = email;
        PasswordHash = passwordHash;
        PretensaoSalarial = pretensaoSalarial;
        Descricao = descricao;
        NumeroCelular = numeroCelular;

        Habilidades = new List<string>();
        VagasPublicadas = new List<Job>();
        Candidaturas = new List<Candidatura>();
    }

    public string UserName { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public double PretensaoSalarial { get; private set; }
    public string Descricao { get; private set; }
    public string NumeroCelular { get; private set; }

    public string RefreshToken { get; private set; }
    public UserRole Role { get; private set; } = UserRole.Developer;

    public List<string> Habilidades { get; private set; }
    public List<Job> VagasPublicadas { get; private set; }
    public List<Candidatura> Candidaturas { get; private set; }
}

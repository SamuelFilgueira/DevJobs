namespace DevJobs.Application.DTOs.User;

public class RegisterUserDto
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public double PretensaoSalarial { get; set; }
    public string Descricao { get; set; }
    public string NumeroCelular { get; set; }
}

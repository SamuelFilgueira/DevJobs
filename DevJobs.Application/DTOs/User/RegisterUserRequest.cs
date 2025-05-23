namespace DevJobs.Application.DTOs.User;

public class RegisterUserRequest
{
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public double PretensaoSalarial { get; set; }
    public string Descricao { get; set; } = string.Empty;
    public string NumeroCelular { get; set; } = string.Empty;
}

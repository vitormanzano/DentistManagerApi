namespace DentistManagerApi.Models.Person;

public class PersonModel
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Cpf { get; set; }
    public string Phone { get; set; }
    public string Birthday { get; set; }
    public char Gender { get; set; }
    
}
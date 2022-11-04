public class Client
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }

    public Client(string nome, string cognome, string email, string phone)
    {
        Nome = nome;
        Cognome = cognome;
        Email = email;
        Phone = phone;
    }
}
public class Prestito
{
    public string InizioPrestito { get; set; }
    public string FinePrestito { get; set; }
    public Client User { get; set; }
    public Documento Document { get; set; }

    public Prestito(string inizioPrestito, string finePrestito, Client user, Documento document)
    {
        InizioPrestito = inizioPrestito;
        FinePrestito = finePrestito;
        User = user;
        Document = document;
    }
}
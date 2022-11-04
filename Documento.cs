public class Documento
{
    public int Id { get; set; }
    public string Titolo { get; set; }
    public int Anno { get; set; }
    public string Settore { get; set; }
    public bool InPrestito { get; set; }
    public string Scaffale { get; set; }
    public string Autore { get; set; }

    public Documento(string titolo, string autore)
    {
        Id = new Random().Next(100);
        Titolo = titolo;
        Autore = autore;
        InPrestito = false;
    }
    public Documento(int id, string titolo, int anno, string settore, bool inPrestito, string scaffale, string autore)
    {
        Id = id;
        Titolo = titolo;
        Anno = anno;
        Settore = settore;
        InPrestito = inPrestito;
        Scaffale = scaffale;
        Autore = autore;
    }
}

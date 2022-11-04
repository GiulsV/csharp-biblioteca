// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*Richiesta:
Si vuole progettare un sistema per la gestione di una biblioteca dove il bibliotecario può verificare i dati dei clienti registrati
        - cognome,
        - nome,
        - email,
        - recapito telefonico,
Il bibliotecario può effettuare dei prestiti ai suoi clienti registrati, attraverso il sistema, sui documenti che sono di vario tipo (libri, DVD).

I documenti sono caratterizzati da:
        - un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
        - titolo,
        - anno,
        - settore (storia, matematica, economia, …),
        - stato (In Prestito, Disponibile),
        - uno scaffale in cui è posizionato,
        - un autore (Nome, Cognome).
Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.

Il bibliotecario deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un cliente.

Mi raccomando, prima di buttarvi sul codice fate qualche schema per capire le entità principali e le loro relazioni / eredità. */


//Prova menu
Console.WriteLine("Azione richiesta:");
Console.WriteLine("1 - Cerca Libro/DVD");
Console.WriteLine("2 - Cerca Utente");
int scelta = Convert.ToInt32(Console.ReadLine());

if (scelta == 1) 
{
    // funzione per cercare un documento per nome/codice

}
else if (scelta == 2)
{
    // funzione per cercare utente

}
else 
{ Console.WriteLine("Scelta errata riprovare"); }

//prova stampa info
Libro libro_1 = new Libro(500, 425, "Harry Potter", 2001, "Romanzo", false, "Best Sellers", "J. K. Rowling");
Client utente_1 = new Client("Francesca", "Panzera", "panzera.francesca@gmail.com", "3333216799");
Prestito prestito_1 = new Prestito("20/09/2022", "30/09/2022", utente_1, libro_1);
Console.WriteLine("La signora " + utente_1.Nome + " " + utente_1.Cognome + " ha noleggiato il libro " + prestito_1.Document.Titolo);
Console.WriteLine("La durate del prestito va dal " + prestito_1.InizioPrestito + " al " + prestito_1.FinePrestito);

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

public class Documento
{
    public int Id { get; set; }
    public string Titolo { get; set; }
    public int Anno { get; set; }
    public string Settore { get; set; }
    public bool InPrestito { get; set; }
    public string Scaffale { get; set; }
    public string Autore { get; set; }


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

public class Dvd : Documento
{
    public int Durata { get; set; }

    public Dvd(int Durata, int Id, string Titolo, int Anno, string Settore, bool InPrestito, string Scaffale, string Autore) : base(Id, Titolo, Anno, Settore, InPrestito, Scaffale, Autore)
    {
        this.Durata = Durata;
    }
}

public class Libro : Documento
{
    public int NumPagine { get; set; }

    public Libro(int NumPagine, int Id, string Titolo, int Anno, string Settore, bool InPrestito, string Scaffale, string Autore) : base(Id, Titolo, Anno, Settore, InPrestito, Scaffale, Autore)
    {
        this.NumPagine = NumPagine;
    }
}

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



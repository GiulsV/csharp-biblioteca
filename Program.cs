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
Console.WriteLine("3 - Effettua Prestito");
Console.WriteLine("4 - Restituisci Prestito");
int scelta = Convert.ToInt32(Console.ReadLine());

// Sostituire con switch e do-while
if (scelta == 1)
{
    // Funzione per cercare un documento per nome/codice

}
else if (scelta == 2)
{
    // Funzione per cercare utente

}
else if (scelta == 3) 
{
    // Funzione per effettuare prestito
}
else if (scelta == 4) 
{
    // Funzione per restituire prestito
}
else
{ Console.WriteLine("Scelta errata riprovare"); }


/* 
 //prova stampa info
Libro libro_1 = new Libro(500, 425, "Harry Potter", 2001, "Romanzo", false, "Best Sellers", "J. K. Rowling");
Client utente_1 = new Client("Francesca", "Panzera", "panzera.francesca@gmail.com", "3333216799");
Prestito prestito_1 = new Prestito("20/09/2022", "30/09/2022", utente_1, libro_1);
Console.WriteLine("La signora " + utente_1.Nome + " " + utente_1.Cognome + " ha noleggiato il libro " + prestito_1.Document.Titolo);
Console.WriteLine("La durate del prestito va dal " + prestito_1.InizioPrestito + " al " + prestito_1.FinePrestito);*/

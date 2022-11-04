// See https://aka.ms/new-console-template for more information


public class Documento
{
    public int Codice { get; set; }
    public string Titolo { get; set; }
    public int Anno { get; set; }
    public string Settore { get; set; }
    public bool Stato { get; set; }
    public int Scaffale { get; set; }
    public string Autore { get; set; }

    public Documento (int codice, string titolo, int anno, string settore, bool stato, int scaffale, string autore)
    {
        Codice = codice;
        Titolo = titolo;
        Anno = anno;
        Settore = settore;
        Scaffale = scaffale;
        Autore = autore;
    }
}

public class Libro : Documento
{
    public int NumPagine { get; set; }

    public Libro ( int numPagine, int codice, string titolo, int anno, string settore, bool stato, int scaffale, string autore) : base(codice, titolo, anno, settore, stato, scaffale, autore)
    {
        NumPagine = numPagine;
    } 
}

public class Dvd : Documento
{
    public int Durata { get; set; }

    public Dvd (int durata, int codice, string titolo, int anno, string settore, bool stato, int scaffale, string autore) : base(codice, titolo, anno, settore, stato, scaffale, autore)
    {
        Durata = durata;
    }
}
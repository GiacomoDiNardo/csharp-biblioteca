// See https://aka.ms/new-console-template for more information

public class Film : Documento
{
    public int Durata { get; set; }

    public Film(int durata, int codice, string titolo, int anno, string settore, bool stato, int scaffale, string autore) : base(codice, titolo, anno, settore, stato, scaffale, autore)
    {
        Durata = durata;
    }

    public override string ToString()
    {
        return "DVD" + Codice;
    }
}

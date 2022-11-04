// See https://aka.ms/new-console-template for more information

public class Libro : Documento
{
    public int NumPagine { get; set; }

    public Libro ( int numPagine, string codice, string titolo, int anno, string settore, bool stato, int scaffale, string autore) : base(codice, titolo, anno, settore, stato, scaffale, autore)
    {
        NumPagine = numPagine;
    }

    public override string ToString()
    {
        return "LIB" + Codice;
    }

}

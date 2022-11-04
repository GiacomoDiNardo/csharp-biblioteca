// See https://aka.ms/new-console-template for more information

using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;

Libro l1 = new Libro(600, new Random().Next(1, 10000).ToString(), "Dune", 1965, "fantasy", false, 4, "F. Herbert");
Libro l2 = new Libro(480, new Random().Next(1, 10000).ToString(), "Kobe e la compagnia degli anelli", 2021, "biografia", true, 2, "J. Perlman");
Libro l3 = new Libro(468, new Random().Next(1, 10000).ToString(), "THe dark stuff", 2007, "documentario", true, 1, "Nick Kent");

Film f1 = new Film(116, new Random().Next(1, 10000).ToString(), "Ritorno al futuro", 1985, "fantascienza", true, 5, "Robert Zemeckis");
Film f2 = new Film(169, new Random().Next(1, 10000).ToString(), "Interstellar", 2014, "fantascienza", true, 1, "Christopher Nolan");
Film f3 = new Film(136, new Random().Next(1, 10000).ToString(), "Coach Carter", 2005, "sportivo", true, 3, "Thomas Carter");

List<Documento> documenti = new List<Documento>();

documenti.Add(l1);
documenti.Add(l2);
documenti.Add(l3);
documenti.Add(f1);
documenti.Add(f2);
documenti.Add(f3);

Utente u1 = new Utente("Di Nardo", "Giacomo", "giacomodinardo@gmail.com", 345678912);
Utente u2 = new Utente("Perini", "Fabiano", "perinifabiano@gmail.com", 345125478);
Utente u3 = new Utente("Casentini", "Daniel", "daniel.casentini@gmail.com", 347458963);

List<Utente> utenti = new List<Utente>();

utenti.Add(u1);
utenti.Add(u2);
utenti.Add(u3);

Console.WriteLine("Inserisci titolo da ricercare: ");
string docCercato = Console.ReadLine();

foreach (Documento item in documenti)
{
    if (item.Titolo == docCercato)
    {
        if (item.Stato == true)
        {
            Console.WriteLine("L'articolo {0} è presente in libreria al settore {1}, scaffale {2}", item.Titolo, item.Settore, item.Scaffale);
            break;
        }
        else
        {
            Console.WriteLine("L'articolo {0} è attualmente in prestito.", item.Titolo);
            break;
        }
    }
    else
    {
        Console.WriteLine("L'articolo {0} non è presente.", docCercato);
        break;
    }

}
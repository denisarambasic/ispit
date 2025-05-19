using Ispit.Model;
using System.Globalization;

namespace Ispit.Konzola;

public class Program
{
    static void Main(string[] args)
    {
        var ucenici = new List<Ucenik>();

        for (int i = 1; i <= 3; i++)
        {
            var ucenik = new Ucenik();

            Console.WriteLine($"Unesite Ime {i}. ucenika: ");
            ucenik.Ime = Console.ReadLine();

            Console.WriteLine($"Unesite Prezime {i}. ucenika: ");
            ucenik.Prezime = Console.ReadLine();

            Console.WriteLine($"Unesite Datum rođenja {i}. ucenika (u format-u: dd.mm.YYYY): ");
            var datumRodjenja = Console.ReadLine();

            //Parsiranje Dana/Mjeseca/Godine iz datog stringa
            string[] formats = { "d.M.yyyy", "dd.MM.yyyy", "d.MM.yyyy", "dd.M.yyyy" };
            DateTime date = DateTime.ParseExact(datumRodjenja, formats, CultureInfo.InvariantCulture);
            int dan = date.Day;
            int mjesec = date.Month;
            int godina = date.Year;

            //Setiranje Parsiranog datuma rođenja
            ucenik.DatumRodjenja = new DateTime(godina, mjesec, dan);

            Console.WriteLine($"Unesite Prosjek {i}. ucenika: ");
            ucenik.Prosjek = Double.Parse(Console.ReadLine());

            //Dodaj ucenika u listu
            ucenici.Add(ucenik);
        }

        foreach (var ucenik in ucenici)
        {
            Console.WriteLine("==================");
            Console.WriteLine(ucenik);
            Console.WriteLine("==================");
        }
            
    }
}

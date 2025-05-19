namespace Ispit.Model;

public class Ucenik
{
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public DateTime DatumRodjenja { get; set; }
    public double Prosjek { get; set; }

    //Vraća koliko imamo godina u odnosu na trenutni datum
    public int Starost()
    {
        DateTime today = DateTime.Today;

        int godineStarosti = today.Year - DatumRodjenja.Year;

        // Ako je mjesec rođenja isti kao trenutni mjesec onda po danu gledamo da li smo imali rođendan već
        // Ako nismo moramo smanjiti jednu godinu
        if (DatumRodjenja.Month == today.Month)
        {
            if (DatumRodjenja.Day > today.Day)
            {
                godineStarosti--;
            }
        }

        //Ako je mjesec rođenja u ovoj godini još uvijek veci od mjeseca trenutno, onda moramo smanjiti godinu,
        // jer još nismo imali rođendan u ovoj godini
        if (DatumRodjenja.Month > today.Month)
        {
            godineStarosti--;
        }

        return godineStarosti;
    }

    public string IspisProsjeka()
    {
        if (Prosjek >= 1.0 && Prosjek <= 1.49)
        {
            return "nedovoljan";
        }
        else if (Prosjek >= 1.5 && Prosjek <= 2.49)
        {
            return "dovoljan";
        }
        else if (Prosjek >= 2.5 && Prosjek <= 3.49)
        {
            return "dobar";
        }
        else if (Prosjek >= 3.5 && Prosjek <= 4.49)
        {
            return "vrlo dobar";
        }
        else
        {
            return "odličan";
        }
    }

    public override string ToString()
    {
        return $"Ime: {Ime}\nPrezime: {Prezime}\nGodine starosti: {Starost()}\nProsjek: {IspisProsjeka()}";
    }
}

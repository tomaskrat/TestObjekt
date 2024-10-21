public class Osoba
{
    public Osoba()
    {

    }

    public Osoba(string jmeno, string prijmeni)
    {
        Jmeno = jmeno;
        Prijmeni = prijmeni;
    }


    public string Jmeno { get; set; }

    public string Prijmeni { get; set; }

    public string CeleJmeno => $"{Jmeno} {Prijmeni}";

    public string CeleJmeno2
    {
        get
        {
            return $"{Jmeno} {Prijmeni}";
        }
    }
    
    public string CeleJmeno3()
    {
        return $"{Jmeno} {Prijmeni}";
    }

    public override string ToString()
    {
        return $"{Jmeno} {Prijmeni}";
    }
}

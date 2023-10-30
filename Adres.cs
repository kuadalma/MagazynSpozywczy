namespace MagazynSpozywczy
{
    internal class Adres
    {
        // Właściwości klasy Adres
        public string Ulica { get; set; }
        public string KodPocztowy { get; set; }
        public string Miejscowosc { get; set; }
        public string NumerPosesji { get; set; }
        public string NumerLokalu { get; set; }

        // Konstruktor klasy Adres, inicjalizuje właściwości na podstawie podanych danych
        public Adres(string ulica, string numerDomu, string kodPocztowy, string miasto, string kraj)
        {
            Ulica = ulica;
            NumerPosesji = numerDomu;
            KodPocztowy = kodPocztowy;
            Miejscowosc = miasto;
            NumerLokalu = kraj;
        }

        // Metoda do edycji adresu
        public void Edit()
        {
            string tmp;
            Console.Clear();
            Console.WriteLine($"Podaj nową ulicę: ");
            tmp = Console.ReadLine();
            if (tmp.Length == null) Ulica = tmp;
            Console.WriteLine("Podaj nowy numer posesji: ");
            tmp = Console.ReadLine();
            if (tmp.Length == null) NumerPosesji = tmp;
            Console.WriteLine("Podaj nowy kod pocztowy: ");
            tmp = Console.ReadLine();
            if (tmp.Length == null) KodPocztowy = tmp;
            Console.WriteLine("Podaj nową miejscowość: ");
            tmp = Console.ReadLine();
            if (tmp.Length == null) Miejscowosc = tmp;
            Console.WriteLine("Podaj nowy numer lokalu: ");
            tmp = Console.ReadLine();
            if (tmp.Length == null) NumerLokalu = tmp;
            Console.Clear();
            Console.WriteLine("Zmieniono adres na: ");
            Console.WriteLine(ToString()); // Wyświetla zaktualizowane informacje o produkcie
        }

        // Przesłonięcie metody ToString do dostarczenia reprezentacji tekstowej produktu
        public override string ToString()
        {
            return $"{Ulica} {NumerPosesji}, {KodPocztowy} {Miejscowosc}, {NumerLokalu}";
        }
    }
}

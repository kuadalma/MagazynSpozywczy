namespace MagazynSpozywczy
{
    internal class Produkt
    {
        // Właściwości klasy Produkt
        public string Nazwa { get; set; }
        public string Producent { get; set; }
        public string Kategoria { get; set; }
        public string KodKreskowy { get; set; }
        public string Cena { get; set; }
        public string Opis { get; set; }

        // Konstruktor klasy Produkt, inicjalizuje właściwości na podstawie podanych danych
        public Produkt(string nazwa, string producent, string kategoria, string cena, string opis)
        {
            Nazwa = nazwa;
            Producent = producent;
            Kategoria = kategoria;
            Cena = cena;
            Opis = opis;
            GenerateCode(); // Generuje losowy kod kreskowy podczas tworzenia produktu
        }

        // Metoda do generowania losowego kodu kreskowego
        public void GenerateCode()
        {
            Random rnd = new Random();
            int tmp = rnd.Next(100000000, 999999999);
            KodKreskowy = tmp.ToString();
        }

        // Metoda do edycji właściwości produktu
        public void Edit()
        {
            string tmp;
            Console.Clear();
            Console.WriteLine($"Podaj nową nazwę: ");
            tmp = Console.ReadLine();
            if (tmp.Length != null) Nazwa = tmp;
            Console.WriteLine("Podaj nowego producenta: ");
            tmp = Console.ReadLine();
            if (tmp.Length != null) Producent = tmp;
            Console.WriteLine("Podaj nową kategorię: ");
            tmp = Console.ReadLine();
            if (tmp.Length != null) Kategoria = tmp;
            Console.WriteLine("Podaj nowy kod kreskowy: ");
            if (Console.ReadLine() != null) GenerateCode();
            tmp = Console.ReadLine();
            if (tmp.Length != null) Cena = tmp;
            Console.WriteLine("Podaj nowy opis: ");
            tmp = Console.ReadLine();
            if (tmp.Length != null) Opis = tmp;
            Console.Clear();
            Console.WriteLine("Zmieniono produkt na: ");
            Console.WriteLine(ToString()); // Wyświetla zaktualizowane informacje o produkcie
        }

        // Przesłonięcie metody ToString do dostarczenia reprezentacji tekstowej produktu
        public override string ToString() 
        {
            return $"{Nazwa} {Producent} {Kategoria} {KodKreskowy} {Cena} {Opis}";
        }
    }
}

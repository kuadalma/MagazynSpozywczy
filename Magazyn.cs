namespace MagazynSpozywczy
{
    internal class Magazyn
    {
        private IList<Produkt> Produkty;
        private Adres Adres;

        public Magazyn(Adres adres)
        {
            Adres = adres;
            Produkty = new List<Produkt>();
        }
        public Magazyn(Adres adres, IList<Produkt> produkty)
        {
            Adres = adres;
            Produkty = produkty;
        }

        //dodaj produkt
        public void DodajProdukt()
        {
            Console.WriteLine("Podaj nazwę produktu: ");
            string nazwa = Console.ReadLine();
            Console.WriteLine("Podaj producenta: ");
            string producent = Console.ReadLine();
            Console.WriteLine("Podaj kategorię: ");
            string kategoria = Console.ReadLine();
            Console.WriteLine("Podaj cenę: ");
            string cena = Console.ReadLine();
            Console.WriteLine("Podaj opis: ");
            string opis = Console.ReadLine();
            Produkty.Add(new Produkt(nazwa, producent, kategoria, cena, opis));
        }   
        public void DodajProdukt(string nazwa, string producent, string kategoria, string cena, string opis)
        {
            Produkty.Add(new Produkt(nazwa, producent, kategoria, cena, opis));
        }
        public void DodajProdukt(Produkt produkt)
        {
            Produkty.Add(produkt);
        }

        //usuń produkt
        public void UsunProdukt()
        {
            Console.WriteLine("Podaj nazwę produktu do usunięcia: ");
            string nazwa = Console.ReadLine();
            Produkty.Remove(Produkty.First(x => x.Nazwa == nazwa));
        }
        public void UsunProdukt(string nazwa)
        {
            Produkty.Remove(Produkty.First(x => x.Nazwa == nazwa));
        }
        public void usunProdukt(string nazwa, string producent, string kategoria, string cena, string opis)
        {
            Produkty.Remove(Produkty.First(x => x.Nazwa == nazwa && x.Producent == producent && x.Kategoria == kategoria && x.Cena == cena && x.Opis == opis));
        }
        public void UsunProdukt(Produkt produkt)
        {
            Produkty.Remove(produkt);
        }

        //edytuj produkt
        public void EditProdukt()
        {
            Console.WriteLine("Podaj nazwę produktu do edycji: ");
            string nazwa = Console.ReadLine();
            Produkty.First(x => x.Nazwa == nazwa).Edit();
        }
        public void EditProdukt(string nazwa)
        {
            Produkty.First(x => x.Nazwa == nazwa).Edit();
        }
        public void EditProdukt(string nazwa, string producent, string kategoria, string cena, string opis)
        {
            Produkty.First(x => x.Nazwa == nazwa && x.Producent == producent && x.Kategoria == kategoria && x.Cena == cena && x.Opis == opis).Edit();
        }
        public void EditProdukt(Produkt produkt)
        {
            produkt.Edit();
        }

        //edytuj adres
        public void EditAdres()
        {
            Adres.Edit();
        }

        //wyswietl produkty
        public void WyswietlProdukty()
        {
            string res = "";
            for (int i = 0; i < Produkty.Count(); i++)
            {
                res += Produkty[i].ToString() + '\n';
            }
            Console.WriteLine(res);
        }
        public void WyswietlProdukty(Func<Produkt, bool> func)
        {
            string res = "";
            for (int i = 0; i < Produkty.Count(); i++)
            {
                if (func(Produkty[i]))
                {
                    res += Produkty[i].ToString() + '\n';
                }
            }
            Console.WriteLine(res);
        }
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < Produkty.Count(); i++)
            {
                res += Produkty[i].ToString() + '\n';
            }
            return "Magazyn: " + Adres.ToString() + '\n' + res;
        }

        public int Count()
        {
            return Produkty.Count();
        }
    }
}

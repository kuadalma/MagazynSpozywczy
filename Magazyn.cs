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

        public void DodajProdukt(Produkt produkt)
        {
            Produkty.Add(produkt);
        }
        public void UsunProdukt(Produkt produkt)
        {
            Produkty.Remove(produkt);
        }
        public void EditAdres()
        {
            Adres.Edit();
        }
        public void EditProdukt(string nazwa)
        {
            Produkty.First(x => x.Nazwa == nazwa).Edit();
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
    }
}

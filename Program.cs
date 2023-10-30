using MagazynSpozywczy;

Magazyn magazyn1 = new Magazyn(new Adres("zielona", "26a", "42-290", "włocławek", "polska"));
Magazyn magazyn2 = new Magazyn(new Adres("czarna", "25/6", "28-920", "wadowice", "polska"));
magazyn1.DodajProdukt(new Produkt("Mleko", "mlekovita", "nabiał", "2,5", "mleko 2%"));
magazyn1.DodajProdukt(new Produkt("Chleb", "piekarnia", "pieczywo", "3", "chleb żytni"));
magazyn2.DodajProdukt(new Produkt("Jajka", "wiejskie", "nabiał", "3,5", "jajka z wolnego wybiegu"));
Console.WriteLine(magazyn1.ToString());
Console.WriteLine(magazyn2.ToString());
Console.WriteLine("Edytowanie adresu magazynu 2");
magazyn2.EditAdres();
//Console.WriteLine(magazyn2.ToString());
//Console.WriteLine("Edytowanie produktu 1 w magazynie 1");
//magazyn1.EditProdukt("Mleko");
//Console.WriteLine(magazyn1.ToString());
//Console.WriteLine("Usuniecie produktu 2 z magazynu 1");
//magazyn1.UsunProdukt(produkt2);
//Console.WriteLine(magazyn1.ToString());
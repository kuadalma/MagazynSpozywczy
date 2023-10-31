using MagazynSpozywczy;

//test start
//Magazyn magazyn = new Magazyn(new Adres("ul. Główna", "12", "32-100", "Proszowice", "Polska"));
//magazyn.DodajProdukt(new Produkt("Mleko", "Mlekowita", "Nabiał", "2,50", "1l"));
//magazyn.DodajProdukt(new Produkt("Chleb", "Słoneczko", "Pieczywo", "2,00", "1szt"));
//magazyn.DodajProdukt(new Produkt("Woda", "Muszynianka", "Napoje", "1,50", "1l"));
//magazyn.DodajProdukt(new Produkt("Ser", "Mlekowita", "Nabiał", "3,50", "1kg"));
//magazyn.DodajProdukt(new Produkt("Kiełbasa", "Koło", "Mięso", "6,50", "1kg"));
//magazyn.DodajProdukt(new Produkt("Papryka", "Babcia", "Warzywa", "4,50", "1kg"));
//magazyn.DodajProdukt(new Produkt("Pomidor", "Babcia", "Warzywa", "5,50", "1kg"));
//magazyn.DodajProdukt(new Produkt("Jabłko", "Babcia", "Owoce", "2,50", "1kg"));
//magazyn.DodajProdukt(new Produkt("Jogurt", "Mlekowita", "Nabiał", "1,50", "1szt"));
//magazyn.DodajProdukt(new Produkt("Jogurt", "Mlekowita", "Nabiał", "1,50", "1szt"));
//magazyn.DodajProdukt(new Produkt("Jogurt", "Mlekowita", "Nabiał", "1,50", "1szt"));
//magazyn.UsunProdukt("Jogurt");
//magazyn.UsunProdukt();
//magazyn.UsunProdukt(new Produkt("Mleko", "Mlekowita", "Nabiał", "2,50", "1l"));
//magazyn.EditProdukt("Mleko", "Mlekowita", "Nabiał", "2,50", "1l");
//magazyn.EditProdukt(new Produkt("Mleko", "Mlekowita", "Nabiał", "2,50", "1l"));
//magazyn.EditProdukt();
//magazyn.WyswietlProdukty(x => x.Nazwa == "Mleko");

//Console.WriteLine(magazyn.ToString());
//test end


List<Magazyn> magazyny = new();
while(true)
{
    int index;
    Console.Clear();
    Console.WriteLine("1. Dodaj magazyn");
    Console.WriteLine("2. Edytuj magazyn");
    Console.WriteLine("3. Usuń magazyn");
    Console.WriteLine("4. Wyświetl magazyny");
    Console.WriteLine("0. Wyjście");
    Console.Write("Wybór: ");
    string choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":
            Console.Write("Podaj ulice: ");
            string ulica = Console.ReadLine();
            Console.Write("Podaj numer posesji: ");
            string numerPosesji = Console.ReadLine();
            Console.Write("Podaj kod pocztowy: ");
            string kodPocztowy = Console.ReadLine();
            Console.Write("Podaj miejscowość: ");
            string miejscowosc = Console.ReadLine();
            Console.Write("Podaj kraj: ");
            string kraj = Console.ReadLine();
            magazyny.Add( new Magazyn(new Adres(ulica, numerPosesji, kodPocztowy, miejscowosc, kraj)));
            Console.WriteLine("Dodano magazyn");
            break;
        case "2":
            if (magazyny.Count == 0) break;
            DisplayStorage();
            Console.WriteLine("Podaj index magazynu: ");
            while (true)
            {
                index = int.Parse(Console.ReadLine());
                if (index < magazyny.Count) break;
                Console.WriteLine("Błędny index");
            }

            while (true)
            {
                bool breakFlag = false;
                Console.Clear();
                Console.WriteLine("1. Edytuj Adres");
                Console.WriteLine("2. dodaj produkt");
                Console.WriteLine("3. Edytuj produkt");
                Console.WriteLine("4. Usuń produkt");
                Console.WriteLine("5. Wyświetl magazyn");
                Console.WriteLine("0. Wyjście");
                Console.Write("Wybór: ");
                choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("1. Edytuj Adres");
                        magazyny[index].EditAdres();
                        break;
                    case "2":
                        Console.WriteLine("2. dodaj produkt");
                        magazyny[index].DodajProdukt();
                        break;
                    case "3":
                        if (magazyny[index].Count() == 0) break;
                        magazyny[index].WyswietlProdukty();
                        Console.WriteLine("3. Edytuj produkt");
                        magazyny[index].EditProdukt();
                        break;
                    case "4":
                        if (magazyny[index].Count() == 0) break;
                        magazyny[index].WyswietlProdukty();
                        Console.WriteLine("4. Usuń produkt");
                        magazyny[index].UsunProdukt();
                        break;
                    case "5":
                        Console.WriteLine("5. Wyświetl magazyn");
                        Console.WriteLine(magazyny[index].ToString());
                        break;
                    case "0":
                        breakFlag = true;
                        break;
                    default:
                        Console.WriteLine("Błędny wybór");
                        break;
                }
                if (breakFlag) break;
                Console.WriteLine("Wciśnij dowolny klawisz, aby kontynuować...");
                Console.ReadKey();
            }
            break;
        case "3":
            if (magazyny.Count == 0) break;
            DisplayStorage();
            Console.WriteLine("Podaj index magazynu: ");
            while (true)
            {
                index = int.Parse(Console.ReadLine());
                if (index < magazyny.Count) break;
                Console.WriteLine("Błędny index");
            }
            magazyny.RemoveAt(index);
            break;
        case "4":
            DisplayStorage();
            break;
        case "0":
            return;
        default:
            Console.WriteLine("Błędny wybór");
            break;
    }
    Console.WriteLine("Wciśnij dowolny klawisz, aby kontynuować...");
    Console.ReadKey();
}

void DisplayStorage()
{
    for (int i = 0; i < magazyny.Count; i++)
    {
        Console.WriteLine($"{i}. {magazyny[i].ToString()}");
    }
}

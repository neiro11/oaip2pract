using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Hotel
    {
        public string name_hotel;
        public int numStar;
        public string descr;
        public Country loc;
        public List<Hotel> massiveHotel = new List<Hotel>();
        public Hotel(string Name, int NumStar, string Description, Country loc)
        {
            name_hotel = Name;
            numStar = NumStar;
            descr = Description;
            this.loc = loc;
        }
        public void Second(List<Hotel> massivehotel, List<Country> massiveCountry)
        {
            string name_hotel, descr, loc;
            int numStar;
            Country selectedcountry = null;
            Console.Write("Введите название отеля: ");
            name_hotel = Console.ReadLine();
            Console.Write("Введите количество звезд: ");
            numStar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите краткое описание: ");
            descr = Console.ReadLine();
            Console.Write("Введите страну где находится отель: ");
            loc = Console.ReadLine();
            foreach (Country c in massiveCountry)
            {
                    if (loc == c.name)
                    {
                        selectedcountry = c;
                        goto label;
                    }
                
            }
            return;
            label:
            massiveHotel.Add(new Hotel(name_hotel, numStar, descr, selectedcountry));

        }
        public void Third()
        {
            foreach (Hotel c in massiveHotel)
            {
                Console.Write(c.name_hotel + " ");
                Console.Write(c.numStar + " ");
                Console.Write(c.descr + " ");
                Console.Write(c.loc.name);
                Console.WriteLine("");
            }
        }
        public Hotel() { }
    }


    class Country
    {
        public string name;
        public string stolitsa;
        static public List<Country> massiveCountry = new List<Country>() { new Country("Россия", "Москва"), new Country("США", "Вашингтон") };

        public Country(string Name, string Stol)
        {
            name = Name;
            stolitsa = Stol;
        }
        public void First()
        {
            string name, stolitsa;
            Console.Write("Введите название страны: ");
            name = Console.ReadLine();
            Console.Write("Введите название столицы: ");
            stolitsa = Console.ReadLine();
            massiveCountry.Add(new Country(name, stolitsa)); // массив
        }
        public void Fourth()
        {
            foreach (Country c in massiveCountry)
            {
                Console.Write(c.name + " ");
                Console.Write(c.stolitsa);
                Console.WriteLine("");
            }
        }
        public Country() { }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Hotel hotel = new Hotel();
            Country country = new Country();

            int N = 0;
            while (N != 5)
            {
                Console.WriteLine("Выберите действие");
                Console.WriteLine("1) Добавление страны");
                Console.WriteLine("2) Добавление отеля");
                Console.WriteLine("3) Вывод всех отелей");
                Console.WriteLine("4) Вывод всех стран");
                Console.WriteLine("5) Выход из программы");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n == 1)
                {
                    country.First();
                    continue;
                }
                if (n == 2)
                {
                    hotel.Second(hotel.massiveHotel, Country.massiveCountry);
                    continue;
                }
                if (n == 3)
                {
                    hotel.Third();
                    continue;
                }
                if (n == 4)
                {
                    country.Fourth();
                    continue;
                }
                else
                {
                    break;
                }

            }
        }
    }
}
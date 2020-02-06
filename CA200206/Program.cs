using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200206
{
    struct Str
    {
        public string Nev;
        public int Elo;
    }

    class Program
    {
        static void Main()
        {
            OraEleje();
            Console.ReadKey();
        }

        private static void OraEleje()
        {
            var osztalyok = new Dictionary<string, int>();

            osztalyok.Add("9a", 30);
            osztalyok.Add("9b", 24);
            osztalyok.Add("10a", 26);
            osztalyok.Add("11a", 30);
            osztalyok.Add("11b", 30);
            Console.WriteLine(osztalyok["10a"]); //26
            osztalyok["11a"] -= 2;
            Console.WriteLine(osztalyok["11a"]); //28


            foreach (KeyValuePair<string, int> o in osztalyok)
            {
                Console.WriteLine($"A {o.Key} osztályba {o.Value} tanuló jár");
            }

            foreach (var o in osztalyok)
            {
                Console.WriteLine(o);
            }

            if (osztalyok.ContainsKey("12a")) Console.WriteLine("VAN 12a osztály");
            else Console.WriteLine("NINCS 12a osztály");

            if (osztalyok.ContainsValue(30))
                Console.WriteLine("VAN 30 fős osztály");
            else
                Console.WriteLine("NINCS 30 fős osztály");


            //var rend = osztalyok.OrderBy(x => x.Value);
            //foreach (var o in rend) Console.WriteLine(o);

            for (int i = 0; i < osztalyok.Count; i++)
            {
                Console.WriteLine(osztalyok.ElementAt(i).Key);
            }

            var dolgozok = new List<Str>()
            {
                new Str(){ Nev = "Béla1", Elo = 20 },
                new Str(){ Nev = "Béla2", Elo = 30 },
                new Str(){ Nev = "Béla3", Elo = 30 },
                new Str(){ Nev = "Béla4", Elo = 30 },
                new Str(){ Nev = "Béla5", Elo = 70 },
                new Str(){ Nev = "Béla6", Elo = 20 },
                new Str(){ Nev = "Béla7", Elo = 70 },
                new Str(){ Nev = "Béla8", Elo = 20 },
                new Str(){ Nev = "Béla9", Elo = 30 },
            };


            var dic = new Dictionary<int, int>();

            foreach (var d in dolgozok)
            {
                if (!dic.ContainsKey(d.Elo))
                {
                    dic.Add(d.Elo, 1);
                }
                else dic[d.Elo]++;
            }

            foreach (var e in dic)
            {
                Console.WriteLine($"Előhívó: {e.Key} | db: {e.Value}");
            }
        }
    }
}

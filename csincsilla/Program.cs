using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csincsilla
{
    class Program
    {
        static void Main()
        {
            //első feladat();
            Lakcim();
            //második feladat();
            Nevek();
            //harmadik feladat();
            Fizetes();
            //negyedik feladat();
            Euro();
            //ötödik feladat();
            Teglalap_ker_ter();
            //hatodik feladat();
            Kor_ker_ter();
            //hetedik feladat();
            Pitagorasz();
            //nyolcadik feladat();
            Atlagsebesseg();
            //kilencedik feladat();
            Uzemanyag();
            //Tizedik feladat();
            Testtomegindex();

            Console.ReadKey();
        }

        static void Lakcim()
        {
            //pl. 1042 Budapest Tanoda tér 42.

            Console.Write("iránytószám: ");
            string iranyitoszam = Console.ReadLine();
            Console.Write("település: ");
            string telepules = Console.ReadLine();
            Console.Write("közterület neve: ");
            string kozteruletneve = Console.ReadLine();
            Console.Write("közterület jellege: ");
            string kozteruletjellege = Console.ReadLine();
            Console.Write("házszám: ");
            string hazszam = Console.ReadLine();

            Console.WriteLine(iranyitoszam + " " + telepules + " " + kozteruletneve + " " + kozteruletjellege + " " + hazszam + ".");
            //Console.WriteLine("{0} {1} {2} {3} {4}.", iranyitoszam, telepules, kozteruletneve, kozteruletjellege, hazszam);
            //Console.WriteLine($"{iranyitoszam} {telepules} {kozteruletneve} {kozteruletjellege} {hazszam}.");
        }

        static void Nevek()
        {
            //pl. Lópici Gáspár, Zöld Piroska

            Console.Write("vezetéknév1: ");
            string veznev1 = Console.ReadLine();
            Console.Write("keresztnev1: ");
            string ksztnev1 = Console.ReadLine();
            Console.Write("vezetéknév2: ");
            string veznev2 = Console.ReadLine();
            Console.Write("keresztnev2: ");
            string ksztnev2 = Console.ReadLine();

            Console.WriteLine(veznev1 + " " + ksztnev1);
            Console.WriteLine(veznev2 + " " + ksztnev1);
            Console.WriteLine(veznev2 + " " + ksztnev2);
            Console.WriteLine(veznev1 + " " + ksztnev2);

        }

        static void Fizetes()
        {
            Console.Write("Havi fizetés: ");

            int havi = int.Parse(Console.ReadLine());

            int eves = havi * 12;

            Console.WriteLine($"éves fizetés: {eves}");        
        }
        static void Euro()
        {
            Console.Write("Euro árfolyama: ");
            float arfolyam = float.Parse(Console.ReadLine());

            Console.Write("Átváltandó Euro: ");
            int Euro = int.Parse(Console.ReadLine());

            Console.Write("Átváltott Euro Forintban: ");

            float forint = arfolyam * Euro;

            Console.WriteLine($" {forint} ");
        }
        static void Teglalap_ker_ter()
        {
            Console.Write("a oldal: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b oldal: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"A téglalap kerülete: {2 * (a + b)}, területe: {a * b}");
        }
        static void Kor_ker_ter()
        {
            Console.Write("sugár: ");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A kör területe {2 * r * 3.14}, a kerülete {r * r * 3.14}");
        }
        static void Pitagorasz()
        {
            Console.Write("befogó1: ");
            int befogo1 = int.Parse(Console.ReadLine());

            Console.Write("befogó2: ");
            int befogo2 = int.Parse(Console.ReadLine());

            Console.Write("átfogó: ");
            var atfogo = Math.Sqrt((befogo1 * befogo1) + Math.Pow(befogo2, 2));

            Console.WriteLine($"Az átfogó hossza {atfogo}");
        }
        static void Atlagsebesseg()
        {
            Console.Write("megtett út hossza (km): ");
            int ut = int.Parse(Console.ReadLine());

            Console.Write("eltelt idő (h): ");
            int ido = int.Parse(Console.ReadLine());

            Console.WriteLine($"Az átlagsebesség {ut / ido} km/h");
        }
        static void Uzemanyag()
        {
            Console.Write("fogyasztás (liter/100 km): ");
            int fogyasztas = int.Parse(Console.ReadLine());

            Console.Write("benzin ára (Ft/liter): ");
            int uzemanyagar = int.Parse(Console.ReadLine());

            Console.Write("megteendő út hossza (km): ");
            int uthossz = int.Parse(Console.ReadLine());

            Console.WriteLine($"Az útiköltség {(uthossz * fogyasztas * uzemanyagar) / 100} Ft");
        }
        static void Testtomegindex()
        {
            Console.Write("Súly (kg): ");
            double tomeg = double.Parse(Console.ReadLine());

            Console.Write("Magasság (m): ");
            double magassag = double.Parse(Console.ReadLine());

            Console.WriteLine($"Az illető testtomegindexe (TTI) {tomeg / Math.Pow(magassag, 2)}");


        }
    }
    
}
            


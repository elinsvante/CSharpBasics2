// Labb 2 vecka 45
// Elin Svantesson
// Version 1.0 2017-11-09

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SvantessonElin_Laboration2
{
    class Program
    {
        static void Main(string[] args)
        {
            SvantessonElin_Laboration2.Lab2 lab = new SvantessonElin_Laboration2.Lab2();

            //Uppgift 2.1 Multiplikationstabellen
            int[] resultat1 = lab.CalculateMultTable(5);
            Console.WriteLine("Uppgift 2.1 Multiplikationstabellen: " + resultat1);
            Console.WriteLine();

            //Uppgift 2.2 PrettyPrint
            Console.Write("Uppgift 2.2 PrettyPrint: ");
            lab.PrettyPrint(resultat1);
            Console.WriteLine();

            //Uppgift 2.4 CopyTo
            int[] arr1 = new int[3] { 1, 2, 3 };
            int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };

            // Uppgift 2.6 Concat         
            int[] resultat2 = lab.Concat(arr1, arr2);
            Console.WriteLine("Uppgift 2.6 Concat: " + resultat2);
            Console.WriteLine();

            //Uppgift 2.8 Räkna ord
            int resultat3 = lab.WordCount("Hej! Jag heter Elin Svantesson.");
            Console.WriteLine("Uppgift 2.8 Räkna Ord: (Hej. Jag heter Elin Svantesson): " + resultat3);
            Console.WriteLine();

            //Uppgift 2.10 Palindrom
            bool resultat4 = lab.IsPalindrome("Sirap i Paris");
            Console.WriteLine("Uppgift 2.10 Palindrom (Sirap i Paris): " + resultat4);
            Console.WriteLine();

            //Uppgift 2.12 Gunde i Trubbel
            string resultat5 = lab.GundeITrubbel("*Hello( Vad gör du_ Idag *Måndag(");
            Console.WriteLine("Uppgift 2.12 Gunde i Trubbel: (*Hello( Vad gör du_ Idag *Måndag( ): " + resultat5);


            Console.ReadLine();
        }
    }
}

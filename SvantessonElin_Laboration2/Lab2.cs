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
    class Lab2
    {
        /// <summary>
        /// Metoden tar emot en integer som argument, och multiplicerar denna med alla tal mellan 1-10.
        /// </summary>
        /// <param name="faktor"></param>
        /// <returns> Returnerar en array av integers som varje element är en produkt av ett tal mellan 1-10 och argumentet. </returns>
        public int[] CalculateMultTable(int faktor)
        {
            int[] multiTable = new int[10];

            for (int i = 0; i < 10; i++)
            {
                multiTable[i] = faktor * (i + 1);
            }

            return multiTable;
        }
 
        /// <summary> PrettyPrint
        /// Metoden tar emot en array av integers som argument, och skriver ut den som en sträng med ", " mellan arje varje element och inte på det sista talet.
        /// </summary>
        /// <param name="multiTable"></param>
        /// <return> Metoden returnerar ingenting. </return>
        public void PrettyPrint(int[] multiTable)
        {
            for (int i = 0; i < multiTable.Length; i++)
                if (i == multiTable.Length - 1)
                {
                    Console.WriteLine(multiTable[i]);
                }
                else
                {
                    Console.Write(multiTable[i] + ", ");
                }
        }

        /// <summary> CopyTo
        /// Metoden tar två arrayer av heltal och en integer som argument, och kopierar alla värden från den första arrayen till den andra. Integern som tas emot definierar det index i den andra arrayen som kopieringen ska börja vid.
        /// </summary>
        /// <param name="arr1"></param>
        /// <param name="arr2"></param>
        /// <param name="start"></param>
        /// /// <return> Metoden returnerar ingenting. </return>
        public void CopyTo(int[] arr1, int[] arr2, int start)
        {

            int j = 0;

            if (arr2.Length > arr1.Length && start + arr1.Length < arr2.Length)
            {

                for (int i = start; i < arr1.Length; i++)
                {
                    arr2[i] = arr1[j];
                    j++;
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }

        }


        /// <summary> Concat
        /// Metoden tar två arrayer av heltal som argument som slår samman dem.
        /// </summary>
        /// <param name="talFöljd1"></param>
        /// <param name="talFöljd2"></param>
        /// <returns> En array som är resultatet av att slå samman de båda input-arrayerna. </returns>
        public int[] Concat(int[] talFöljd1, int[] talFöljd2)
        {
            int[] ihopsatta = new int[talFöljd1.Length + talFöljd2.Length];
            int i2 = 0;
            int i3 = 0;

            for (int i = 0; i < talFöljd1.Length; i++)
            {
                ihopsatta[i] = talFöljd1[i2];
                i2++;
            }
            for (int i = talFöljd1.Length; i < ihopsatta.Length; i++)
            {
                ihopsatta[i] = talFöljd2[i3];
                i3++;
            }

            return ihopsatta;
        }

        /// <summary> WordCount
        /// Metoden tar emot en sträng som argument, och räknar ut hur många ord som finns i strängen. Ignorerar skiljetecken som t.ex "." "," "!" osv.
        /// </summary>
        /// <param name="strängMedOrd"></param>
        /// <returns>Returnerar ett tal vars värde är antalet ord i input-strängen.</returns>
        public int WordCount(string strängMedOrd)
        {
            string[] splittadeOrd = strängMedOrd.Split(' ');
            int split2Längd = splittadeOrd.Length;

            return split2Längd;
        }


        /// <summary> Palindrom
        /// Metoden tar en sträng som argument och räknar ut som strängen är en palindrom eller inte.
        /// </summary>
        /// <param name="ord"></param>
        /// <returns>Returnerar sant eller falskt beroende på om strängen är en palindrom eller inte. </returns>
        public bool IsPalindrome(string ord)
        {
            string baklänges = "";

            for (int i = ord.Length - 1; i >= 0; i--)
            {
                baklänges = baklänges + ord.Substring(i, 1);
            }

            string BAKLÄNGES = baklänges.ToUpper();
            string ORD = ord.ToUpper();

            if (BAKLÄNGES == ORD)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        /// <summary> Gunde i Trubbel
        /// Metoden tar en sträng som argument och om ett tecken är *,( eller _ utför metoden ett teckenbyte på dessa.
        /// </summary>
        /// <param name="sträng"></param>
        /// <returns>Returnerar den inkommande strängen fast med teckenbyten. </returns>
        public string GundeITrubbel(string sträng)
        {
            char[] tecken = sträng.ToCharArray();

            for (int i = 0; i < tecken.Length; i++)
            {
                if (tecken[i] == '*')
                {
                    tecken[i] = '(';
                }
                else if (tecken[i] == '(')
                {
                    tecken[i] = ')';
                }
                else if (tecken[i] == '_')
                {
                    tecken[i] = '?';
                }

            }

            sträng = new string(tecken);
            return sträng;
        }
    }
}

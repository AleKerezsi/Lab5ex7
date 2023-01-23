using System;

namespace Lab5ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex 7 Scrieti un program care va citi doua siruri de caractere de la tastatura si verifica daca cele doua siruri de caractere sunt anagrame */

            Console.WriteLine("Introduceti primul sir de caractere=  ");
            string sir1 = Console.ReadLine();

            if (string.IsNullOrEmpty(sir1) || string.IsNullOrWhiteSpace(sir1))
            {
                Console.WriteLine("Nu ai introdus nimic, sau ai introdus spatiu gol. Ruleaza din nou programul.");
                return;
            }

            Console.WriteLine("Introduceti al doilea sir de caractere=  ");
            string sir2 = Console.ReadLine();

            if (string.IsNullOrEmpty(sir2) || string.IsNullOrWhiteSpace(sir2))
            {
                Console.WriteLine("Nu ai introdus nimic, sau ai introdus spatiu gol. Ruleaza din nou programul.");
                return;
            }

            if (sir1.Length != sir2.Length)
            {
                Console.WriteLine("Sirurile nu sunt anagrame deoarece au dimensiuni diferite");
            }

            bool anagrame = DeterminaDacaSirurileSuntAnagrame(sir1, sir2);

            if (anagrame == true) Console.WriteLine("Cele doua siruri sunt anagrame. ");
            else Console.WriteLine("Cele doua siruri nu sunt anagrame. ");

            Console.ReadLine();
        }

        public static bool DeterminaDacaSirurileSuntAnagrame(string sir1, string sir2) 
        {
            bool rezultat = true; 

            for (int i = 0; i < sir1.Length; i++) 
            {
                if (!sir2.Contains(sir1[i])) rezultat = false;
            }

            for (int i = 0; i < sir2.Length; i++)
            {
                if (!sir1.Contains(sir2[i])) rezultat = false;
            }

            return rezultat;
        }
    }
}

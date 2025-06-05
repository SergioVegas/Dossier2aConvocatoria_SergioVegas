using Dossier2aConvocatoria_SergioVegas.Tools;
using System;

namespace Dossier2aConvocatoria_SergioVegas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Exercici6();
        }
        // 5.  Implementa un programa que retorni per pantalla el factorial d’un número introduït per teclat i si aquest és primer o no (de manera iterativa i de manera recursiva).
        public static void Exercici5()
        {
            const string MsgEx5 = "Introdueix un numero no decmial i et retornaré el factorial d'aquest";
            const string MsgResult = "El factorial del numero introduit és {0}";

            Console.WriteLine(MsgEx5);

            int userNumb = CheckNumbers.CheckValidNumberNoNegative();
            int result = userNumb;

            for (int i = 1; i < userNumb; i++)//Iterativa
            {
                result *= i;
            }
            Console.WriteLine(MsgResult, result);
            Console.WriteLine($"{userNumb} {(CheckNumbers.NumberIsPrime(userNumb) ? "és un nombre primer." : "no és un nombre primer.")}");
        }
        public static int FactorialRecursiu(int userNumb) //Recursiva
        {
            if (userNumb <= 1) return 1;
            return userNumb * FactorialRecursiu(userNumb - 1);
        }
       
        //6. Demana 10 números a l’usuari, desa'ls en un array, mostra la mitjana i quants valors són parells i quants no ho són.
        public static void Exercici6()
        {
            const string MsgEx5 = "Introdueix 10 numeros i faré la mitjana.";
            const int NumberCount = 10;
            int[] numbers = new int[NumberCount];
            int sum = 0, evenCount = 0, oddCount = 0;

            Console.WriteLine(MsgEx5);

            for (int i = 0; i < NumberCount; i++)
            {
                Console.Write($"Numero {i + 1}: ");
                numbers[i] = CheckNumbers.CheckValidNumber();
                sum += numbers[i];

                if (numbers[i] % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }
            double average = (double)sum / NumberCount;

            Console.WriteLine($"La mitja es: {average}");
            Console.WriteLine($"Hi han {evenCount} numeros parells");
            Console.WriteLine($"Hi han {oddCount} numeros senars");
        }
        public static void Exercici7()
        {
        }
        public static void Exercici8()
        {
        }
        public static void Exercici9()
        {
        }
    }
}

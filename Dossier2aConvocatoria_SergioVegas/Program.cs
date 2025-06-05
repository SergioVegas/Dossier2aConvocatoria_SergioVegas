using Dossier2aConvocatoria_SergioVegas.Tools;
using System;

namespace Dossier2aConvocatoria_SergioVegas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Exercici5();
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
            Console.WriteLine(MsgResult,result);
            Console.WriteLine($"{userNumb} {(NumberIsPrime(userNumb) ? "és un nombre primer." : "no és un nombre primer.")}");
        }
        public static int FactorialRecursiu(int userNumb) //Recursiva
        {
            if (userNumb <= 1) return 1;
            return userNumb * FactorialRecursiu(userNumb - 1);
        }
        static bool NumberIsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
    }
}

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
            int option;
            do
            {
                Console.WriteLine("\nMenú:");
                Console.WriteLine("1. Calcular àrea d’un rectangle");
                Console.WriteLine("2. Mostrar si un any és de traspàs");
                Console.WriteLine("3. Sortir del programa");
                Console.Write("Selecciona una opció: ");

                option = CheckNumbers.CheckValidNumberNoNegative();

                switch (option)
                {
                    case 1:
                        CalculateRectangleArea();
                        break;
                    case 2:
                        CheckLeapYear();
                        break;
                    case 3:
                        Console.WriteLine("Has sortit del programa.");
                        break;
                    default:
                        Console.WriteLine("Opció no vàlida! Torna-ho a intentar.");
                        break;
                }
            } while (option != 3);
        }
        static void CalculateRectangleArea()
        {
            Console.Write("Introdueix la base del rectangle: ");
            double baseRectangle = CheckNumbers.CheckValidDecimalNumberNoNegative();

            Console.Write("Introdueix l'altura del rectangle: ");
            double heightRectangle = CheckNumbers.CheckValidDecimalNumberNoNegative();

            double area = baseRectangle * heightRectangle;
            Console.WriteLine($"L'àrea del rectangle és: {area}");
        }

        static void CheckLeapYear()
        {
            Console.Write("Introdueix un any: ");
            int year = CheckNumbers.CheckValidNumberNoNegative(); ;

            bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            Console.WriteLine(isLeapYear ? $"{year} és un any de traspàs." : $"{year} no és un any de traspàs.");
        }
        // 8. Implementa un programa que demani dos nombres per teclat, faci la divisió i capturi possibles excepcions (per ex. divisió entre 0 o format invàlid).
        public static void Exercici8()
        {
            try
            {
                Console.Write("Introdueix el primer nombre: ");
                double userNumb1 = double.Parse(Console.ReadLine());

                Console.Write("Introdueix el segon nombre: ");
                double userNumb2 = double.Parse(Console.ReadLine());

                if (userNumb2 == 0)
                    throw new DivideByZeroException("No es pot dividir per zero!");

                double result = userNumb1 / userNumb2;
                Console.WriteLine($"El resultat de la divisió és: {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Has d'introduir un nombre vàlid.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"S'ha produït un error inesperat: {ex.Message}");
            }
        }
        public static void Exercici9()
        {
        }
    }
}

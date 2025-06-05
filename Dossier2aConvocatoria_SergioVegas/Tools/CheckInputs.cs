using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dossier2aConvocatoria_SergioVegas.Tools
{
    public class CheckInputs
    {
        const string MsgErrorFormatNumber = "Format incorrecte. Introdueix un numero.";
        const string MsgErrorFormatDate = "Format incorrecte. Introdueix una data dd/MM/yyyy.";
        const string MsgErrorNegative= "El numero no pot ser menor a 0.";
        const string MsgIsOdd = "El numero és senar.";
        const string MsgIsEven = "El numero és parell";
        public static int CheckValidNumber()
        {
            
            bool isCorrectFormat = false;
            int userNumb = 0;
            while (!isCorrectFormat)
            {
                try
                {
                    userNumb = int.Parse(Console.ReadLine());
                    isCorrectFormat = true;
                }
                catch (FormatException) { Console.WriteLine(MsgErrorFormatNumber); }
            }
            return userNumb;
        }
        public static double CheckValidDecimalNumber()
        {

            bool isCorrectFormat = false;
            double userNumb = 0;
            while (!isCorrectFormat)
            {
                try
                {
                    userNumb = int.Parse(Console.ReadLine());
                    isCorrectFormat = true;
                }
                catch (FormatException) { Console.WriteLine(MsgErrorFormatNumber); }
            }
            return userNumb;
        }
        public static int CheckValidNumberNoNegative()
        {

            bool isCorrectFormat = false;
            int userNumb = 0;

            while (!isCorrectFormat)
            {
                try
                {
                    userNumb = int.Parse(Console.ReadLine());
                    isCorrectFormat = true;
                    if (userNumb <= 0) 
                    {
                        isCorrectFormat = false;
                        Console.WriteLine(MsgErrorNegative);
                    }
                   
                }
                catch (FormatException) { Console.WriteLine(MsgErrorFormatNumber); }
            }
            return userNumb;
        }
        public static double CheckValidDecimalNumberNoNegative()
        {

            bool isCorrectFormat = false;
            double userNumb = 0;

            while (!isCorrectFormat)
            {
                try
                {
                    userNumb = int.Parse(Console.ReadLine());
                    isCorrectFormat = true;
                    if (userNumb <= 0)
                    {
                        isCorrectFormat = false;
                        Console.WriteLine(MsgErrorNegative);
                    }

                }
                catch (FormatException) { Console.WriteLine(MsgErrorFormatNumber); }
            }
            return userNumb;
        }
        public static DateTime CheckValidDate()
        {
            bool isCorrectFormat = false;
            DateTime userDate = DateTime.MinValue;

            while (!isCorrectFormat)
            {
                
                try
                {
                    userDate = DateTime.Parse(Console.ReadLine());
                    isCorrectFormat = true;


                }
                catch (FormatException) { Console.WriteLine(MsgErrorFormatDate); }
            }
            return userDate;
        }
        public static bool NumberIsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static void NumberEvenOrOdd(int n)
        {
            Console.WriteLine(n % 2 == 0 ? MsgIsEven : MsgIsOdd);
        }
    }
}

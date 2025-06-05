using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dossier2aConvocatoria_SergioVegas.Tools
{
    public class CheckNumbers
    {
        const string MsgErrorFormat = "Format incorrecte. Introdueix un numero.";
        const string MsgErrorNegative= "El numero no pot ser menor a 0.";
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
                catch (FormatException) { Console.WriteLine(MsgErrorFormat); }
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
                catch (FormatException) { Console.WriteLine(MsgErrorFormat); }
            }
            return userNumb;
        }
    }
}

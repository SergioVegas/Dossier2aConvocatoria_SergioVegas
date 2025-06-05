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
    }
}

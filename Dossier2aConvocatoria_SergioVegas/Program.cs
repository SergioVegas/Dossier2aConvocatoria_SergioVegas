namespace Dossier2aConvocatoria_SergioVegas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Exercici7();
        }
        //7. Implementa un programa en C# que demani un nombre enter positiu i mostri tots els seus divisors parells. Utilitza la interpolació de cadenes per mostrar el resultat.
        public static void Exercici7()
        {
            const string MsgEx7 = "Introdueix un nombre positiu i et mostraré tots els seus divisors parrells!";
            const string ErrorEx7 = "Aquest no es un nombre positiu! Torna ha introduir un numero.";
            const string ErrorFormatEx7 = "Format incorrecte. Introdueix un numero positiu.";
            const string MsgIsEven = "{0} és un nombre par";
            const int Even = 2;
            bool isCorrectFormat = false;

            Console.WriteLine(MsgEx7);

            while (!isCorrectFormat)
            {
                try
                {
                    int userNumber = int.Parse(Console.ReadLine());

                    if (userNumber > 0) 
                    {
                        for (int i = 1; i < userNumber; i++)
                        {
                            if (i % Even == 0)
                            { Console.WriteLine(MsgIsEven, i); }
                        }

                        isCorrectFormat = true ;
                    }
                    else { Console.WriteLine(ErrorEx7); }
                }
                catch(FormatException) { Console.WriteLine(ErrorFormatEx7); }
            }
        }
    }
}

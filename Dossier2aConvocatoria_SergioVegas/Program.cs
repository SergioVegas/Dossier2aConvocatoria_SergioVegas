using Dossier2aConvocatoria_SergioVegas.Tools;
namespace Dossier2aConvocatoria_SergioVegas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Exercici8();
        }
        //7. Implementa un programa en C# que demani un nombre enter positiu i mostri tots els seus divisors parells. Utilitza la interpolació de cadenes per mostrar el resultat.
        public static void Exercici7()
        {
            const string MsgEx7 = "Introdueix un nombre positiu i et mostraré tots els seus divisors parrells!";
            const string ErrorEx7 = "Aquest no es un nombre positiu! Torna ha introduir un numero.";
            const int Even = 2;


            Console.WriteLine(MsgEx7);

            int userNumber = CheckNumbers.CheckValidNumber();

            if (userNumber > 0)
            {
                for (int i = 1; i < userNumber; i++)
                {
                    if (i % Even == 0)
                    { Console.WriteLine($"{i} és un nombre par"); }
                }
            }
            else { Console.WriteLine(ErrorEx7); }



        }
        //8. Modifica el diagrama de fluxe següent (implementa la modificació en un nou diagrama i en C#) perquè calculi la mitjana de N números introduïts per teclat. Mostra el resultat amb composite formatting.	
        public static void Exercici8()
        {
            const string MsgEx8 = "Introdueix N nombres i faré la mitjana";
            const string MsgEx8Number = "Introdueix un numero";
            const string MsgAverage = "{0} és la mitja dels numeros introduits";

            Console.WriteLine(MsgEx8);

            int userQuantityNumbers = CheckNumbers.CheckValidNumber();
            int amount = 0;

            for (int i = 0; i < userQuantityNumbers; i++)
            {
                Console.WriteLine(MsgEx8Number);
                int userNumb = CheckNumbers.CheckValidNumber();
                amount += userNumb;
            }
            Console.WriteLine(MsgAverage, amount / userQuantityNumbers);          
        }
    }
}

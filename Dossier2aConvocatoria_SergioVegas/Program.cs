using Dossier2aConvocatoria_SergioVegas.Tools;
namespace Dossier2aConvocatoria_SergioVegas
{
    public class Program
    {
        static void Main(string[] args)
        {
            Exercici9();
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
        //9. Selecciona dues expressions de l'exercici 4 i mostra com es podrien analitzar mitjançant l'eina de depuració de Visual Studio, incloent captures de pantalla de les finestres Watch.
        // Si x=4, y=7, p=true i q=false, avalua les expressions següents:

        public static void Exercici9()
        {
            // a) y > x && p == q → TRUE AND FALSE→ FALSE
            int x = 4;
            int y = 7;
            bool p = true;
            bool q = false;

            if (y > x && p == q) { Console.WriteLine("True");}
            else  { Console.WriteLine("False");}

            // b) (x + y) % 3 == 0 || p != q → FALSE OR TRUE → TRUE
            if ((x + y) % 3 == 0 || p != q) { Console.WriteLine("True"); }
            else { Console.WriteLine("False"); }
        }
    }
}

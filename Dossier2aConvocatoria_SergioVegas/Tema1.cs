using Dossier2aConvocatoria_SergioVegas.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dossier2aConvocatoria_SergioVegas
{
    public  class Tema1
    {
        public static void MenuT1()
        {
            Console.WriteLine("Menú d'Exercicis:");
            Console.WriteLine("1.Exercici 7");
            Console.WriteLine("2. Exercici 8");
            Console.WriteLine("3. Exercici 9");
            Console.WriteLine("4. Exercici 10");
            Console.WriteLine("5. Exercici 11");
            Console.WriteLine("0. Sortir");

            Console.Write("Selecciona una opció: ");
            int opcio = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (opcio)
            {
                case 1:
                    Exercici7();
                    break;
                case 2:
                    Exercici8();
                    break;
                case 3:
                    Exercici9();
                    break;
                case 4:
                    Exercici10();
                    break;
                case 5:
                    Exercici11();
                    break;
                case 0:
                    Console.WriteLine("Has sortit del programa.");
                    break;
                default:
                    Console.WriteLine("Opció no vàlida. Torna a intentar-ho.");
                    break;
            }
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

            if (y > x && p == q) { Console.WriteLine("True"); }
            else { Console.WriteLine("False"); }

            // b) (x + y) % 3 == 0 || p != q → FALSE OR TRUE → TRUE
            if ((x + y) % 3 == 0 || p != q) { Console.WriteLine("True"); }
            else { Console.WriteLine("False"); }
        }

        /*10. Donat el següent fragment de codi C# amb errors:
            int x = 10
            string y = "20";
            int z = x + y;
            Console.WriteLine("El resultat és: " z);*/
        public static void Exercici10()
        {
            //En general canviar els noms per fer més llegible el codi
            const string MsgResult = "El resultat és: {0}";
            const string MsgFormatError = "Error de format";

            int userNumb = 10; //Faltaba punt y coma. ; expected
            string userNumbString = "20";
            int userNumb2 = 0;

            if (int.TryParse(userNumbString, out userNumb2)) //TryParse per gestionar errors
            {
                int result = userNumb + userNumb2; //Aquesta operació no es podia fer perquè la varibale y és un string. Cannot implicitly convert type 'string' to 'int'
                Console.WriteLine(MsgResult, result); //Aquest missatge no esta en un format correcte, ademés que per millorar el codi ha de ser una constant.
            }
            else { throw new FormatException(MsgFormatError); }
        }
        /*11. Analitza el següent codi i proposa maneres d'optimitzar-lo:
                for(int i = 0; i< 100; i++) {
                    if(i % 2 == 0) {
                    Console.WriteLine(i + " és parell");
                    }
                }*/
        public static void Exercici11()
        {
            const string MsgResult = "{0} és parell.";
            const int Even = 2;
            const int LastNumber = 100; //Constant si sempre serà 100, si volem donar l'opció a l'usuari ha de ser una variable.

            //Una opció per millorar el rendiment del codi, seria fer l'increment de 2 en 2, ja que sabem que tots serian parells.
            for (int i = 0; i < LastNumber; i += 2)
            {
                if (i % Even == 0)
                {
                    Console.WriteLine(MsgResult, i); //Canviar la concatenació i fer una constant amb el string que utiltzarem.
                }
            }
        }
    }
}

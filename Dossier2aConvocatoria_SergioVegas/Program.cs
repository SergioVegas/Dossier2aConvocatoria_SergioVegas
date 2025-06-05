using Dossier2aConvocatoria_SergioVegas.Tools;
using System;
using System.Text.RegularExpressions;

namespace Dossier2aConvocatoria_SergioVegas
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Exercici25();
        }
        // 5.  Implementa un programa que retorni per pantalla el factorial d’un número introduït per teclat i si aquest és primer o no (de manera iterativa i de manera recursiva).
        public static void Exercici5()
        {
            const string MsgEx5 = "Introdueix un numero no decmial i et retornaré el factorial d'aquest";
            const string MsgResult = "El factorial del numero introduit és {0}";

            Console.WriteLine(MsgEx5);

            int userNumb = CheckInputs.CheckValidNumberNoNegative();
            int result = userNumb;

            for (int i = 1; i < userNumb; i++)//Iterativa
            {
                result *= i;
            }
            Console.WriteLine(MsgResult, result);
            Console.WriteLine($"{userNumb} {(CheckInputs.NumberIsPrime(userNumb) ? "és un nombre primer." : "no és un nombre primer.")}");
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
                numbers[i] = CheckInputs.CheckValidNumber();
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

                option = CheckInputs.CheckValidNumberNoNegative();

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
            double baseRectangle = CheckInputs.CheckValidDecimalNumberNoNegative();

            Console.Write("Introdueix l'altura del rectangle: ");
            double heightRectangle = CheckInputs.CheckValidDecimalNumberNoNegative();

            double area = baseRectangle * heightRectangle;
            Console.WriteLine($"L'àrea del rectangle és: {area}");
        }

        static void CheckLeapYear()
        {
            Console.Write("Introdueix un any: ");
            int year = CheckInputs.CheckValidNumberNoNegative(); ;

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
        /* 9. Implementa una funció que comprovi que una contrasenya:
                 Té entre 8 i 12 caràcters
                 Inclou almenys una majúscula, una minúscula i un número
                 No contingui espais*/
        public static void Exercici9()
        {
            Console.Write("Introdueix una contrasenya:\nHa de tenir entre 8 i 12 caràcters \nIncloré almenys una majúscula, una minúscula i un número i no pot tenir espais.\n");
            string password = Console.ReadLine();

            if (ValidatePassword(password))
                Console.WriteLine("La contrasenya és vàlida!");
            else
                Console.WriteLine("La contrasenya no compleix els requisits.");
        }
        static bool ValidatePassword(string password)
        {
            if (password.Length < 8 || password.Length > 12)
                return false; // Comprova la longitud

            bool hasUpper = false, hasLower = false, hasDigit = false;

            foreach (char c in password)
            {
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsLower(c)) hasLower = true;
                if (char.IsDigit(c)) hasDigit = true;
            }
            if (password.Contains(" "))
                return false; // Comprova que no hi ha espais

            return hasUpper && hasLower && hasDigit; ;
        }
        //10.Comprova que una cadena tingui 8 dígits seguits d’una lletra (no cal validar la lletra final).
        public static void Exercici10()
        {
            const string MsgEx10 = "Escriu una cadena que tingui 8 dígits seguits d’una lletra.";

            Console.WriteLine(MsgEx10);
            string input = Console.ReadLine();

            Console.WriteLine(ValidateFormat(input) ? "Correcte!" : "");
        }
        static bool ValidateFormat(string input)
        {
            const string MsgIncorrectLenght = "La cadena ha de trindre 8 digits més una lletra.";
            const string MsgIncorrectDigit = "La cadena ha de trindre 8 numeros!.";

            if (input.Length != 9) { Console.WriteLine(MsgIncorrectLenght); return false; } // La cadena ha de tenir 9 caràcters en total

            for (int i = 0; i < 8; i++) // Comprova els primers 8 caràcters
            {
                if (!char.IsDigit(input[i])) { Console.WriteLine(MsgIncorrectDigit); return false; }
            }
            return true;
        }
        //11. Demana a l’usuari una data en format dd/MM/yyyy. Mostra si és una data vàlida i en quin dia de la setmana cau.
        public static void Exercici11()
        {
            const string MsgEx11 = "Introdueix una data en format dd/MM/yyyy i et dire quin dia de la setmana és";
            Console.WriteLine(MsgEx11);
            Console.WriteLine(CheckInputs.CheckValidDate().DayOfWeek);
        }
        /*12. Fes un programa que demani un número i digui si és:
            Positiu, negatiu o zero
            Parell o senar*/
        public static void Exercici12()
        {
            const string MsgEx12 = "Introdueix un numero no decimal.";

            Console.WriteLine(MsgEx12);

            int userNumb = CheckInputs.CheckValidNumber();

            if (userNumb == 0) { Console.WriteLine("El numero introduit es zero"); }
            else if (userNumb < 0) { Console.WriteLine("El numero introduit es negatiu"); CheckInputs.NumberEvenOrOdd(userNumb); }
            else { Console.WriteLine("El numero introduit es positiu"); CheckInputs.NumberEvenOrOdd(userNumb); }
        }
        //13. Demana un número a l'usuari i mostra la seva taula de multiplicar del 1 al 10.
        public static void Exercici13()
        {
            Console.Write("Introdueix un número: ");
            int num = CheckInputs.CheckValidNumberNoNegative();

            Console.WriteLine($"Taula de multiplicar del {num}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} × {i} = {num * i}");
            }
        }
        /*14. Crea un programa que:
            Demani 5 números i els guardi en un array
            Mostri tots els números introduïts
            Calculi i mostri la suma de tots els números*/
        public static void Exercici14()
        {
            const string MsgEx14 = "Introdueix 5 numeros i fare la suma de tots.";
            const int NumCount = 5;
            int[] numbers = new int[NumCount];
            int sum = 0;

            Console.WriteLine(MsgEx14);

            for (int i = 0; i < NumCount; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numbers[i] = CheckInputs.CheckValidNumber();
                sum += numbers[i];
            }

            Console.WriteLine("\nNúmeros introduïts:");
            foreach (int num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.WriteLine($"\nSuma total dels números: {sum}");
        }
        //15. Crea una funció que rebi un número i retorni el seu quadrat. Demostra el seu funcionament des del Main.
        public static void Exercici15()
        {
            Console.Write("Introdueix un número: ");
            int num = CheckInputs.CheckValidNumber();

            Console.WriteLine($"El quadrat de {num} és {Square(num)}");
        }
        static int Square(int number)
        {
            return number * number;
        }
        //16. Fes un programa que demani un número entre 1 i 100. Si l'usuari introdueix un número fora d'aquest rang o un valor no numèric, torni a demanar-lo fins que sigui correcte.
        public static void Exercici16()
        {
            const int MinRange = 1;
            const int MaxRange = 100;
            Console.Write("Introdueix un número en el rang de 1 i 100 inlcosos: ");

            double num = CheckInputs.CheckNumberRange(0, 100);
        }
        //17. Demana 10 números per teclat, guarda'ls en un array i després demana un número a buscar. El programa ha de dir si aquest número es troba a l'array i en quina posició.
        public static void Exercici17()
        {
            const string MsgEx17 = "Introdueix 10 numeros i despres introdueix el numero que vulguis trobar.";
            const int NumCount = 10;
            int[] numbers = new int[NumCount];

            Console.WriteLine(MsgEx17);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Número{i + 1}: ");
                numbers[i] = CheckInputs.CheckValidNumber();
            }
            Console.WriteLine("Quin numero vols trobar?");

            int userNumbFind = CheckInputs.CheckValidNumber();
            int position = Array.IndexOf(numbers, userNumbFind);

            if (position != -1)
            {
                Console.WriteLine($"El número {userNumbFind} es troba a la posició {position} de l'array.");
            }
            else
            {
                Console.WriteLine($"El número {userNumbFind} no es troba a l'array.");
            }
        }
        /*18. Crea un programa que:
            Demani 5 paraules i les guardi en un array
            Mostri les paraules en ordre invers
         */
        public static void Exercici18()
        {
            const int WordCount = 5;
            string[] words = new string[WordCount];

            Console.WriteLine("Introdueix 5 paraules:");

            for (int i = 0; i < WordCount; i++)
            {
                Console.Write($"Paraula {i + 1}: ");
                words[i] = Console.ReadLine();
            }

            Console.WriteLine("\nParaules en ordre invers:");
            for (int i = WordCount - 1; i >= 0; i--)
            {
                Console.WriteLine(words[i]);
            }
        }
        //19. Fes un programa que demani un número enter i calculi la suma dels seus dígits.
        public static void Exercici19()
        {

            Console.Write("Introdueix un número enter: ");
            int userNumb = CheckInputs.CheckValidNumber();

            int sum = SumDigits(userNumb);
            Console.WriteLine($"La suma dels dígits de {userNumb} és: {sum}");
        }
        static int SumDigits(int userNumb)
        {
            int sum = 0;

            while (userNumb != 0)
            {
                sum += userNumb % 10; // Agafa l'últim dígit
                userNumb /= 10; // Redueix el número eliminant l'últim dígit
            }

            return sum;
        }
        /*20. Demana 8 números i mostra:
            El número més gran
            El número més petit
            La mitjana*/
        public static void Exercici20()
        {
            const int NumCount = 8;
            int[] numbers = new int[NumCount];

            Console.WriteLine("Introdueix 8 números:");

            for (int i = 0; i < NumCount; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numbers[i] = CheckInputs.CheckValidNumber();
            }

            int maxNumber = numbers.Max();
            int minNumber = numbers.Min();
            double average = numbers.Average();

            Console.WriteLine($"El número més gran és: {maxNumber}");
            Console.WriteLine($"El número més petit és: {minNumber}");
            Console.WriteLine($"La mitjana dels números és: {average}");
        }
        // 21. Crea un programa que: Demani una temperatura en graus Celsius Pregunti si vol convertir a Fahrenheit o Kelvin Mostri el resultat de la conversió
        public static void Exercici21()
        {
            Console.Write("Introdueix una temperatura en graus Celsius: ");
            double celsius = CheckInputs.CheckValidDecimalNumber(); ;

            Console.Write("Vols convertir-la a Fahrenheit (F) o Kelvin (K)? ");
            char option = char.ToUpper(Console.ReadLine()[0]);

            double convertedTemp;

            switch (option)
            {
                case 'F':
                    convertedTemp = CelsiusToFahrenheit(celsius);
                    Console.WriteLine($"La temperatura en Fahrenheit és: {convertedTemp} °F");
                    break;

                case 'K':
                    convertedTemp = CelsiusToKelvin(celsius);
                    Console.WriteLine($"La temperatura en Kelvin és: {convertedTemp} K");
                    break;

                default:
                    Console.WriteLine("Opció no vàlida. Si us plau, tria 'F' o 'K'.");
                    break;
            }
        }
        static double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        static double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }
        /*22. Fes un joc on:
            L'ordinador generi un número aleatori entre 1 i 50
            L'usuari hagi d'endevinar-lo
            El programa digui "Més alt" o "Més baix" fins que l'encerti
            Mostri el nombre d'intents necessaris*/
        public static void Exercici22()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 51); // Número aleatori entre 1 i 50
            int attempts = 0;
            int userGuess = 0;

            Console.WriteLine("Endevina el número entre 1 i 50!");

            while (userGuess != secretNumber)
            {
                Console.Write("Introdueix la teva resposta: ");

                userGuess = CheckInputs.CheckValidNumber();
                attempts++;

                if (userGuess < secretNumber)
                    Console.WriteLine("Més alt!");
                else if (userGuess > secretNumber)
                    Console.WriteLine("Més baix!");
                else
                    Console.WriteLine($"Correcte! Has encertat en {attempts} intents.");
            }
        }
        //23. Implementa i testeja amb MsTest una funció IsEven(int num) que retorni true si és parell i false en cas contrari.
        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }
        //24. Implementa i testeja amb XUnit una funció IsOdd(int num) que retorni true si és senar i false en cas contrari.
        public static bool IsOdd(int num)
        {
            return num % 2 != 0;
        }
        //25. Millora el codi següent aplicant patrons de Clean Code:
        /* int[] arr = { 3, 4, 1 };
         for (int i = 0; i < arr.Length; i++)
         {
             for (int j = i + 1; j < arr.Length; j++)
             {
                 if (arr[i] > arr[j])
                 {
                     int tmp = arr[i];
                     arr[i] = arr[j];
                     arr[j] = tmp;
                 }
             }
         }
         Console.WriteLine(string.Join(",", arr));*/
        public static void Exercici25()
        {
            int[] arrayNumbers = { 3, 4, 1 };

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                for (int j = i + 1; j < arrayNumbers.Length; j++)
                {
                    if (arrayNumbers[i] > arrayNumbers[j]) //Nomes si el numero enmagatzemat a la posicio i és més gran que el que esta a la j
                    {
                        int organizer = arrayNumbers[i]; //Utilitzem aquesta variable per organitzar l'array de més petit a més gran.

                        arrayNumbers[i] = arrayNumbers[j];
                        arrayNumbers[j] = organizer;
                    }
                }
            }
            Console.WriteLine(string.Join(",", arrayNumbers));
        }
        /*26. Reescriu aquest fragment donant noms significatius i afegint comentaris útil
            int x = 5;
            if (x % 2 == 0) Console.WriteLine("E");
            else Console.WriteLine("O");*/

        public static void Exercici26()
        {
            //Missatges en constants per millorar lectura del codi. Ademés donem noms entedibles per si mateixos.
            const string MsgIsEven = "Aquest numero és parell";
            const string MsgIsOdd = "Aquest numero és impar";

            int number = 5;

            Console.WriteLine(number % 2 == 0 ? MsgIsEven : MsgIsOdd); //Utilitzem un ternari per fer el codi més llegible.
        }
    }
}

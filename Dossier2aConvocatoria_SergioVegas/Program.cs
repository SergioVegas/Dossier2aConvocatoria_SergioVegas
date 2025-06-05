using Dossier2aConvocatoria_SergioVegas.Tools;


namespace Dossier2aConvocatoria_SergioVegas
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            int option;
            do
            {
                Console.WriteLine("\nMenú de Temes:");
                Console.WriteLine("1. Veure Tema 1");
                Console.WriteLine("2. Veure Tema 2");
                Console.WriteLine("0. Sortir");
                Console.Write("Selecciona un tema: ");

                option = CheckInputs.CheckValidNumber();

                switch (option)
                {
                    case 1:
                        Tema1.MenuT1(); // Crida al menú del Tema 1
                        break;
                    case 2:
                        Tema2.MenuT2(); // Crida al menú del Tema 2
                        break;
                    case 0:
                        Console.WriteLine("Has sortit del programa.");
                        break;
                    default:
                        Console.WriteLine("Opció no vàlida! Torna-ho a intentar.");
                        break;
                }
            } while (option != 0);
        }
    }
}

using extension;
using System;

// Exemple de method d'extension d'une class (dans ce cas String)
namespace extension
{
    public static class StringExtension
    {
        public static int CountIndexA(this string str)
        {
            return str.IndexOf("A");
        }
    }
}


namespace ConsoleC_Stephane
{
    public class Calculator
    {
        public static double DoOperation(double num1, double num2, string op)
        {
            // valeur par defaut en cas d'erreur
            double result = double.NaN; 

            // Switch a(ddition), s(oustraction), m(ultiplication), d(ivision)
            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":

                    // Si pas division par zero
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;

                // Retour si saisie différente de a, m, s, d
                default:
                    break;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            // Initialisation affichage
            String textTitre = "Calculatrice en console en C#\r";
            int nbreA = textTitre.CountIndexA;
            Console.WriteLine(textTitre);
            Console.WriteLine("-----------------------------\n");

            while (!endApp)
            {
                // Declaration variables
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // Saisie du 1er nombre
                Console.Write("Saisir un 1er nombre et appuez sur entrée : ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Ce n'est pas un nombre, saisir un nombre : ");
                    numInput1 = Console.ReadLine();
                }

                // Saisie du 2ème nombre
                Console.Write("Saisir un 2eme nombre et appuez sur entrée : ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Ce n'est pas un nombre, saisir un nombre : ");
                    numInput2 = Console.ReadLine();
                }

                // Saisir un opérateur
                Console.WriteLine("Choisissez un opérateur parmi la liste :");
                Console.WriteLine("\ta - Adition");
                Console.WriteLine("\ts - Soustraction");
                Console.WriteLine("\tm - Multiplication");
                Console.WriteLine("\td - Division");
                Console.Write("Saisir votre choix et appuez sur entrée : ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Cette opération n'est pas possible.\n");
                    }
                    else Console.WriteLine("Résultat: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Une exceptiona été rencontrée.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Saisir 'q' + entrée pour sortir, ou appuez sur entrée pour continuer: ");
                if (Console.ReadLine() == "q") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }
    }

}

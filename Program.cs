using System.ComponentModel.Design;

namespace Jeu_de_maths
{
    internal class Program
    {

        enum e_Operateur
        {
            ADDITION = 1,
            MULTIPLICATION = 2,
            SUSTRACTION = 3,
            DIVISION = 4,

        }
        static bool PoserQuestion(int min, int max)
        {

            Random random = new Random();
            int reponseInt = 0;
            while (true)
            {

                int minValue = random.Next(min, max + 1);
                int maxValue= random.Next(min, max + 1);

                e_Operateur operateur =(e_Operateur)random.Next(1, 5);//entre 1 et 2, 1 pour l'addition et 2 pour la multiplication
                int resultatFinal;
                if (operateur == e_Operateur.ADDITION)
                {
                    Console.WriteLine(minValue + " + " + maxValue + " = ");
                    resultatFinal = minValue + maxValue;
                }
                else if (operateur == e_Operateur.MULTIPLICATION)
                {
                    Console.WriteLine(minValue + " x " + maxValue + " = ");
                    resultatFinal = minValue * maxValue;
                }
                else if (operateur == e_Operateur.SUSTRACTION)
                {
                    Console.WriteLine(minValue + " - " + maxValue + " = ");
                    resultatFinal = minValue - maxValue;
                }
                else if (operateur == e_Operateur.DIVISION)
                {
                    Console.WriteLine(minValue + " / " + maxValue + " = ");
                    resultatFinal = minValue / maxValue;
                }
                else
                {
                    Console.WriteLine("Erreur: l'operateur inconnu.");
                    return false;
                }

                string reponse = Console.ReadLine();
                try
                {
                    reponseInt = int.Parse(reponse);
                    if (reponseInt == resultatFinal) 
                    { 
                        return true;
                        
                    }       
                    return false;
                }
                catch
                {
                    Console.WriteLine("Erreur, vous devez entrer un nombre.");
                }
            }
        }
        static void Main(string[] args)
        {
            const int MIN_VALUE_REPONSE = 1;
            const int MAX_VALUE_REPONSE = 10;
            const int NOMBRE_DE_TOURS = 5;

            int points = 0;
            for (int i = 0; i< NOMBRE_DE_TOURS; i++)
            {
                Console.WriteLine("Question no." + (i+1) + "/" + NOMBRE_DE_TOURS);
                bool bonneReponse = PoserQuestion(MIN_VALUE_REPONSE, MAX_VALUE_REPONSE);
                if (bonneReponse)
                {
                    Console.WriteLine("Bonne reponse!");
                    points++;
                }
                else
                {
                    Console.WriteLine("Mauvaise reponse!");

                }
                Console.WriteLine();
            }
            Console.WriteLine("Nombre de points: " + points + "/" + NOMBRE_DE_TOURS);
            if (points == NOMBRE_DE_TOURS)
            {
                Console.WriteLine("Excelent!");
            }
            else if (points > NOMBRE_DE_TOURS / 2) 
            { 
                Console.WriteLine("Pas mal!");
            }
            else if (points <= NOMBRE_DE_TOURS / 2) 
            { 
                Console.WriteLine("Peut faire mieux.");
            }
        }
    }
}

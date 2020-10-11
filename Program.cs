using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetZeBank
{
    class Program
    {
        static void Main(string[] args)
        {
            string sex, job, familyStituation;
            int age, salary, asset, loan, child, choice;
            double seniority;

            string[] sexTable = new string[] { "choisir 1 pour homme ou 2 pour femme", "homme", "femme" };
            string[] jobTable = new string[] { "choisir une catégorie d'activité", "Fonctionnaire", "Salarié(e)", "Libéral", "Artisant", "Chômeur" };
            string[] familyTable = new string[] { "choisir une situation familliale", "Célibataire", "Marié(e)", "Divorcé(e)", "Veuf(ve)" };

            Console.WriteLine("******************************************");
            Console.WriteLine("Calculateur de points pour ûn prêt");
            Console.WriteLine("******************************************");
            
            Console.WriteLine("\nBonjour.");
            Console.WriteLine("Merci de saisir l'ensemble des éléments permettant le calcul de vos points.\n");

            try
            {
                Console.Write("Saisir votre sexe (1- homme ; 2- femme) : ");
                choice = Convert.ToInt32(Console.ReadLine());
                sex = sexTable[choice];
            }
            catch (FormatException)
            {
                Console.WriteLine(sexTable[0]);
                choice = Convert.ToInt32(Console.ReadLine());
                sex = sexTable[choice];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine(sexTable[0]);
                choice = Convert.ToInt32(Console.ReadLine());
                sex = sexTable[choice];
            }

            try
            {
                Console.Write("\nSaisir votre age :");
                age = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.Write("\nMerci de saisir un chiffre pour votre age :");
                age = Convert.ToInt32(Console.ReadLine());
            }

            try
            {
                Console.Write("\nSaisir votre profession (1- Fonctionnaire ; 2- Salarié(e) ; 3- Libéral(e) ; 4- Artisant ; 5- Chômeur) : ");
                choice = Convert.ToInt32(Console.ReadLine());
                job = jobTable[choice];
            }
            catch (FormatException)
            {
                Console.WriteLine("Merci de faire un choix parmi les catégories proposée " +
                    "(1- Fonctionnaire ; 2- Salarié(e) ; 3- Libéral(e) ; 4- Artisant ; 5- Chômeur) :");
                choice = Convert.ToInt32(Console.ReadLine());
                job = jobTable[choice];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Merci de faire un choix parmi les catégories proposée " +
                    "(1- Fonctionnaire ; 2- Salarié(e) ; 3- Libéral(e) ; 4- Artisant ; 5- Chômeur) :");
                choice = Convert.ToInt32(Console.ReadLine());
                job = jobTable[choice];
            }

            try
            {
                Console.Write("\nSaisir votre situation familiale (1- Célibatair(e) ; 2- Marié(e) ; 3- Divorcé(e) ; 4- Veuf(ve)) : ");
                choice = Convert.ToInt32(Console.ReadLine());
                familyStituation = familyTable[choice];
            }
            catch(FormatException)
            {
                Console.WriteLine("Saisir votre situation familiale (1- Célibatair(e) ; 2- Marié(e) ; 3- Divorcé(e) ; 4- Veuf(ve)) : ");
                choice = Convert.ToInt32(Console.ReadLine());
                familyStituation = familyTable[choice];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Merci de faire un choix parmi les situations proposées " +
                    "(1- Fonctionnaire ; 2- Salarié(e) ; 3- Libéral(e) ; 4- Artisant ; 5- Chômeur) :");
                choice = Convert.ToInt32(Console.ReadLine());
                familyStituation = familyTable[choice];
            }

            try
            {
                Console.Write("\nSaisir le nombre d'enfant(s) à charge : ");
                child = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.Write("\nMerci de saisir un chiffre pour le nombre d'enfants à charge :");
                child = Convert.ToInt32(Console.ReadLine());
            }

            try
            {
                Console.Write("\nSaisir votre salaire annuel: ");
                salary = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.Write("\nMerci de saisir un chiffre pour votre salaire annuel :");
                salary = Convert.ToInt32(Console.ReadLine());
            }

            try
            {
                Console.Write("\nSaisir le montant de vos avoirs déclarés dans la banque : ");
                asset = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("\nMerci de saisir un chiffre pour le montant des avoirs :");
                asset = Convert.ToInt32(Console.ReadLine());
            }

            try
            {
                Console.Write("\nSaisir votre ancienneté : ");
                seniority = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("\nMerci de saisir un chiffre pour votre ancienneté :");
                seniority = Convert.ToDouble(Console.ReadLine());
            }

            try
            {
                Console.Write("\nSaisir le montant du prêt souhaité : ");
                loan = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("\nMerci de saisir un chiffre pour le prêt souhaité :");
                loan = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\n");
            Profil profil = new Profil(sex, job, age, familyStituation, salary, asset, loan, child, seniority);

            Bank bank = new Bank(profil);
            bank.AttributionPret();
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetZeBank
{
    class Program
    {
        static void Main(string[] args)
        {
            string sex, job, familyStituation;
            int age, salary, asset, loan, child, choice;
            double seniority;

            string[] sexTable = new string[] { "choisir homme ou femme", "homme", "femme" };
            string[] jobTable = new string[] { "choisir une catégorie d'activité", "Fonctionnaire", "Salarié(e)", "Libéral", "Artisant", "Chômeur" };
            string[] familyTable = new string[] { "choisir une situation familliale", "Célibataire", "Marié(e)", "Divorcé(e)", "Veuf(ve)" };

            Console.WriteLine("sexe :");
            choice = Convert.ToInt32(Console.ReadLine());
            sex = sexTable[choice];
            Console.WriteLine(sex);


            Console.WriteLine("age :");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("profession (1-5) :");
            choice = Convert.ToInt32(Console.ReadLine());
            job = jobTable[choice];
            Console.WriteLine(job);
  

            Console.WriteLine("situation familiale (1-4) :");
            choice = Convert.ToInt32(Console.ReadLine());
            familyStituation = familyTable[choice];


            Console.WriteLine("Enfant(s) :");
            child = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("salaire annuel:");
            salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("avoir :");
            asset = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ancienneté :");
            seniority = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Montant du prêt :");
            loan = Convert.ToInt32(Console.ReadLine());

            Profil profil = new Profil(sex, job, age, familyStituation, salary, asset, loan, child, seniority);

            Bank bank = new Bank(profil);
            bank.AttributionPret();
        }

    }
}

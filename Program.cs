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
            string sex, job="", familyStituation = "";
            int age, salary, asset, loan, child;
            double seniority;

            Console.WriteLine("sexe :");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        sex = "homme";
                        break;
                    }
                case 2:
                    {
                        sex = "femme";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

            Console.WriteLine("age :");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("profession :");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        job = "Fonctionnaire";
                        break;
                    }
                case 2:
                    {
                        job = "Salarié(e)";
                        break;
                    }
                case 3:
                    {
                        job = "Libéral";
                        break;
                    }
                case 4:
                    {
                        job = "Artisant";
                        break;
                    }
                case 5:
                    {
                        job = "Chômeur";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }   

            Console.WriteLine("situation familiale (1-4) :");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        familyStituation = "celibataire";
                        break;
                    }
                case 2:
                    {
                        familyStituation = "Marié(e)";
                        break;
                    }
                case 3:
                    {
                        familyStituation = "Divorcé(e)";
                        break;
                    }
                case 4:
                    {
                        familyStituation = "Veuf(ve)";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

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
            //bank.Present();
        }

    }
}

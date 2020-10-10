using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetZeBank
{
    class Bank
    {
        private Profil profilBank { get; set; }

        public Bank(Profil profil)
        {
            profilBank = profil;
        }

        int point = 0, pointSex, pointAge, pointJob, pointSalary, pointFamily, pointChild, pointAsset, pointBonus, pointSeniority;
        float score;

        public void AttributionPret()
        {
            if (profilBank.Sex() == "homme")
            {
                pointSex += 0;
            }
            else
            {
                pointSex += 50;
            }

            if (profilBank.Age() > 19)
            {
                if (profilBank.Age() > 80)
                {
                    pointAge += 0;
                }
                else if (profilBank.Age() > 64 && profilBank.Age() <= 80)
                {
                    pointAge += 150;
                }
                else if (profilBank.Age() > 44 && profilBank.Age() <= 64)
                {
                    pointAge += 100;
                }
                else if (profilBank.Age() > 20 && profilBank.Age() <= 44)
                {
                    pointAge += 50;
                }
            }

            if(profilBank.Job() != "Chômeur")
            {
                if (profilBank.Job() == "Fonctionnaire")
                {
                    pointJob += 100;
                }
                else if (profilBank.Job() == "Salarié(e)")
                {
                    pointJob += 70;
                }
                else if (profilBank.Job() == "Libéral")
                {
                    pointJob += 50;
                }
                else if (profilBank.Job() == "Artisant")
                {
                    pointJob += 40;
                }
            }

            if (profilBank.Loan() < profilBank.Salary() * 2)
            {
                if (profilBank.Loan() <= profilBank.Salary() / 2)
                {
                    pointSalary += 150;
                }
                else if (profilBank.Loan() <= profilBank.Salary())
                {
                    pointSalary += 100;
                }
                else if (profilBank.Loan() <= profilBank.Salary() * 2)
                {
                    pointSalary += 50;
                }
            }

            if (profilBank.Salary() >= 120000)
            {
                pointBonus += 150;
            }

            if (profilBank.FamilySituation() == "Célibataire" || profilBank.FamilySituation() == "Veuf(ve)")
            {
                pointFamily += 100;
            }
            else if (profilBank.FamilySituation() == "Marié(e)")
            {
                pointFamily += 200;
            }
            else if (profilBank.FamilySituation() == "Divorcé(e)")
            {
                pointFamily += 50;
            }

            if (profilBank.Child() >= 1)
            {
                if (profilBank.Child() > 0 && profilBank.Child() <= 3)
                {
                    pointChild += profilBank.Child() * 10;
                }
                else
                {
                    pointChild += 30;
                }
            }

            if (profilBank.Seniority() >= 1)
            {
                if (profilBank.Seniority() > 5)
                {
                    pointSeniority += 100;
                }
                else
                {
                    pointSeniority += Convert.ToInt32(profilBank.Seniority() * 10);
                }
            }

            if (profilBank.Asset() != 0)
            {
                if (profilBank.Asset() > profilBank.Loan())
                {
                    pointAsset += 100;
                }
                else if (profilBank.Asset() > profilBank.Loan() / 2)
                {
                    pointAsset += 50;
                }
                else if (profilBank.Asset() > profilBank.Loan() / 4)
                {
                    pointAsset += 25;
                }

            }
            
            Console.WriteLine("Points attribués pour le sexe : " + pointSex);
            Console.WriteLine("Points attribués pour l'age : " + pointAge);
            Console.WriteLine("Points attribués en fonction de la catégorie d'emploi : " + pointJob);
            Console.WriteLine("Points attribués pour le salaire : " + pointSalary);
            Console.WriteLine("Points attribués pour un salaire suppérieure à 120000€ : " + pointBonus);
            Console.WriteLine("Points attribués pour la situation familliale : " + pointFamily);
            Console.WriteLine("Points attribués en fonction du nombre d'enfants : " + pointChild);
            Console.WriteLine("Points attribués pour l'anciènneté dans la banque : " + pointSeniority);
            Console.WriteLine("Points attribués en fonction des avoirs dans la banque : " + pointAsset);

            point = pointSex + pointAge + pointFamily + pointSalary + pointAsset + pointJob + pointSeniority + pointBonus;
            Console.WriteLine("Nombre total de points : " + point);
            score = (float) (point * 20) / 1030;
            Console.WriteLine("******************************************");
            Console.WriteLine("Score finale : " + score.ToString("0.##") + "/20");
            Console.WriteLine("******************************************");
            if(score >= 10)
            {
                Console.WriteLine("Votre crédit est accordé.");
            }
            else
            {
                Console.WriteLine("Votre crédit est refusé.");
            }
            Console.ReadKey();
        }
    }
}

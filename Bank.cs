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

        int point = 0;
        float score;

        public void AttributionPret()
        {
            if (profilBank.Sex() == "homme")
            {
                point += 0;
            }
            else
            {
                point += 50;
            }

            Console.WriteLine(point);
            Console.ReadKey();

            if (profilBank.Age() > 19)
            {
                if (profilBank.Age() > 80)
                {
                    point += 0;
                }
                else if (profilBank.Age() > 64 && profilBank.Age() <= 80)
                {
                    point += 150;
                }
                else if (profilBank.Age() > 44 && profilBank.Age() <= 64)
                {
                    point += 100;
                }
                else if (profilBank.Age() > 20 && profilBank.Age() <= 44)
                {
                    point += 50;
                }
                Console.WriteLine(point);
                Console.ReadKey();
            }


            if(profilBank.Job() != "Chômeur")
            {
                if (profilBank.Job() == "Fonctionnaire")
                {
                    point += 100;
                }
                else if (profilBank.Job() == "Salarié(e)")
                {
                    point += 70;
                }
                else if (profilBank.Job() == "Libéral")
                {
                    point += 50;
                }
                else if (profilBank.Job() == "Artisant")
                {
                    point += 40;
                }
                Console.WriteLine(point);
                Console.ReadKey();
            }



            if (profilBank.Loan() < profilBank.Salary() * 2)
            {
                if (profilBank.Loan() <= profilBank.Salary() / 2)
                {
                    point += 150;
                    if (profilBank.Salary() >= 120000)
                    {
                        point += 150;
                    }
                    Console.WriteLine(point);
                    Console.ReadKey();
                }
                else if (profilBank.Loan() <= profilBank.Salary())
                {
                    point += 100;
                }
                else if (profilBank.Loan() <= profilBank.Salary() * 2)
                {
                    point += 50;
                }
                Console.WriteLine(point);
                Console.ReadKey();
            }

            if (profilBank.FamilySituation() == "Célibataire" || profilBank.FamilySituation() == "Veuf(ve)")
            {
                point += 100;
            }
            else if (profilBank.FamilySituation() == "Marié(e)")
            {
                point += 200;
            }
            else if (profilBank.FamilySituation() == "Divorcé(e)")
            {
                point += 50;
            }

            Console.WriteLine(point);
            Console.ReadKey();

            if (profilBank.Child() >= 1)
            {
                if (profilBank.Child() > 0 && profilBank.Child() <= 3)
                {
                    point += profilBank.Child() * 10;
                }
                else
                {
                    point += 30;
                }
                Console.WriteLine(point);
                Console.ReadKey();
            }


            if (profilBank.Seniority() >= 1)
            {
                if (profilBank.Seniority() > 5)
                {
                    point += 100;
                }
                else
                {
                    point += (int)profilBank.Seniority() * 10;
                }
                Console.WriteLine(point);
                Console.ReadKey();
            }

            if (profilBank.Asset() != 0)
            {
                if (profilBank.Asset() > profilBank.Loan())
                {
                    point += 100;
                }
                else if (profilBank.Asset() > profilBank.Loan() / 2)
                {
                    point += 50;
                }
                else if (profilBank.Asset() > profilBank.Loan() / 4)
                {
                    point += 25;
                }
            }

            score = (float) (point * 20) / 1030;
            Console.WriteLine(score);

        }
    }
}

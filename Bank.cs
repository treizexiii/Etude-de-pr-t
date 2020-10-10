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
            else if (profilBank.Age() > 19 && profilBank.Age() <= 44)
            {
                point += 50;
            }
            else
            {
                point += 0;
            }

            Console.WriteLine(point);
            Console.ReadKey();

            if(profilBank.Job() == "Fonctionnaire")
            {
                point += 100;
            }
            else if(profilBank.Job() == "Salarié(e)")
            {
                point += 70;
            }
            else if(profilBank.Job() == "Libéral")
            {
                point += 50;
            }
            else if(profilBank.Job() == "Artisant")
            {
                point += 40;
            }
            else if (profilBank.Job() == "Chômeur")
            {
                point += 0;
            }

            Console.WriteLine(point);
            Console.ReadKey();

            if(profilBank.Loan()<= profilBank.Salary()/2)
            {
                point += 150;
            }
            else if(profilBank.Loan() <= profilBank.Salary())
            {
                point += 100;
            }
            else if(profilBank.Loan()<= profilBank.Salary()*2)
            {
                point += 50;
            }
            else
            {
                point += 0;
            }

            Console.WriteLine(point);
            Console.ReadKey();

            if(profilBank.Salary() == 120000)
            {
                point += 150;
            }

            Console.WriteLine(point);
            Console.ReadKey();

            if (profilBank.FamilySituation() == "celibataire" || profilBank.FamilySituation() == "Veuf(ve)")
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

            if(profilBank.Child() > 0 && profilBank.Child() <= 3)
            {
                point += profilBank.Child() * 10;
            }

            Console.WriteLine(point);
            Console.ReadKey();

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

        public void Present()
        {
            Console.WriteLine(profilBank.Sex());
            Console.WriteLine(profilBank.Age());
            Console.WriteLine(profilBank.Job());
            Console.WriteLine(profilBank.FamilySituation());
            Console.WriteLine(profilBank.Child());
            Console.WriteLine(profilBank.Salary());
            Console.WriteLine(profilBank.Asset());
            Console.WriteLine(profilBank.Seniority());
            Console.WriteLine(profilBank.Loan());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProjetZeBank
{
    public class Profil
    {
        private string _sex { get; set; }
        private string _job { get; set; }
        private int _age { get; set; }
        private string _familySituation { get; set; }
        private int _salary { get; set; }
        private int _asset { get; set; }
        private int _loan { get; set; }
        private int _child { get; set; }
        private double _seniority { get; set; }

        public Profil(string sex, string job,  int age, string familySituation, int salary, int asset, int loan, int child, double seniority)
        {
            _age = age;
            _sex = sex;
            _job = job;
            _familySituation = familySituation;
            _salary = salary;
            _asset = asset;
            _loan = loan;
            _child = child;
            _seniority = seniority;
        }

        public string Sex()
        {
            return _sex;
        }
        public int Age()
        {
            return _age;
        }
        public string Job()
        {
            return _job;
        }
        public string FamilySituation()
        {
            return _familySituation;
        }
        public int Child()
        {
            return _child;
        }
        public int Salary()
        {
            return _salary;
        }
        public int Asset()
        {
            return _asset;
        }
        public double Seniority()
        {
            return _seniority;
        }
        public int Loan()
        {
            return _loan;
        }

    }
}

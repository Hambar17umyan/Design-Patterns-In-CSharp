using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    internal class BankCustomer
    {
        public string Name;
        public string LastName;
        public int Age;
        public int CreditHistoryRate;
        Gender Gender;

        public BankCustomer(string name,
            string lastName,
            int age,
            int creditHistoryRate,
            Gender gender)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            CreditHistoryRate = creditHistoryRate;
            Gender = gender;
        }
    }
}

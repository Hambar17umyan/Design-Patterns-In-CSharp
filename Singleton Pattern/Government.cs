using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_Pattern
{
    internal class Government
    {
        public static string Description { get; } = "The government is the main governing body of a country";
        private decimal Budget;
        private static Government? _government = null;
        private static readonly object lockObject = new object();
        private Government(decimal budget)
        {
            Budget = budget;
        }

        public static Government GetGovernmentInstance()
        {
            lock (lockObject)
            {
                if (_government == null)
                {
                    _government = new Government(100000000000000.49665m);
                }
            }
            return _government;
        }

        public decimal GovernmentMoney13Percent()
        {
            return (Budget * 13) / 100;
        }
    }
}

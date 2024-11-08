using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    internal class FilterBuilder
    {
        public bool ShouldSortByName;
        public bool ShouldSortByNameDesc;
        public bool ShouldSortByAge;
        public bool ShouldSortByAgeDesc;
        public bool ShouldSortByLastName;
        public bool ShouldSortByLastNameDesc;
        public bool ShouldSortByCreditHistoryRate;
        public bool ShouldSortByCreditHistoryRateDesc;

        public bool NameShouldContain;
        public string NameShouldContainArg;

        public bool NameShouldNotContain;
        public string NameShouldNotContainArg;

        public bool LastNameShouldNotContain;
        public string LastNameShouldNotContainArg;

        public bool LastNameShouldContain;
        public string LastNameShouldContainArg;

        public bool AgeShouldMeMoreThan;
        public int AgeShouldBeMoreThanArg;

        public bool AgeShouldMeLessThan;
        public int AgeShouldBeLessThanArg;

        public bool GenderShouldBe;
        public Gender GenderShouldBeArg;

        public bool GenderShouldBeNot;
        public Gender GenderShouldBeNotArg;

        public bool CreditHistoryRateShouldBeMoreThan;
        public int CreditHistoryRateShouldBeMoreThanArg;

        public bool CreditHistoryRateShouldBeLessThan;
        public int CreditHistoryRateShouldBeLessThanArg;

        public FilterBuilder SortByName()
        {
            ShouldSortByName = true;
            return this;
        }

        public FilterBuilder SortByNameDesc()
        {
            ShouldSortByNameDesc = true;
            return this;
        }

        public FilterBuilder SortByLastName()
        {
            ShouldSortByLastName = true;
            return this;
        }

        public FilterBuilder SortByLastNameDesc()
        {
            ShouldSortByLastNameDesc = true;
            return this;
        }

        public FilterBuilder SortByAge()
        {
            ShouldSortByAge = true;
            return this;
        }

        public FilterBuilder SortByAgeDesc()
        {
            ShouldSortByAgeDesc = true;
            return this;
        }

        public FilterBuilder SortByCreditHistoryRate()
        {
            ShouldSortByCreditHistoryRate = true;
            return this;
        }

        public FilterBuilder SortByCreditHistoryRateDesc()
        {
            ShouldSortByCreditHistoryRateDesc = true;
            return this;
        }

        public FilterBuilder FilterWithNameContaining(string name)
        {
            NameShouldContain = true;
            NameShouldContainArg = name;
            return this;
        }

        public FilterBuilder FilterWithNameNotContaining(string name)
        {
            NameShouldNotContain = true;
            NameShouldNotContainArg = name;
            return this;
        }

        public FilterBuilder FilterWithLastNameContaining(string lastName)
        {
            LastNameShouldContain = true;
            LastNameShouldContainArg = lastName;
            return this;
        }

        public FilterBuilder FilterWithLastNameNotContaining(string lastName)
        {
            LastNameShouldNotContain = true;
            LastNameShouldNotContainArg = lastName;
            return this;
        }

        public FilterBuilder FilterWithAgeMoreThan(int age)
        {
            AgeShouldMeMoreThan = true;
            AgeShouldBeMoreThanArg = age;
            return this;
        }

        public FilterBuilder FilterWithAgeLessThan(int age)
        {
            AgeShouldMeLessThan = true;
            AgeShouldBeLessThanArg = age;
            return this;
        }

        public FilterBuilder FilterWithGender(Gender gender)
        {
            GenderShouldBe = true;
            GenderShouldBeArg = gender;
            return this;
        }

        public FilterBuilder FilterWithGenderNot(Gender gender)
        {
            GenderShouldBeNot = true;
            GenderShouldBeNotArg = gender;
            return this;
        }

        public FilterBuilder FilterWithCreditHistoryRateMoreThan(int rate)
        {
            CreditHistoryRateShouldBeMoreThan = true;
            CreditHistoryRateShouldBeMoreThanArg = rate;
            return this;
        }

        public FilterBuilder FilterWithCreditHistoryRateLessThan(int rate)
        {
            CreditHistoryRateShouldBeLessThan = true;
            CreditHistoryRateShouldBeLessThanArg = rate;
            return this;
        }

        public Filter BuildFilter()
        {
            return new Filter(ShouldSortByName, ShouldSortByNameDesc, ShouldSortByAge, ShouldSortByAgeDesc,
            ShouldSortByLastName, ShouldSortByLastNameDesc, ShouldSortByCreditHistoryRate, ShouldSortByCreditHistoryRateDesc,
            NameShouldContain, NameShouldContainArg, NameShouldNotContain, NameShouldNotContainArg,
            LastNameShouldContain, LastNameShouldContainArg, LastNameShouldNotContain, LastNameShouldNotContainArg,
            AgeShouldMeMoreThan, AgeShouldBeMoreThanArg, AgeShouldMeLessThan, AgeShouldBeLessThanArg,
            GenderShouldBe, GenderShouldBeArg, GenderShouldBeNot, GenderShouldBeNotArg,
            CreditHistoryRateShouldBeMoreThan, CreditHistoryRateShouldBeMoreThanArg,
            CreditHistoryRateShouldBeLessThan, CreditHistoryRateShouldBeLessThanArg);
        }
    }
}

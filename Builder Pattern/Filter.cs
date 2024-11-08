using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern
{
    internal class Filter
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
        public string? NameShouldContainArg;

        public bool NameShouldNotContain;
        public string? NameShouldNotContainArg;

        public bool LastNameShouldNotContain;
        public string? LastNameShouldNotContainArg;

        public bool LastNameShouldContain;
        public string? LastNameShouldContainArg;

        public bool AgeShouldMeMoreThan;
        public int? AgeShouldBeMoreThanArg;

        public bool AgeShouldMeLessThan;
        public int? AgeShouldBeLessThanArg;

        public bool GenderShouldBe;
        public Gender? GenderShouldBeArg;

        public bool GenderShouldBeNot;
        public Gender? GenderShouldBeNotArg;

        public bool CreditHistoryRateShouldBeMoreThan;
        public int? CreditHistoryRateShouldBeMoreThanArg;

        public bool CreditHistoryRateShouldBeLessThan;
        public int? CreditHistoryRateShouldBeLessThanArg;

        public Filter(bool shouldSortByName, bool shouldSortByNameDesc, bool shouldSortByAge, bool shouldSortByAgeDesc, bool shouldSortByLastName, bool shouldSortByLastNameDesc, bool shouldSortByCreditHistoryRate, bool shouldSortByCreditHistoryRateDesc, bool nameShouldContain, string? nameShouldContainArg, bool nameShouldNotContain, string? nameShouldNotContainArg, bool lastNameShouldNotContain, string? lastNameShouldNotContainArg, bool lastNameShouldContain, string? lastNameShouldContainArg, bool ageShouldMeMoreThan, int? ageShouldBeMoreThanArg, bool ageShouldMeLessThan, int? ageShouldBeLessThanArg, bool genderShouldBe, Gender? genderShouldBeArg, bool genderShouldBeNot, Gender? genderShouldBeNotArg, bool creditHistoryRateShouldBeMoreThan, int? creditHistoryRateShouldBeMoreThanArg, bool creditHistoryRateShouldBeLessThan, int? creditHistoryRateShouldBeLessThanArg)
        {
            ShouldSortByName = shouldSortByName;
            ShouldSortByNameDesc = shouldSortByNameDesc;
            ShouldSortByAge = shouldSortByAge;
            ShouldSortByAgeDesc = shouldSortByAgeDesc;
            ShouldSortByLastName = shouldSortByLastName;
            ShouldSortByLastNameDesc = shouldSortByLastNameDesc;
            ShouldSortByCreditHistoryRate = shouldSortByCreditHistoryRate;
            ShouldSortByCreditHistoryRateDesc = shouldSortByCreditHistoryRateDesc;
            NameShouldContain = nameShouldContain;
            NameShouldContainArg = nameShouldContainArg;
            NameShouldNotContain = nameShouldNotContain;
            NameShouldNotContainArg = nameShouldNotContainArg;
            LastNameShouldNotContain = lastNameShouldNotContain;
            LastNameShouldNotContainArg = lastNameShouldNotContainArg;
            LastNameShouldContain = lastNameShouldContain;
            LastNameShouldContainArg = lastNameShouldContainArg;
            AgeShouldMeMoreThan = ageShouldMeMoreThan;
            AgeShouldBeMoreThanArg = ageShouldBeMoreThanArg;
            AgeShouldMeLessThan = ageShouldMeLessThan;
            AgeShouldBeLessThanArg = ageShouldBeLessThanArg;
            GenderShouldBe = genderShouldBe;
            GenderShouldBeArg = genderShouldBeArg;
            GenderShouldBeNot = genderShouldBeNot;
            GenderShouldBeNotArg = genderShouldBeNotArg;
            CreditHistoryRateShouldBeMoreThan = creditHistoryRateShouldBeMoreThan;
            CreditHistoryRateShouldBeMoreThanArg = creditHistoryRateShouldBeMoreThanArg;
            CreditHistoryRateShouldBeLessThan = creditHistoryRateShouldBeLessThan;
            CreditHistoryRateShouldBeLessThanArg = creditHistoryRateShouldBeLessThanArg;
        }
    }
}

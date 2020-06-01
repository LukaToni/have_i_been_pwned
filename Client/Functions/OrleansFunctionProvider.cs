using System;
using System.Collections.Generic;
using System.Text;

namespace Client.Functions
{
    public class OrleansFunctionProvider : IOrleansFunctionProvider
    {
        public IList<IOrleansFunction> GetOrleansFunctions()
        {
            return new List<IOrleansFunction>()
            {
                // OPERATINAL
                new AddNewMail(),
                new CheckMailPresent(),
                new RemoveMail(),
                // STATISTIC
                new NumberOfMailPerDomain(),
                new NumberOfMailPerTopLevelDomain()
            };
        }
    }
}

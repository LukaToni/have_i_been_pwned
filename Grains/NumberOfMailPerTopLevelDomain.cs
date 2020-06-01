using GrainInterfaces;
using Microsoft.Extensions.Logging;
using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Grains
{
    public class NumberOfMailPerTopLevelDomain : Grain, INumberOfMailPerTopLevelDomain
    {
        private readonly ILogger logger;

        public NumberOfMailPerTopLevelDomain(ILogger<AddNewMail> logger)
        {
            this.logger = logger;
        }

        Task<string> INumberOfMailPerTopLevelDomain.GetNumberOfMailPerTopLevelDomain(string topDomain)
        {
            logger.LogInformation($"\n Get number of mail per top level domain= '{topDomain}'");
            logger.LogInformation($"\n TODO: function getTopDomainNumber(string domain)");
            return Task.FromResult($"\n Client said: '{topDomain}', so Hello says: Top domain level!");
        }

    }
}

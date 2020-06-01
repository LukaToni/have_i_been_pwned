using GrainInterfaces;
using Microsoft.Extensions.Logging;
using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Grains
{
    public class NumberOfMailPerDomain : Grain, INumberOfMailPerDomain
    {
        private readonly ILogger logger;

        public NumberOfMailPerDomain(ILogger<NumberOfMailPerDomain> logger)
        {
            this.logger = logger;
        }

        Task<string> INumberOfMailPerDomain.GetNumberOfMailPerDomain(string domain)
        {
            logger.LogInformation($"\n Checked domain = '{domain}'");
            logger.LogInformation($"\n TODO: function getDomainNumber(string domain)");
            return Task.FromResult($"\n Client said: '{domain}', so Hello says: Get domain number!");
        }

    }
}

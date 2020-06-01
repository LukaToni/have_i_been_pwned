using GrainInterfaces;
using Microsoft.Extensions.Logging;
using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Grains
{
    public class CheckMailPresent: Grain, ICheckMailPresent
    {
        private readonly ILogger logger;

        public CheckMailPresent(ILogger<CheckMailPresent> logger)
        {
            this.logger = logger;
        }

        Task<string> ICheckMailPresent.CheckMail(string mail)
        {
            logger.LogInformation($"\n Check mail= '{mail}'");
            return Task.FromResult($"\n Client said: '{mail}', so Hello says: Mail checked!");
        }

    }
}

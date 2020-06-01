using GrainInterfaces;
using Microsoft.Extensions.Logging;
using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Grains
{
    public class RemoveMail: Grain, IRemoveMail
    {
        private readonly ILogger logger;

        public RemoveMail(ILogger<RemoveMail> logger)
        {
            this.logger = logger;
        }

        Task<string> IRemoveMail.RemoveMail(string mail)
        {
            logger.LogInformation($"\n Removed mail= '{mail}'");
            return Task.FromResult($"\n Client said: '{mail}', so Hello says: Removed mail!");
        }

    }
}

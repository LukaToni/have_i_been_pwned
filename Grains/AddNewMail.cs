using GrainInterfaces;
using Microsoft.Extensions.Logging;
using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Grains
{
    public class AddNewMail: Grain, IAddNewMail
    {
        private readonly ILogger logger;

        public AddNewMail(ILogger<AddNewMail> logger)
        {
            this.logger = logger;
        }

        Task<string> IAddNewMail.NewMail(string mail)
        {
            logger.LogInformation($"\n Added new mail= '{mail}'");
            return Task.FromResult($"\n Client said: '{mail}', so Hello says: Ok mail!");
        }

    }
}

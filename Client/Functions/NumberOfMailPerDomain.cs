using Client.Helpers;
using GrainInterfaces;
using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Client.Functions
{
    public class NumberOfMailPerDomain : IOrleansFunction
    {
        public string Description => "Get number of mail per domain";
        public async Task PerformFunction(IClusterClient clusterClient)
        {
            var grain = clusterClient.GetGrain<INumberOfMailPerDomain>(Guid.NewGuid());
            Console.WriteLine("Get number of mail per domain");
            var domain = Console.ReadLine();

            Console.WriteLine(await grain.GetNumberOfMailPerDomain(domain));

            ConsoleHelpers.ReturnToMenu();
        }
    }
}

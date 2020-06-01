using Client.Helpers;
using GrainInterfaces;
using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Client.Functions
{
    public class NumberOfMailPerTopLevelDomain : IOrleansFunction
    {
        public string Description => "Get number of mail per top level domain";
        public async Task PerformFunction(IClusterClient clusterClient)
        {
            var grain = clusterClient.GetGrain<INumberOfMailPerTopLevelDomain>(Guid.NewGuid());

            Console.WriteLine("What domain would like to add to breached mails?");
            var topDomain = Console.ReadLine();

            Console.WriteLine(await grain.GetNumberOfMailPerTopLevelDomain(topDomain));

            ConsoleHelpers.ReturnToMenu();
        }
    }
}

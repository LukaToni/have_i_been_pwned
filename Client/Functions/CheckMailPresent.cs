using Client.Helpers;
using GrainInterfaces;
using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Client.Functions
{
    public class CheckMailPresent : IOrleansFunction
    {
        public string Description => "Check mail present";
        public async Task PerformFunction(IClusterClient clusterClient)
        {
            var grain = clusterClient.GetGrain<ICheckMailPresent>(Guid.NewGuid());
            Console.WriteLine("Please write valid mail to check if from breached mails:");
            var mail = Console.ReadLine();

            bool isValidMail = RegexUtilities.IsValidEmail(mail);
            if (isValidMail) {
                Console.WriteLine(await grain.CheckMail(mail));
            } else {
                Console.WriteLine("Not valid mail address!");
            }
            ConsoleHelpers.ReturnToMenu();
        }
    }
}

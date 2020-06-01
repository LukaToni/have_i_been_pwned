using Client.Helpers;
using GrainInterfaces;
using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Client.Functions
{
    public class RemoveMail : IOrleansFunction
    {
        public string Description => "Remove mail";
        public async Task PerformFunction(IClusterClient clusterClient)
        {
            var grain = clusterClient.GetGrain<IRemoveMail>(Guid.NewGuid());
            Console.WriteLine("to breached mails");
            var mail = Console.ReadLine();

            bool isValidMail = RegexUtilities.IsValidEmail(mail);
            if (isValidMail) {
                Console.WriteLine(await grain.RemoveMail(mail));
            } else {
                Console.WriteLine("Not valid mail address!");
            }
            ConsoleHelpers.ReturnToMenu();
        }
    }
}

using Client.Helpers;
using GrainInterfaces;
using Orleans;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Client.Functions
{
    public class AddNewMail : IOrleansFunction
    {
        public string Description => "Add new mail to DB";
        public async Task PerformFunction(IClusterClient clusterClient)
        {
            var grain = clusterClient.GetGrain<IAddNewMail>(Guid.NewGuid());
            Console.WriteLine("Please add valid mail to breached mails:");
            var mail = Console.ReadLine();

            bool isValidMail = RegexUtilities.IsValidEmail(mail);
            if (isValidMail) {
                Console.WriteLine(await grain.NewMail(mail));
            } else {
                Console.WriteLine("Not valid mail address!");
            }
            ConsoleHelpers.ReturnToMenu();
        }
    }
}
